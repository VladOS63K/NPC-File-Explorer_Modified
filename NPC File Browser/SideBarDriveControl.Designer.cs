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
            this.Icon = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Icon
            // 
            this.Icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Icon.BackColor = System.Drawing.Color.Transparent;
            this.Icon.IconChar = FontAwesome.Sharp.IconChar.Hdd;
            this.Icon.IconColor = System.Drawing.Color.White;
            this.Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon.Location = new System.Drawing.Point(4, 2);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(24, 24);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon.TabIndex = 4;
            this.Icon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 17);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameLabel.ForeColor = System.Drawing.Color.White;
            this.FileNameLabel.Location = new System.Drawing.Point(36, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.FileNameLabel.Size = new System.Drawing.Size(112, 21);
            this.FileNameLabel.TabIndex = 9;
            this.FileNameLabel.Text = "Drive C:";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SideBarDriveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SideBarDriveControl";
            this.Size = new System.Drawing.Size(236, 50);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox Icon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FileNameLabel;
    }
}
