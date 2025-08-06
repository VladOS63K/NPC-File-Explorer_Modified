namespace NPC_File_Browser
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonSearch = new System.Windows.Forms.PictureBox();
            this.SearchTextbox = new NPC_File_Browser.Controls.ModernTextBox();
            this.PathTextbox = new NPC_File_Browser.Controls.ModernTextBox();
            this.ContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonReturn = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonBack = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonForward = new FontAwesome.Sharp.IconPictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonCopy = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonPaste = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonCut = new FontAwesome.Sharp.IconPictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonRefresh = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonStar = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonRename = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonDelete = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSearch)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonForward)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPaste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCut)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.SidebarPanel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 652);
            this.panel1.TabIndex = 0;
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.Location = new System.Drawing.Point(7, 29);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(236, 611);
            this.SidebarPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.ButtonSearch);
            this.panel2.Controls.Add(this.SearchTextbox);
            this.panel2.Controls.Add(this.PathTextbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 60);
            this.panel2.TabIndex = 1;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSearch.Image = global::NPC_File_Browser.Properties.Resources.go;
            this.ButtonSearch.Location = new System.Drawing.Point(1188, 18);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(24, 24);
            this.ButtonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.TabStop = false;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextbox.BackColor = System.Drawing.Color.Transparent;
            this.SearchTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SearchTextbox.BorderColor = System.Drawing.Color.Transparent;
            this.SearchTextbox.BorderRadius = 10;
            this.SearchTextbox.Location = new System.Drawing.Point(968, 12);
            this.SearchTextbox.Multiline = false;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.SearchTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.SearchTextbox.PlaceholderText = "Search";
            this.SearchTextbox.Size = new System.Drawing.Size(254, 36);
            this.SearchTextbox.TabIndex = 1;
            this.SearchTextbox.TextBoxText = "";
            this.SearchTextbox.TextColor = System.Drawing.Color.White;
            // 
            // PathTextbox
            // 
            this.PathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathTextbox.BackColor = System.Drawing.Color.Transparent;
            this.PathTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PathTextbox.BorderColor = System.Drawing.Color.Transparent;
            this.PathTextbox.BorderRadius = 10;
            this.PathTextbox.Location = new System.Drawing.Point(260, 12);
            this.PathTextbox.Multiline = false;
            this.PathTextbox.Name = "PathTextbox";
            this.PathTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.PathTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.PathTextbox.PlaceholderText = "Path";
            this.PathTextbox.Size = new System.Drawing.Size(702, 36);
            this.PathTextbox.TabIndex = 0;
            this.PathTextbox.TextBoxText = "";
            this.PathTextbox.TextColor = System.Drawing.Color.White;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ContentPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContentPanel.Location = new System.Drawing.Point(250, 100);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(983, 550);
            this.ContentPanel.TabIndex = 3;
            this.ContentPanel.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.ButtonReturn);
            this.flowLayoutPanel1.Controls.Add(this.ButtonBack);
            this.flowLayoutPanel1.Controls.Add(this.ButtonForward);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.ButtonCopy);
            this.flowLayoutPanel1.Controls.Add(this.ButtonPaste);
            this.flowLayoutPanel1.Controls.Add(this.ButtonCut);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.ButtonRefresh);
            this.flowLayoutPanel1.Controls.Add(this.ButtonStar);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.ButtonRename);
            this.flowLayoutPanel1.Controls.Add(this.ButtonDelete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(253, 63);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(980, 34);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonReturn.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.ButtonReturn.IconColor = System.Drawing.Color.White;
            this.ButtonReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonReturn.IconSize = 24;
            this.ButtonReturn.Location = new System.Drawing.Point(8, 5);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(24, 24);
            this.ButtonReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonReturn.TabIndex = 17;
            this.ButtonReturn.TabStop = false;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ButtonBack.IconColor = System.Drawing.Color.White;
            this.ButtonBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonBack.IconSize = 24;
            this.ButtonBack.Location = new System.Drawing.Point(38, 5);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(24, 24);
            this.ButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonBack.TabIndex = 18;
            this.ButtonBack.TabStop = false;
            // 
            // ButtonForward
            // 
            this.ButtonForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonForward.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.ButtonForward.IconColor = System.Drawing.Color.White;
            this.ButtonForward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonForward.IconSize = 24;
            this.ButtonForward.Location = new System.Drawing.Point(68, 5);
            this.ButtonForward.Name = "ButtonForward";
            this.ButtonForward.Size = new System.Drawing.Size(24, 24);
            this.ButtonForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonForward.TabIndex = 19;
            this.ButtonForward.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.iconPictureBox2);
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(98, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 28);
            this.panel7.TabIndex = 29;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(63, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 28);
            this.panel8.TabIndex = 13;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 23;
            this.iconPictureBox2.Location = new System.Drawing.Point(73, 0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(23, 28);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 12;
            this.iconPictureBox2.TabStop = false;
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonCopy.Enabled = false;
            this.ButtonCopy.ForeColor = System.Drawing.Color.Gray;
            this.ButtonCopy.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.ButtonCopy.IconColor = System.Drawing.Color.Gray;
            this.ButtonCopy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCopy.IconSize = 24;
            this.ButtonCopy.Location = new System.Drawing.Point(105, 5);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(24, 24);
            this.ButtonCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonCopy.TabIndex = 20;
            this.ButtonCopy.TabStop = false;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // ButtonPaste
            // 
            this.ButtonPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonPaste.ForeColor = System.Drawing.Color.Gray;
            this.ButtonPaste.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.ButtonPaste.IconColor = System.Drawing.Color.Gray;
            this.ButtonPaste.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonPaste.IconSize = 24;
            this.ButtonPaste.Location = new System.Drawing.Point(135, 5);
            this.ButtonPaste.Name = "ButtonPaste";
            this.ButtonPaste.Size = new System.Drawing.Size(24, 24);
            this.ButtonPaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonPaste.TabIndex = 21;
            this.ButtonPaste.TabStop = false;
            this.ButtonPaste.Click += new System.EventHandler(this.ButtonPaste_Click);
            // 
            // ButtonCut
            // 
            this.ButtonCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonCut.ForeColor = System.Drawing.Color.Gray;
            this.ButtonCut.IconChar = FontAwesome.Sharp.IconChar.Cut;
            this.ButtonCut.IconColor = System.Drawing.Color.Gray;
            this.ButtonCut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCut.IconSize = 24;
            this.ButtonCut.Location = new System.Drawing.Point(165, 5);
            this.ButtonCut.Name = "ButtonCut";
            this.ButtonCut.Size = new System.Drawing.Size(24, 24);
            this.ButtonCut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonCut.TabIndex = 24;
            this.ButtonCut.TabStop = false;
            this.ButtonCut.Click += new System.EventHandler(this.ButtonCut_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.iconPictureBox1);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(195, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 28);
            this.panel5.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(63, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 28);
            this.panel6.TabIndex = 13;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 23;
            this.iconPictureBox1.Location = new System.Drawing.Point(73, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(23, 28);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonRefresh.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.ButtonRefresh.IconColor = System.Drawing.Color.White;
            this.ButtonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonRefresh.IconSize = 24;
            this.ButtonRefresh.Location = new System.Drawing.Point(202, 5);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(24, 24);
            this.ButtonRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonRefresh.TabIndex = 28;
            this.ButtonRefresh.TabStop = false;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonStar
            // 
            this.ButtonStar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonStar.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.ButtonStar.IconColor = System.Drawing.Color.White;
            this.ButtonStar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.ButtonStar.IconSize = 24;
            this.ButtonStar.Location = new System.Drawing.Point(232, 5);
            this.ButtonStar.Name = "ButtonStar";
            this.ButtonStar.Size = new System.Drawing.Size(24, 24);
            this.ButtonStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonStar.TabIndex = 25;
            this.ButtonStar.TabStop = false;
            this.ButtonStar.Click += new System.EventHandler(this.ButtonStar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(262, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 28);
            this.panel4.TabIndex = 23;
            // 
            // ButtonRename
            // 
            this.ButtonRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonRename.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.ButtonRename.IconColor = System.Drawing.Color.White;
            this.ButtonRename.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonRename.IconSize = 24;
            this.ButtonRename.Location = new System.Drawing.Point(269, 5);
            this.ButtonRename.Name = "ButtonRename";
            this.ButtonRename.Size = new System.Drawing.Size(24, 24);
            this.ButtonRename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonRename.TabIndex = 26;
            this.ButtonRename.TabStop = false;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonDelete.ForeColor = System.Drawing.Color.Gray;
            this.ButtonDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDelete.IconColor = System.Drawing.Color.Gray;
            this.ButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDelete.IconSize = 24;
            this.ButtonDelete.Location = new System.Drawing.Point(299, 5);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(24, 24);
            this.ButtonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonDelete.TabIndex = 22;
            this.ButtonDelete.TabStop = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1234, 652);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1050, 191);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPC File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSearch)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonForward)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPaste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCut)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel ContentPanel;
        private System.Windows.Forms.FlowLayoutPanel SidebarPanel;
        private NPC_File_Browser.Controls.ModernTextBox PathTextbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox ButtonReturn;
        private FontAwesome.Sharp.IconPictureBox ButtonBack;
        private FontAwesome.Sharp.IconPictureBox ButtonForward;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox ButtonCopy;
        private FontAwesome.Sharp.IconPictureBox ButtonPaste;
        private FontAwesome.Sharp.IconPictureBox ButtonCut;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox ButtonRefresh;
        private FontAwesome.Sharp.IconPictureBox ButtonStar;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox ButtonRename;
        private FontAwesome.Sharp.IconPictureBox ButtonDelete;
        private Controls.ModernTextBox SearchTextbox;
        private System.Windows.Forms.PictureBox ButtonSearch;
    }
}

