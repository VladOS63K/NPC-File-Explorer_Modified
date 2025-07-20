using System;
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
    public partial class SideBarDriveControl: UserControl
    {
        public SideBarDriveControl(string drive)
        {
            InitializeComponent();

            FileNameLabel.Text = "Drive " + drive;
            UpdateDiskSpace(drive);
        }

        private void UpdateDiskSpace(string drive)
        {
            try
            {
                DriveInfo cDrive = new DriveInfo(drive);

                if (cDrive.IsReady)
                {
                    long totalSize = cDrive.TotalSize;
                    long usedSpace = totalSize - cDrive.TotalFreeSpace;
                    SizeBar.Value = (int)Math.Round((double)usedSpace / totalSize * 100);

                    LabelSize.Text = $"{Helper.Helper.ConvertedSize(usedSpace)} / {Helper.Helper.ConvertedSize(totalSize)}";
                }
            }
            catch {}
        }
    }
}
