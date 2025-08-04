﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using NPC_File_Browser;
using RegistryFileTypeReader;
using System.Diagnostics;

namespace NPC_File_Browser
{
    public partial class Main : Form
    {
        enum DwmWindowAttribute : uint
        {
            DWMWA_USE_IMMERSIVE_DARK_MODE = 20,
            DWMWA_MICA_EFFECT = 38,
        }

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        [DllImport("dwmapi.dll")]
        static extern int DwmSetWindowAttribute(IntPtr hwnd, DwmWindowAttribute attr, ref int attrValue, int attrSize);

        List<string> PathsClicked = new List<string>();
        string CurrentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
        string LastPathClicked;
        string PinnedFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NPC_File_Browser", "pinned_folders.txt");

        private CancellationTokenSource _loadCancellationTokenSource;
        private readonly Dictionary<string, FileControl> _fileControls = new Dictionary<string, FileControl>();
        private bool isCtrlHold = false;

        public Main()
        {
            InitializeComponent();
        }

        private void EnableControlDarkMode(Control control)
        {
            int trueValue = 1;
            SetWindowTheme(control.Handle, "DarkMode_Explorer", null);
            DwmSetWindowAttribute(control.Handle, DwmWindowAttribute.DWMWA_USE_IMMERSIVE_DARK_MODE, ref trueValue, Marshal.SizeOf(typeof(int)));
            DwmSetWindowAttribute(control.Handle, DwmWindowAttribute.DWMWA_MICA_EFFECT, ref trueValue, Marshal.SizeOf(typeof(int)));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ContentPanel.Size = new Size(this.Size.Width - 267, this.Size.Height - 135);
            ContentPanel.Location = new Point(250, 100);
            EnableControlDarkMode(ContentPanel);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadItemsAsync(CurrentPath);
            PathTextbox.TextBoxText = CurrentPath;
            LoadSidebar();
            EnableControlDarkMode(ContentPanel);
        }

        private async Task LoadItemsAsync(string directory)
        {
            _loadCancellationTokenSource?.Cancel();
            _loadCancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = _loadCancellationTokenSource.Token;

            CurrentPath = directory;
            PathTextbox.TextBoxText = CurrentPath;
            ContentPanel.Controls.Clear();
            _fileControls.Clear();

            try
            {
                string[] folders = Directory.GetDirectories(directory);
                string[] files = Directory.GetFiles(directory);

                foreach (var folder in folders)
                {
                    if (cancellationToken.IsCancellationRequested) return;

                    DirectoryInfo info = new DirectoryInfo(folder);
                    var fileControl = AddItem(false, info.Name, "Calculating...", "Folder", info.FullName);

                    Task.Run(async () => await CalculateFolderSizeAsync(info, fileControl, cancellationToken));
                }

                foreach (var file in files)
                {
                    if (cancellationToken.IsCancellationRequested) return;

                    FileInfo info = new FileInfo(file);
                    string extension = info.Extension;
                    
                    if (!string.IsNullOrEmpty(extension) && extension.Length > 1)
                    {
                        try
                        {
                            RegistryFileTypeKey key = new RegistryFileTypeKey(extension);
                            if (key.ExtensionType != "")
                            {
                                extension = key.FriendlyTypeName;
                            }
                            else
                            {
                                extension = extension.Substring(1).ToUpper() + " File";
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            extension = extension.Substring(1).ToUpper() + " File";
                        }
                    }
                    else
                    {
                        extension = "File";
                    }

                    AddItem(true, info.Name, Helper.Helper.ConvertedSize(Convert.ToDouble(info.Length)),
                           extension, info.FullName);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied to this directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading directory: \n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CalculateFolderSizeAsync(DirectoryInfo info, FileControl fileControl, CancellationToken cancellationToken)
        {
            try
            {
                long size = await Helper.Helper.GetFolderSizeAsync(info, cancellationToken);

                if (!cancellationToken.IsCancellationRequested && !fileControl.IsDisposed)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => fileControl.UpdateSize(Helper.Helper.ConvertedSize(size))));
                    }
                    else
                    {
                        fileControl.UpdateSize(Helper.Helper.ConvertedSize(size));
                    }
                }
            }
            catch (Exception)
            {
                if (!cancellationToken.IsCancellationRequested && !fileControl.IsDisposed)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => fileControl.UpdateSize("Unknown")));
                    }
                    else
                    {
                        fileControl.UpdateSize("Unknown");
                    }
                }
            }
        }

        private FileControl AddItem(bool isFile, string fileName, string fileSize, string fileExtension, string fullPath)
        {
            FileControl FC = new FileControl(isFile, fileName, fileSize, fileExtension);
            FC.FolderPath = fullPath;
            FC.FileClicked += UpdateItems_FileClicked;
            FC.FileDoubleClicked += UpdateItems_FileDoubleClicked;
            ContentPanel.Controls.Add(FC);
            _fileControls[fullPath] = FC;
            return FC;
        }

        private void UpdateItems_FileClicked(object sender, string directory)
        {
            FileControl ctrl = sender as FileControl;
            Console.WriteLine("Click");
            if (!PathsClicked.Contains(directory))
            {
                if (!isCtrlHold) PathsClicked.Clear();
                foreach (FileControl c in _fileControls.Values)
                {
                    c.BackColor = Color.Transparent;
                }
                PathsClicked.Add(directory);
                ctrl.Select();
                LastPathClicked = directory;

                UpdateStarButton();
                EnableUI();
            }
            else
            {
                PathsClicked.Remove(directory);
            }
        }

        private void UpdateStarButton()
        {
            if (IsPathPinned(LastPathClicked))
            {
                ButtonStar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
            else
            {
                ButtonStar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            }
        }

        private async void UpdateItems_FileDoubleClicked(object sender, string directory)
        {
            Console.WriteLine("Dabl Click");
            FileControl ctrl = sender as FileControl;
            if (ctrl.IsFile)
            {
                try
                {
                    Console.WriteLine("Starting file");
                    Process.Start(ctrl.FolderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Console.WriteLine("Open folder");
                await LoadItemsAsync(directory);
            }
        }

        private async void ButtonReturn_Click(object sender, EventArgs e)
        {
            if (CurrentPath.Length > 3)
            {
                await LoadItemsAsync(Directory.GetParent(CurrentPath).FullName);
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private async void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                foreach (Control control in ContentPanel.Controls)
                {
                    if (control is FileControl fileControl && fileControl.IsSelected)
                    {
                        fileControl.Deselect();
                    }
                }

                PathsClicked.Clear();
                ButtonStar.IconFont = FontAwesome.Sharp.IconFont.Regular;
                DisableUI();
            }

            if (e.KeyCode == Keys.Enter && PathTextbox.TextBoxText != CurrentPath)
            {
                if (Directory.Exists(PathTextbox.TextBoxText))
                {
                    await LoadItemsAsync(PathTextbox.TextBoxText);
                }
            }

            if (e.KeyCode == Keys.ControlKey) isCtrlHold = true;
        }

        private void CopyDirectories(List<string> directories)
        {
            if (directories == null || directories.Count == 0) { return; }

            StringCollection paths = new StringCollection();
            paths.AddRange(directories.ToArray());

            Clipboard.SetFileDropList(paths);
            ButtonPaste.Enabled = true;
            ButtonPaste.IconColor = Color.White;
        }

        private void PasteDirectories(string directory)
        {
            if (!Directory.Exists(directory))
            {
                return;
            }

            if (Clipboard.ContainsFileDropList())
            {
                StringCollection paths = Clipboard.GetFileDropList();

                foreach (string path in paths)
                {
                    try
                    {
                        if (File.Exists(path))
                        {
                            File.Copy(path, Path.Combine(directory, Path.GetFileName(path)), overwrite: true);
                        }
                        else if (Directory.Exists(path))
                        {
                            Helper.Helper.CopyDirectory(path, Path.Combine(directory, Path.GetFileName(path)));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error pasting: " + ex.Message);
                    }
                }
            }
        }

        private void DeleteDirectories(List<string> directories)
        {
            foreach (string directory in directories)
            {
                if (File.Exists(directory))
                {
                    File.Delete(directory);
                }
                else if (Directory.Exists(directory))
                {
                    Directory.Delete(directory, true);
                }
            }
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            CopyDirectories(PathsClicked);
        }

        private async void ButtonPaste_Click(object sender, EventArgs e)
        {
            PasteDirectories(CurrentPath);

            foreach (Control control in ContentPanel.Controls)
            {
                if (control is FileControl fileControl && fileControl.IsSelected)
                {
                    fileControl.Deselect();
                }
            }

            PathsClicked.Clear();
            DisableUI();
            await LoadItemsAsync(CurrentPath);
        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteDirectories(PathsClicked);
            PathsClicked.Clear();
            DisableUI();
            await LoadItemsAsync(CurrentPath);
        }

        private void ButtonCut_Click(object sender, EventArgs e)
        {
            //Nah I aint doing this rn. I tried.
        }

        private void EnableUI()
        {
            ButtonCopy.Enabled = true;
            ButtonCopy.IconColor = Color.White;
            ButtonDelete.Enabled = true;
            ButtonDelete.IconColor = Color.White;
        }

        private void DisableUI()
        {
            ButtonCopy.Enabled = false;
            ButtonCopy.IconColor = Color.Gray;
            ButtonDelete.Enabled = false;
            ButtonDelete.IconColor = Color.Gray;
        }

        private async void ButtonRefresh_Click(object sender, EventArgs e)
        {
            PathsClicked.Clear();
            DisableUI();
            Helper.Helper.ClearSizeCache();
            await LoadItemsAsync(CurrentPath);
            PathTextbox.TextBoxText = CurrentPath;
        }

        private void LoadSidebar()
        {
            SidebarPanel.Controls.Clear();

            //Add common folders
            AddSidebarFile("Desktop", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            AddSidebarFile("Downloads", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads");
            AddSidebarFile("Documents", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            AddSidebarFile("Videos", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));

            AddSideBarSeperator();

            //Add drives
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    AddSidebarDrive(drive.Name.ToString().Remove(2, 1));
                }
            }
            catch { }

            AddSideBarSeperator();

            //Add pinned folders
            if (File.Exists(PinnedFilePath))
            {
                foreach (string path in File.ReadAllLines(PinnedFilePath))
                {
                    if (!string.IsNullOrWhiteSpace(path) && Directory.Exists(path))
                    {
                        string folderName = Path.GetFileName(path);
                        if (string.IsNullOrEmpty(folderName))
                        {
                            folderName = path;
                        }

                        AddSidebarFile(folderName, path);
                    }
                }
            }
        }

        private void AddSidebarFile(string folderName, string folderPath)
        {
            SidebarFileControl SFC = new SidebarFileControl(folderName);
            SFC.FolderPath = folderPath;
            SFC.FileDoubleClicked += async (sender, path) => { await LoadItemsAsync(folderPath); };
            SidebarPanel.Controls.Add(SFC);
        }

        private void AddSidebarDrive(string drive)
        {
            SideBarDriveControl SDC = new SideBarDriveControl(drive);
            SidebarPanel.Controls.Add(SDC);
        }

        private void AddSideBarSeperator()
        {
            Panel panel1 = new Panel();
            panel1.Size = new Size(236, 5);
            panel1.BackColor = Color.Transparent;
            Panel panel2 = new Panel();
            panel2.Size = new Size(236, 2);
            panel2.BackColor = Color.White;
            Panel panel3 = new Panel();
            panel3.Size = new Size(236, 5);
            panel3.BackColor = Color.Transparent;

            SidebarPanel.Controls.Add(panel1);
            SidebarPanel.Controls.Add(panel2);
            SidebarPanel.Controls.Add(panel3);
        }

        private void AddPinnedFolder(string folderPath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(PinnedFilePath));

            if (File.Exists(PinnedFilePath))
            {
                if (File.ReadAllLines(PinnedFilePath).Any(path => path.Equals(folderPath, StringComparison.OrdinalIgnoreCase))) { return; }
            }

            File.AppendAllText(PinnedFilePath, folderPath + Environment.NewLine);
        }

        private bool IsPathPinned(string folderPath)
        {
            if (File.Exists(PinnedFilePath))
            {
                return File.ReadAllLines(PinnedFilePath).Any(path => path.Equals(folderPath, StringComparison.OrdinalIgnoreCase));
            }

            return false;
        }

        private void RemovePinnedFolder(string folderPath)
        {
            if (File.Exists(PinnedFilePath))
            {
                File.WriteAllLines(PinnedFilePath, File.ReadAllLines(PinnedFilePath).Where(path => !path.Equals(folderPath, StringComparison.OrdinalIgnoreCase)).ToArray());
            }
        }

        private void ButtonStar_Click(object sender, EventArgs e)
        {
            if (IsPathPinned(LastPathClicked))
            {
                RemovePinnedFolder(LastPathClicked);
            }
            else
            {
                AddPinnedFolder(LastPathClicked);
            }

            UpdateStarButton();
            LoadSidebar();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _loadCancellationTokenSource?.Cancel();
            _loadCancellationTokenSource?.Dispose();
            base.OnFormClosed(e);
        }

        private async void PathTextbox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.ControlKey) isCtrlHold = false;
        }
    }
}