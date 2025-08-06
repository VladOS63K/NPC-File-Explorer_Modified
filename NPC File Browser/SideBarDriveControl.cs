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
    public partial class SideBarDriveControl : UserControl
    {
        double pbUnit;
        int pbWIDTH, pbHEIGHT, pbComplete;
        Font lblSizeFont = new Font("Segoe UI", (float)8.25, FontStyle.Regular);
        Bitmap bmp;
        Graphics g;
        public SideBarDriveControl(string drive)
        {
            InitializeComponent();

            UpdateDiskSpace(drive); //New progress bar adapted from: dyclassroom.com/csharp-project/how-to-create-a-custom-progress-bar-in-csharp-using-visual-studio
        }
        private void UpdateDiskSpace(string drive)
        {
            try
            {
                pbWIDTH = pictureBox1.Width;
                pbHEIGHT = pictureBox1.Height;

                if (pbWIDTH <= 0 || pbHEIGHT <= 0)
                {
                    return;
                }

                pbUnit = pbWIDTH / 100.0;
                pbComplete = 0;

                DriveInfo cDrive = new DriveInfo(drive);

                switch(cDrive.DriveType)
                {
                    case DriveType.Fixed:
                        Icon.IconChar = FontAwesome.Sharp.IconChar.Hdd; break;
                    case DriveType.Removable:
                        Icon.IconChar = FontAwesome.Sharp.IconChar.Usb; break;
                    case DriveType.CDRom:
                        Icon.IconChar = FontAwesome.Sharp.IconChar.CompactDisc; break;
                    case DriveType.Network:
                        Icon.IconChar = FontAwesome.Sharp.IconChar.NetworkWired; break;
                    case DriveType.Unknown:
                        Icon.IconChar = FontAwesome.Sharp.IconChar.Question; break;
                }
                
                if (cDrive.IsReady)
                {
                    FileNameLabel.Text = $"{(String.IsNullOrEmpty(cDrive.VolumeLabel) ? "Drive" : cDrive.VolumeLabel)} (" + drive + ")";
                    long totalSize = cDrive.TotalSize;
                    long usedSpace = totalSize - cDrive.TotalFreeSpace;
                    string text = $"{Helper.Helper.ConvertedSize(usedSpace)} / {Helper.Helper.ConvertedSize(totalSize)}";
                    UpdateProgressBar((int)Math.Round((double)usedSpace / totalSize * 100),text);
                }
                else
                {
                    FileNameLabel.Text = $"Drive (" + drive + " not ready)";
                }
            }
            catch { }
        }
        private void UpdateProgressBar(int percentage, string text)
        {
            if (bmp != null)
                bmp.Dispose();

            bmp = new Bitmap(pbWIDTH, pbHEIGHT);
            Size txtSize = TextRenderer.MeasureText(text, lblSizeFont);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(40, 40, 40));
                g.FillRectangle(Brushes.DimGray, new Rectangle(0, 0, (int)(percentage * pbUnit), pbHEIGHT));
                g.DrawString(text, lblSizeFont, Brushes.White, new PointF((pbWIDTH - 5 - txtSize.Width), (pbHEIGHT / 2) - (txtSize.Height / 2)));
            }

            pictureBox1.Image = bmp;
        }
    }
}