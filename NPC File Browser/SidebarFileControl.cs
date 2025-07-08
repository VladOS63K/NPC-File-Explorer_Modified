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
    public partial class SidebarFileControl: UserControl
    {
        public SidebarFileControl(string fileName)
        {
            InitializeComponent();

            FileNameLabel.Text = fileName;
        }
    }
}
