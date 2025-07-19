namespace NPC_File_Browser
{
    partial class SideBarDriveControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.Icon = new FontAwesome.Sharp.IconPictureBox();
            this.SizeBar = new System.Windows.Forms.ProgressBar();
            this.LabelSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameLabel.ForeColor = System.Drawing.Color.White;
            this.FileNameLabel.Location = new System.Drawing.Point(35, 4);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(57, 17);
            this.FileNameLabel.TabIndex = 5;
            this.FileNameLabel.Text = "Drive C:";
            // 
            // Icon
            // 
            this.Icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Icon.BackColor = System.Drawing.Color.Transparent;
            this.Icon.IconChar = FontAwesome.Sharp.IconChar.Hdd;
            this.Icon.IconColor = System.Drawing.Color.White;
            this.Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon.IconSize = 23;
            this.Icon.Location = new System.Drawing.Point(0, 1);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(30, 23);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon.TabIndex = 4;
            this.Icon.TabStop = false;
            // 
            // SizeBar
            // 
            this.SizeBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SizeBar.Location = new System.Drawing.Point(6, 28);
            this.SizeBar.Name = "SizeBar";
            this.SizeBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeBar.Size = new System.Drawing.Size(224, 16);
            this.SizeBar.TabIndex = 6;
            this.SizeBar.Value = 10;
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSize.ForeColor = System.Drawing.Color.White;
            this.LabelSize.Location = new System.Drawing.Point(175, 0);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.LabelSize.Size = new System.Drawing.Size(61, 21);
            this.LabelSize.TabIndex = 7;
            this.LabelSize.Text = "Drive C:";
            // 
            // SideBarDriveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LabelSize);
            this.Controls.Add(this.SizeBar);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.Icon);
            this.Name = "SideBarDriveControl";
            this.Size = new System.Drawing.Size(236, 50);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileNameLabel;
        private FontAwesome.Sharp.IconPictureBox Icon;
        private System.Windows.Forms.ProgressBar SizeBar;
        private System.Windows.Forms.Label LabelSize;
    }
}
