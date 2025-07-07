using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPC_File_Browser.Helper;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System;

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
            DwmSetWindowAttribute(control.Handle,
                DwmWindowAttribute.DWMWA_USE_IMMERSIVE_DARK_MODE,
                ref trueValue, Marshal.SizeOf(typeof(int)));
            DwmSetWindowAttribute(control.Handle,
                DwmWindowAttribute.DWMWA_MICA_EFFECT,
                ref trueValue, Marshal.SizeOf(typeof(int)));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ContentPanel.Size = new Size(this.Size.Width - 267, this.Size.Height - 135);
            ContentPanel.Location = new Point(250, 100);
            EnableControlDarkMode(ContentPanel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadItems(@"C:\Users\test\Downloads\Test");

            ContentPanel.FlowDirection = FlowDirection.TopDown;
            ContentPanel.WrapContents = false;
            EnableControlDarkMode(ContentPanel);
            ContentPanel.AutoScroll = true;
        }

        private void LoadItems(string directory)
        {
            CurrentPath = directory;
            ContentPanel.Controls.Clear();
            string[] folders = Directory.GetDirectories(directory);

            foreach (var folder in folders)
            {
                DirectoryInfo info = new DirectoryInfo(folder);

                AddItem(false, info.Name.ToString(), "size here", "Folder", info.FullName);
            }

            string[] files = Directory.GetFiles(directory);

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
                Console.WriteLine(directory);
            }
        }

        private void UpdateItems_FileDoubleClicked(object sender, string directory)
        {
            LoadItems(directory);
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            string newDirectory = Directory.GetParent(CurrentPath).FullName;
            LoadItems(newDirectory);
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
            }
        }
    }
}