﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NPC_File_Browser
{
    public partial class FileControl : UserControl
    {
        public event EventHandler<string> FileClicked;
        public event EventHandler<string> FileDoubleClicked;
        public string FolderPath { get; set; }
        public bool IsSelected { get; private set; } = false;
        public bool IsFile { get; private set; }

        public FileControl(bool isFile, string fileName, string fileSize, string fileExtension, string fullFileExt)
        {
            InitializeComponent();
            if (isFile)
                Icon.IconChar = FontAwesome.Sharp.IconChar.File;
            else
                Icon.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.IsFile = isFile;
            bool isFileNameLong = !(fileName.Length <= 25);

            FileNameLabel.Text = Path.GetFileName(fileName).Substring(0, (isFileNameLong ? 25 : fileName.Length)) + (isFileNameLong ? "..." : "") + (isFileNameLong && isFile && !String.IsNullOrEmpty(fullFileExt) ? "(" + fullFileExt + ")" : "");
            FileExtensionLabel.Text = fileExtension;
            FileSizeLabel.Text = fileSize;
            this.Click += FileControl_Click;
        }

        // Add this method to update the size dynamically
        public void UpdateSize(string newSize)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateSize), newSize);
                return;
            }

            FileSizeLabel.Text = newSize;
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
            this.BackColor = Color.Transparent;
        }

        private void FileControl_DoubleClick(object sender, EventArgs e)
        {
            FileDoubleClicked?.Invoke(this, FolderPath);
        }
    }
}