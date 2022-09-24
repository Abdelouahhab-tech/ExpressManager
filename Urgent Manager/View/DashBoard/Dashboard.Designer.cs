namespace Urgent_Manager.View.DashBoard
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.NavBar = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArchiveManager = new FontAwesome.Sharp.IconButton();
            this.btnUrgentManager = new FontAwesome.Sharp.IconButton();
            this.btnStatistics = new FontAwesome.Sharp.IconButton();
            this.btnCredentials = new FontAwesome.Sharp.IconButton();
            this.panelControls = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnMarker = new FontAwesome.Sharp.IconButton();
            this.btnGroup = new FontAwesome.Sharp.IconButton();
            this.btnProtection = new FontAwesome.Sharp.IconButton();
            this.btnSeal = new FontAwesome.Sharp.IconButton();
            this.btnMachine = new FontAwesome.Sharp.IconButton();
            this.btnTerminal = new FontAwesome.Sharp.IconButton();
            this.btnOutil = new FontAwesome.Sharp.IconButton();
            this.btnBobine = new FontAwesome.Sharp.IconButton();
            this.btnFamille = new FontAwesome.Sharp.IconButton();
            this.btnArea = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.icUrgent = new FontAwesome.Sharp.IconButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.AutoScroll = true;
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.NavBar.Controls.Add(this.guna2ControlBox3);
            this.NavBar.Controls.Add(this.lblUser);
            this.NavBar.Controls.Add(this.lblDate);
            this.NavBar.Controls.Add(this.guna2ControlBox2);
            this.NavBar.Controls.Add(this.pictureBox1);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1253, 47);
            this.NavBar.TabIndex = 1;
            this.NavBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDoubleClick);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1166, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(41, 47);
            this.guna2ControlBox3.TabIndex = 10;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(765, 14);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 19);
            this.lblUser.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(479, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 19);
            this.lblDate.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1211, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(41, 47);
            this.guna2ControlBox2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Urgent_Manager.Properties.Resources.aptiveDark;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.sideBar.Controls.Add(this.label1);
            this.sideBar.Controls.Add(this.btnArchiveManager);
            this.sideBar.Controls.Add(this.btnUrgentManager);
            this.sideBar.Controls.Add(this.btnStatistics);
            this.sideBar.Controls.Add(this.btnCredentials);
            this.sideBar.Controls.Add(this.panelControls);
            this.sideBar.Controls.Add(this.btnLogout);
            this.sideBar.Controls.Add(this.icUrgent);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 47);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(204, 683);
            this.sideBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "DashBoard";
            // 
            // btnArchiveManager
            // 
            this.btnArchiveManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchiveManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnArchiveManager.FlatAppearance.BorderSize = 0;
            this.btnArchiveManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(120)))));
            this.btnArchiveManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.btnArchiveManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveManager.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveManager.ForeColor = System.Drawing.Color.White;
            this.btnArchiveManager.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnArchiveManager.IconColor = System.Drawing.Color.White;
            this.btnArchiveManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArchiveManager.IconSize = 35;
            this.btnArchiveManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchiveManager.Location = new System.Drawing.Point(0, 537);
            this.btnArchiveManager.Name = "btnArchiveManager";
            this.btnArchiveManager.Size = new System.Drawing.Size(204, 38);
            this.btnArchiveManager.TabIndex = 7;
            this.btnArchiveManager.Text = "    Archive Manager";
            this.btnArchiveManager.UseVisualStyleBackColor = true;
            this.btnArchiveManager.Click += new System.EventHandler(this.btnArchiveManager_Click);
            // 
            // btnUrgentManager
            // 
            this.btnUrgentManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrgentManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnUrgentManager.FlatAppearance.BorderSize = 0;
            this.btnUrgentManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(120)))));
            this.btnUrgentManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.btnUrgentManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrgentManager.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrgentManager.ForeColor = System.Drawing.Color.White;
            this.btnUrgentManager.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.btnUrgentManager.IconColor = System.Drawing.Color.White;
            this.btnUrgentManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUrgentManager.IconSize = 35;
            this.btnUrgentManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrgentManager.Location = new System.Drawing.Point(0, 499);
            this.btnUrgentManager.Name = "btnUrgentManager";
            this.btnUrgentManager.Size = new System.Drawing.Size(204, 38);
            this.btnUrgentManager.TabIndex = 6;
            this.btnUrgentManager.Text = "    Urgent Manager";
            this.btnUrgentManager.UseVisualStyleBackColor = true;
            this.btnUrgentManager.Click += new System.EventHandler(this.btnUrgentManager_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(120)))));
            this.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnStatistics.IconColor = System.Drawing.Color.White;
            this.btnStatistics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatistics.IconSize = 35;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(0, 461);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(204, 38);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.Text = "    Urgent Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnCredentials
            // 
            this.btnCredentials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCredentials.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnCredentials.FlatAppearance.BorderSize = 0;
            this.btnCredentials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(120)))));
            this.btnCredentials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.btnCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredentials.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredentials.ForeColor = System.Drawing.Color.White;
            this.btnCredentials.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnCredentials.IconColor = System.Drawing.Color.White;
            this.btnCredentials.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCredentials.IconSize = 35;
            this.btnCredentials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredentials.Location = new System.Drawing.Point(0, 423);
            this.btnCredentials.Name = "btnCredentials";
            this.btnCredentials.Size = new System.Drawing.Size(204, 38);
            this.btnCredentials.TabIndex = 4;
            this.btnCredentials.Text = "    User\'s Credentials";
            this.btnCredentials.UseVisualStyleBackColor = true;
            this.btnCredentials.Click += new System.EventHandler(this.btnCredentials_Click);
            // 
            // panelControls
            // 
            this.panelControls.AutoScroll = true;
            this.panelControls.Controls.Add(this.iconButton1);
            this.panelControls.Controls.Add(this.iconButton2);
            this.panelControls.Controls.Add(this.btnMarker);
            this.panelControls.Controls.Add(this.btnGroup);
            this.panelControls.Controls.Add(this.btnProtection);
            this.panelControls.Controls.Add(this.btnSeal);
            this.panelControls.Controls.Add(this.btnMachine);
            this.panelControls.Controls.Add(this.btnTerminal);
            this.panelControls.Controls.Add(this.btnOutil);
            this.panelControls.Controls.Add(this.btnBobine);
            this.panelControls.Controls.Add(this.btnFamille);
            this.panelControls.Controls.Add(this.btnArea);
            this.panelControls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelControls.Location = new System.Drawing.Point(0, 106);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(204, 300);
            this.panelControls.TabIndex = 3;
            this.panelControls.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 418);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(187, 38);
            this.iconButton1.TabIndex = 23;
            this.iconButton1.Text = "  Wire List";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 380);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(187, 38);
            this.iconButton2.TabIndex = 22;
            this.iconButton2.Text = "          Add New Wire";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnMarker
            // 
            this.btnMarker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMarker.FlatAppearance.BorderSize = 0;
            this.btnMarker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnMarker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.btnMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarker.ForeColor = System.Drawing.Color.White;
            this.btnMarker.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnMarker.IconColor = System.Drawing.Color.White;
            this.btnMarker.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMarker.IconSize = 35;
            this.btnMarker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarker.Location = new System.Drawing.Point(0, 342);
            this.btnMarker.Name = "btnMarker";
            this.btnMarker.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMarker.Size = new System.Drawing.Size(187, 38);
            this.btnMarker.TabIndex = 21;
            this.btnMarker.Text = "          Add New Marker";
            this.btnMarker.UseVisualStyleBackColor = true;
            this.btnMarker.Click += new System.EventHandler(this.btnMarker_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.ForeColor = System.Drawing.Color.White;
            this.btnGroup.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnGroup.IconColor = System.Drawing.Color.White;
            this.btnGroup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGroup.IconSize = 35;
            this.btnGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroup.Location = new System.Drawing.Point(0, 304);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGroup.Size = new System.Drawing.Size(187, 38);
            this.btnGroup.TabIndex = 20;
            this.btnGroup.Text = "          Add New Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnProtection
            // 
            this.btnProtection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProtection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProtection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnProtection.FlatAppearance.BorderSize = 0;
            this.btnProtection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnProtection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.btnProtection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProtection.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProtection.ForeColor = System.Drawing.Color.White;
            this.btnProtection.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnProtection.IconColor = System.Drawing.Color.White;
            this.btnProtection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProtection.IconSize = 35;
            this.btnProtection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProtection.Location = new System.Drawing.Point(0, 266);
            this.btnProtection.Name = "btnProtection";
            this.btnProtection.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProtection.Size = new System.Drawing.Size(187, 38);
            this.btnProtection.TabIndex = 19;
            this.btnProtection.Text = "        Add New Protection";
            this.btnProtection.UseVisualStyleBackColor = true;
            this.btnProtection.Click += new System.EventHandler(this.btnProtection_Click);
            // 
            // btnSeal
            // 
            this.btnSeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnSeal.FlatAppearance.BorderSize = 0;
            this.btnSeal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnSeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.btnSeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeal.ForeColor = System.Drawing.Color.White;
            this.btnSeal.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnSeal.IconColor = System.Drawing.Color.White;
            this.btnSeal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeal.IconSize = 35;
            this.btnSeal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeal.Location = new System.Drawing.Point(0, 228);
            this.btnSeal.Name = "btnSeal";
            this.btnSeal.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSeal.Size = new System.Drawing.Size(187, 38);
            this.btnSeal.TabIndex = 18;
            this.btnSeal.Text = "    Add New Seal";
            this.btnSeal.UseVisualStyleBackColor = true;
            this.btnSeal.Click += new System.EventHandler(this.btnSeal_Click);
            // 
            // btnMachine
            // 
            this.btnMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMachine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMachine.FlatAppearance.BorderSize = 0;
            this.btnMachine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnMachine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.btnMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachine.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachine.ForeColor = System.Drawing.Color.White;
            this.btnMachine.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnMachine.IconColor = System.Drawing.Color.White;
            this.btnMachine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMachine.IconSize = 35;
            this.btnMachine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMachine.Location = new System.Drawing.Point(0, 190);
            this.btnMachine.Name = "btnMachine";
            this.btnMachine.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMachine.Size = new System.Drawing.Size(187, 38);
            this.btnMachine.TabIndex = 17;
            this.btnMachine.Text = "    Add New Machine";
            this.btnMachine.UseVisualStyleBackColor = true;
            this.btnMachine.Click += new System.EventHandler(this.btnMachine_Click);
            // 
            // btnTerminal
            // 
            this.btnTerminal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerminal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTerminal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnTerminal.FlatAppearance.BorderSize = 0;
            this.btnTerminal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnTerminal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.btnTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminal.ForeColor = System.Drawing.Color.White;
            this.btnTerminal.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnTerminal.IconColor = System.Drawing.Color.White;
            this.btnTerminal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTerminal.IconSize = 35;
            this.btnTerminal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminal.Location = new System.Drawing.Point(0, 152);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTerminal.Size = new System.Drawing.Size(187, 38);
            this.btnTerminal.TabIndex = 15;
            this.btnTerminal.Text = "        Add New Terminal";
            this.btnTerminal.UseVisualStyleBackColor = true;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // btnOutil
            // 
            this.btnOutil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOutil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnOutil.FlatAppearance.BorderSize = 0;
            this.btnOutil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnOutil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.btnOutil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutil.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutil.ForeColor = System.Drawing.Color.White;
            this.btnOutil.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnOutil.IconColor = System.Drawing.Color.White;
            this.btnOutil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOutil.IconSize = 35;
            this.btnOutil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutil.Location = new System.Drawing.Point(0, 114);
            this.btnOutil.Name = "btnOutil";
            this.btnOutil.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOutil.Size = new System.Drawing.Size(187, 38);
            this.btnOutil.TabIndex = 14;
            this.btnOutil.Text = "    Add New Tool";
            this.btnOutil.UseVisualStyleBackColor = true;
            this.btnOutil.Click += new System.EventHandler(this.btnOutil_Click);
            // 
            // btnBobine
            // 
            this.btnBobine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBobine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBobine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnBobine.FlatAppearance.BorderSize = 0;
            this.btnBobine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnBobine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.btnBobine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBobine.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBobine.ForeColor = System.Drawing.Color.White;
            this.btnBobine.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnBobine.IconColor = System.Drawing.Color.White;
            this.btnBobine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBobine.IconSize = 35;
            this.btnBobine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBobine.Location = new System.Drawing.Point(0, 76);
            this.btnBobine.Name = "btnBobine";
            this.btnBobine.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBobine.Size = new System.Drawing.Size(187, 38);
            this.btnBobine.TabIndex = 13;
            this.btnBobine.Text = "    Add New Cable";
            this.btnBobine.UseVisualStyleBackColor = true;
            this.btnBobine.Click += new System.EventHandler(this.btnBobine_Click);
            // 
            // btnFamille
            // 
            this.btnFamille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamille.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFamille.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnFamille.FlatAppearance.BorderSize = 0;
            this.btnFamille.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnFamille.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.btnFamille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamille.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamille.ForeColor = System.Drawing.Color.White;
            this.btnFamille.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnFamille.IconColor = System.Drawing.Color.White;
            this.btnFamille.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFamille.IconSize = 35;
            this.btnFamille.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFamille.Location = new System.Drawing.Point(0, 38);
            this.btnFamille.Name = "btnFamille";
            this.btnFamille.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFamille.Size = new System.Drawing.Size(187, 38);
            this.btnFamille.TabIndex = 12;
            this.btnFamille.Text = "    Add New Family";
            this.btnFamille.UseVisualStyleBackColor = true;
            this.btnFamille.Click += new System.EventHandler(this.btnFamille_Click);
            // 
            // btnArea
            // 
            this.btnArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArea.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnArea.FlatAppearance.BorderSize = 0;
            this.btnArea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(12)))));
            this.btnArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArea.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.ForeColor = System.Drawing.Color.White;
            this.btnArea.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnArea.IconColor = System.Drawing.Color.White;
            this.btnArea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArea.IconSize = 35;
            this.btnArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArea.Location = new System.Drawing.Point(0, 0);
            this.btnArea.Name = "btnArea";
            this.btnArea.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnArea.Size = new System.Drawing.Size(187, 38);
            this.btnArea.TabIndex = 11;
            this.btnArea.Text = " Add New Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.btnLogout.Image = global::Urgent_Manager.Properties.Resources.turn_off;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogout.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnLogout.Location = new System.Drawing.Point(0, 645);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(120)))));
            this.btnLogout.Size = new System.Drawing.Size(204, 38);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextOffset = new System.Drawing.Point(10, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // icUrgent
            // 
            this.icUrgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.icUrgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icUrgent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.icUrgent.FlatAppearance.BorderSize = 0;
            this.icUrgent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(120)))));
            this.icUrgent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.icUrgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icUrgent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icUrgent.ForeColor = System.Drawing.Color.White;
            this.icUrgent.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.icUrgent.IconColor = System.Drawing.Color.White;
            this.icUrgent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icUrgent.IconSize = 35;
            this.icUrgent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icUrgent.Location = new System.Drawing.Point(0, 64);
            this.icUrgent.Name = "icUrgent";
            this.icUrgent.Size = new System.Drawing.Size(204, 38);
            this.icUrgent.TabIndex = 0;
            this.icUrgent.Text = "    Data Management\r\n";
            this.icUrgent.UseVisualStyleBackColor = false;
            this.icUrgent.Click += new System.EventHandler(this.icUrgent_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(204, 47);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1049, 683);
            this.mainPanel.TabIndex = 3;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.NavBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1253, 730);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sideBar;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private FontAwesome.Sharp.IconButton icUrgent;
        private System.Windows.Forms.Panel panelControls;
        private FontAwesome.Sharp.IconButton btnTerminal;
        private FontAwesome.Sharp.IconButton btnOutil;
        private FontAwesome.Sharp.IconButton btnBobine;
        private FontAwesome.Sharp.IconButton btnFamille;
        private FontAwesome.Sharp.IconButton btnArea;
        private FontAwesome.Sharp.IconButton btnMachine;
        private FontAwesome.Sharp.IconButton btnCredentials;
        private FontAwesome.Sharp.IconButton btnGroup;
        private FontAwesome.Sharp.IconButton btnProtection;
        private FontAwesome.Sharp.IconButton btnSeal;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnMarker;
        private FontAwesome.Sharp.IconButton btnStatistics;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel mainPanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnArchiveManager;
        private FontAwesome.Sharp.IconButton btnUrgentManager;
        private System.Windows.Forms.Label label1;
    }
}