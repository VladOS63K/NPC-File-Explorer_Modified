using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinBlur;

namespace NPC_File_Browser
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            UI.SetBlurStyle(this, UI.BlurType.Acrylic, UI.Mode.DarkMode, false);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/CsharpProgramming/NPC-File-Explorer");
        }

        private void YouTubeCSharpClick(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@CsharpProgramming");
        }

        private void YouTubeVladOS63KClick(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@VladOS_63K");
        }

        private void GitHubCSharpClick(object sender, EventArgs e)
        {
            Process.Start("https://github.com/CsharpProgramming");
        }

        private void GitHubVladOS63KClick(object sender, EventArgs e)
        {
            Process.Start("https://github.com/VladOS63K");
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
