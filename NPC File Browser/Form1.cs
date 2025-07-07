using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System;
using System.Collections.Specialized;

namespace NPC_File_Browser
{
    public partial class Form1 : Form
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

        string CurrentPath;
        List<string> PathsClicked = new List<string>();

        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentPath = @"C:\Users\test\Downloads\Test";
            LoadItems(CurrentPath);

            ContentPanel.FlowDirection = FlowDirection.TopDown;
            ContentPanel.WrapContents = false;
            ContentPanel.AutoScroll = true;
            EnableControlDarkMode(ContentPanel);
        }

        private void LoadItems(string directory)
        {
            CurrentPath = directory;
            ContentPanel.Controls.Clear();

            string[] folders = Directory.GetDirectories(directory);
            string[] files = Directory.GetFiles(directory);

            foreach (var folder in folders)
            {
                DirectoryInfo info = new DirectoryInfo(folder);
                AddItem(false, info.Name.ToString(), "size here", "Folder", info.FullName);
            }

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                AddItem(true, info.Name.ToString(), Helper.Helper.ConvertedSize(Convert.ToDouble(info.Length.ToString())), info.Extension.ToString().Remove(0, 1).ToUpper() + " File", info.FullName);
            }
        }

        private void AddItem(bool isFile, string fileName, string fileSize, string fileExtension, string fullPath)
        {
            FileControl FC = new FileControl(isFile, fileName, fileSize, fileExtension);
            FC.FolderPath = fullPath;
            FC.FileClicked += UpdateItems_FileClicked;
            FC.FileDoubleClicked += UpdateItems_FileDoubleClicked;
            ContentPanel.Controls.Add(FC);
        }

        private void UpdateItems_FileClicked(object sender, string directory)
        {
            if (PathsClicked.Contains(directory) == false) //Fixes adding the same directory twice
            {
                PathsClicked.Add(directory);
                EnableUI();
            }
        }

        private void UpdateItems_FileDoubleClicked(object sender, string directory)
        {
            LoadItems(directory);
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            LoadItems(Directory.GetParent(CurrentPath).FullName);
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
                DisableUI();
            }
        }

        private void CopyDirectories(List<string> directories)
        {
            if (directories == null || directories.Count == 0)
            {
                return;
            }

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

            else
            {
                MessageBox.Show("Clipboard does not contain any files or folders.");
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

        private void ButtonPaste_Click(object sender, EventArgs e)
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
            LoadItems(CurrentPath);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteDirectories(PathsClicked);
            PathsClicked.Clear();
            DisableUI();
            LoadItems(CurrentPath);
        }

        private void ButtonCut_Click(object sender, EventArgs e)
        {
            //Nah I aint doing this
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
    }
}