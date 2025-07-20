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
    public partial class SidebarFileControl : UserControl
    {
        public event EventHandler<string> FileDoubleClicked;
        public string FolderPath { get; set; }
        public bool IsSelected { get; private set; } = false;

        public SidebarFileControl(string fileName)
        {
            InitializeComponent();
            FileNameLabel.Text = fileName;
            this.DoubleClick += SidebarFileControl_DoubleClick;
        }

        private void SidebarFileControl_DoubleClick(object sender, EventArgs e)
        {
            FileDoubleClicked?.Invoke(this, FolderPath);
        }
    }
}