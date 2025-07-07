using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_File_Browser
{
    public partial class FileControl : UserControl
    {
        public event EventHandler<string> FileClicked;
        public event EventHandler<string> FileDoubleClicked;

        public string FolderPath { get; set; }

        public bool IsSelected { get; private set; } = false;

        public FileControl(bool isFile, string fileName, string fileSize, string fileExtension)
        {
            InitializeComponent();

            if (isFile)
                Icon.IconChar = FontAwesome.Sharp.IconChar.File;
            else
                Icon.IconChar = FontAwesome.Sharp.IconChar.Folder;

            FileNameLabel.Text = fileName;
            FileExtensionLabel.Text = fileExtension;
            FileSizeLabel.Text = fileSize;

            this.Click += FileControl_Click;
        }

        private void FileControl_Click(object sender, EventArgs e)
        {
            Select();
            FileClicked?.Invoke(this, FolderPath);
        }

        public void Select()
        {
            IsSelected = true;
            this.BackColor = Color.FromArgb(35, 35, 35);
        }

        public void Deselect()
        {
            IsSelected = false;
            this.BackColor = Color.Transparent; // or whatever your normal color is
        }

        private void FileControl_DoubleClick(object sender, EventArgs e)
        {
            if (Icon.IconChar == FontAwesome.Sharp.IconChar.Folder)
            {
                FileDoubleClicked?.Invoke(this, FolderPath);
            }
        }
    }
}