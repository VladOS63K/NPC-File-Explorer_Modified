using System.Windows.Forms;

namespace NPC_File_Browser
{
    partial class FileControl
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
            this.components = new System.ComponentModel.Container();
            this.Icon = new FontAwesome.Sharp.IconPictureBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileExtensionLabel = new System.Windows.Forms.Label();
            this.FileSizeLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jkhfewjkfwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Icon
            // 
            this.Icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Icon.BackColor = System.Drawing.Color.Transparent;
            this.Icon.IconChar = FontAwesome.Sharp.IconChar.File;
            this.Icon.IconColor = System.Drawing.Color.White;
            this.Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon.Location = new System.Drawing.Point(0, 1);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(24, 24);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon.TabIndex = 0;
            this.Icon.TabStop = false;
            this.Icon.Click += new System.EventHandler(this.FileControl_Click);
            this.Icon.DoubleClick += new System.EventHandler(this.FileControl_DoubleClick);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameLabel.ForeColor = System.Drawing.Color.White;
            this.FileNameLabel.Location = new System.Drawing.Point(35, 4);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(260, 17);
            this.FileNameLabel.TabIndex = 1;
            this.FileNameLabel.Text = "File Name";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileNameLabel.Click += new System.EventHandler(this.FileControl_Click);
            this.FileNameLabel.DoubleClick += new System.EventHandler(this.FileControl_DoubleClick);
            // 
            // FileExtensionLabel
            // 
            this.FileExtensionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileExtensionLabel.ForeColor = System.Drawing.Color.White;
            this.FileExtensionLabel.Location = new System.Drawing.Point(301, 4);
            this.FileExtensionLabel.Name = "FileExtensionLabel";
            this.FileExtensionLabel.Size = new System.Drawing.Size(203, 17);
            this.FileExtensionLabel.TabIndex = 2;
            this.FileExtensionLabel.Text = "Extension";
            this.FileExtensionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileExtensionLabel.Click += new System.EventHandler(this.FileControl_Click);
            this.FileExtensionLabel.DoubleClick += new System.EventHandler(this.FileControl_DoubleClick);
            // 
            // FileSizeLabel
            // 
            this.FileSizeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileSizeLabel.ForeColor = System.Drawing.Color.White;
            this.FileSizeLabel.Location = new System.Drawing.Point(510, 4);
            this.FileSizeLabel.Name = "FileSizeLabel";
            this.FileSizeLabel.Size = new System.Drawing.Size(97, 17);
            this.FileSizeLabel.TabIndex = 3;
            this.FileSizeLabel.Text = "Size";
            this.FileSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileSizeLabel.Click += new System.EventHandler(this.FileControl_Click);
            this.FileSizeLabel.DoubleClick += new System.EventHandler(this.FileControl_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jkhfewjkfwToolStripMenuItem,
            this.iconMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 48);
            // 
            // jkhfewjkfwToolStripMenuItem
            // 
            this.jkhfewjkfwToolStripMenuItem.Name = "jkhfewjkfwToolStripMenuItem";
            this.jkhfewjkfwToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.jkhfewjkfwToolStripMenuItem.Text = "jkhfewjkfw";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.NfcSymbol;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // FileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.FileSizeLabel);
            this.Controls.Add(this.FileExtensionLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.Icon);
            this.Name = "FileControl";
            this.Size = new System.Drawing.Size(983, 25);
            this.Click += new System.EventHandler(this.FileControl_Click);
            this.DoubleClick += new System.EventHandler(this.FileControl_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox Icon;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileExtensionLabel;
        private System.Windows.Forms.Label FileSizeLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem jkhfewjkfwToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}
