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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchTextbox = new NPC_File_Browser.Controls.ModernTextBox();
            this.PathTextbox = new NPC_File_Browser.Controls.ModernTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonCopy = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonPaste = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonCut = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonStar = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonRename = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonDelete = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonAbout = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonBug = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonReturn = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonBack = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonForward = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonRefresh = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonSearch = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPaste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.SidebarPanel);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 593);
            this.panel1.TabIndex = 0;
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.Location = new System.Drawing.Point(7, 4);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(236, 636);
            this.SidebarPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.ButtonSearch);
            this.panel2.Controls.Add(this.SearchTextbox);
            this.panel2.Controls.Add(this.PathTextbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 60);
            this.panel2.TabIndex = 1;
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
            this.flowLayoutPanel1.Controls.Add(this.ButtonCopy);
            this.flowLayoutPanel1.Controls.Add(this.ButtonPaste);
            this.flowLayoutPanel1.Controls.Add(this.ButtonCut);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.ButtonStar);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.ButtonRename);
            this.flowLayoutPanel1.Controls.Add(this.ButtonDelete);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.ButtonAbout);
            this.flowLayoutPanel1.Controls.Add(this.ButtonBug);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(253, 63);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(980, 34);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.iconPictureBox1);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(98, 5);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(135, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 28);
            this.panel4.TabIndex = 23;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ButtonReturn);
            this.flowLayoutPanel2.Controls.Add(this.ButtonBack);
            this.flowLayoutPanel2.Controls.Add(this.ButtonForward);
            this.flowLayoutPanel2.Controls.Add(this.ButtonRefresh);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(243, 34);
            this.flowLayoutPanel2.TabIndex = 3;
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
            this.PathTextbox.Location = new System.Drawing.Point(253, 12);
            this.PathTextbox.Multiline = false;
            this.PathTextbox.Name = "PathTextbox";
            this.PathTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.PathTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.PathTextbox.PlaceholderText = "Path";
            this.PathTextbox.Size = new System.Drawing.Size(709, 36);
            this.PathTextbox.TabIndex = 0;
            this.PathTextbox.TextBoxText = "";
            this.PathTextbox.TextColor = System.Drawing.Color.White;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(202, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 28);
            this.panel3.TabIndex = 24;
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
            this.ButtonCopy.Location = new System.Drawing.Point(8, 5);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(24, 24);
            this.ButtonCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonCopy.TabIndex = 20;
            this.ButtonCopy.TabStop = false;
            this.toolTip1.SetToolTip(this.ButtonCopy, "Copy");
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
            this.ButtonPaste.Location = new System.Drawing.Point(38, 5);
            this.ButtonPaste.Name = "ButtonPaste";
            this.ButtonPaste.Size = new System.Drawing.Size(24, 24);
            this.ButtonPaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonPaste.TabIndex = 21;
            this.ButtonPaste.TabStop = false;
            this.toolTip1.SetToolTip(this.ButtonPaste, "Paste");
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
            this.ButtonCut.Location = new System.Drawing.Point(68, 5);
            this.ButtonCut.Name = "ButtonCut";
            this.ButtonCut.Size = new System.Drawing.Size(24, 24);
            this.ButtonCut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonCut.TabIndex = 24;
            this.ButtonCut.TabStop = false;
            this.toolTip1.SetToolTip(this.ButtonCut, "Cut");
            this.ButtonCut.Click += new System.EventHandler(this.ButtonCut_Click);
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
            // ButtonStar
            // 
            this.ButtonStar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonStar.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.ButtonStar.IconColor = System.Drawing.Color.White;
            this.ButtonStar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.ButtonStar.IconSize = 24;
            this.ButtonStar.Location = new System.Drawing.Point(105, 5);
            this.ButtonStar.Name = "ButtonStar";
            this.ButtonStar.Size = new System.Drawing.Size(24, 24);
            this.ButtonStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonStar.TabIndex = 25;
            this.ButtonStar.TabStop = false;
            this.toolTip1.SetToolTip(this.ButtonStar, "Pin");
            this.ButtonStar.Click += new System.EventHandler(this.ButtonStar_Click);
            // 
            // ButtonRename
            // 
            this.ButtonRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonRename.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.ButtonRename.IconColor = System.Drawing.Color.White;
            this.ButtonRename.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonRename.IconSize = 24;
            this.ButtonRename.Location = new System.Drawing.Point(142, 5);
            this.ButtonRename.Name = "ButtonRename";
            this.ButtonRename.Size = new System.Drawing.Size(24, 24);
            this.ButtonRename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonRename.TabIndex = 26;
            this.ButtonRename.TabStop = false;
            this.toolTip1.SetToolTip(this.ButtonRename, "Rename");
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonDelete.ForeColor = System.Drawing.Color.Gray;
            this.ButtonDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDelete.IconColor = System.Drawing.Color.Gray;
            this.ButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDelete.IconSize = 24;
            this.ButtonDelete.Location = new System.Drawing.Point(172, 5);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(24, 24);
            this.ButtonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonDelete.TabIndex = 22;
            this.ButtonDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.ButtonDelete, "Delete");
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonAbout.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.ButtonAbout.IconColor = System.Drawing.Color.White;
            this.ButtonAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAbout.IconSize = 24;
            this.ButtonAbout.Location = new System.Drawing.Point(209, 5);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(24, 24);
            this.ButtonAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAbout.TabIndex = 28;
            this.ButtonAbout.TabStop = false;
            this.toolTip1.SetToolTip(this.ButtonAbout, "About");
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // ButtonBug
            // 
            this.ButtonBug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonBug.IconChar = FontAwesome.Sharp.IconChar.Bug;
            this.ButtonBug.IconColor = System.Drawing.Color.White;
            this.ButtonBug.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonBug.IconSize = 24;
            this.ButtonBug.Location = new System.Drawing.Point(239, 5);
            this.ButtonBug.Name = "ButtonBug";
            this.ButtonBug.Size = new System.Drawing.Size(24, 24);
            this.ButtonBug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonBug.TabIndex = 29;
            this.ButtonBug.TabStop = false;
            this.toolTip1.SetToolTip(this.ButtonBug, "Report A Bug");
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonReturn.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.ButtonReturn.IconColor = System.Drawing.Color.White;
            this.ButtonReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonReturn.IconSize = 24;
            this.ButtonReturn.Location = new System.Drawing.Point(8, 5);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Rotation = 90D;
            this.ButtonReturn.Size = new System.Drawing.Size(24, 24);
            this.ButtonReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonReturn.TabIndex = 17;
            this.ButtonReturn.TabStop = false;
            this.toolTip1.SetToolTip(this.ButtonReturn, "Return");
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
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
            this.toolTip1.SetToolTip(this.ButtonBack, "Back");
            // 
            // ButtonForward
            // 
            this.ButtonForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
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
            this.toolTip1.SetToolTip(this.ButtonForward, "Forward");
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonRefresh.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.ButtonRefresh.IconColor = System.Drawing.Color.White;
            this.ButtonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonRefresh.IconSize = 24;
            this.ButtonRefresh.Location = new System.Drawing.Point(98, 5);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(24, 24);
            this.ButtonRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonRefresh.TabIndex = 28;
            this.ButtonRefresh.TabStop = false;
            this.toolTip1.SetToolTip(this.ButtonRefresh, "Refresh");
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSearch.Image = global::NPC_File_Browser.Properties.Resources.go;
            this.ButtonSearch.Location = new System.Drawing.Point(1188, 18);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(24, 24);
            this.ButtonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.TabStop = false;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1050, 191);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPC File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPaste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSearch)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox ButtonAbout;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconPictureBox ButtonBug;
    }
}

