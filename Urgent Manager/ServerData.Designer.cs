namespace Urgent_Manager
{
    partial class ServerData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerData));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chIsConnectPerMC = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cmbDirectories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gtxtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.icEyes = new FontAwesome.Sharp.IconPictureBox();
            this.gtxtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtDbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtServerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConnect = new Guna.UI2.WinForms.Guna2Button();
            this.gtxtUserAuth = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtPassAuth = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chIsConnect = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.gtxtUserConnect = new Guna.UI2.WinForms.Guna2TextBox();
            this.icEyeNewPass = new FontAwesome.Sharp.IconPictureBox();
            this.gtxtUserPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSaveData = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icEyes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icEyeNewPass)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(522, 624);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabPage1.Controls.Add(this.chIsConnectPerMC);
            this.tabPage1.Controls.Add(this.cmbDirectories);
            this.tabPage1.Controls.Add(this.guna2ControlBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.gtxtUser);
            this.tabPage1.Controls.Add(this.icEyes);
            this.tabPage1.Controls.Add(this.gtxtPass);
            this.tabPage1.Controls.Add(this.gtxtDbName);
            this.tabPage1.Controls.Add(this.gtxtServerName);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(514, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server Data";
            // 
            // chIsConnectPerMC
            // 
            this.chIsConnectPerMC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.chIsConnectPerMC.CheckedState.BorderRadius = 2;
            this.chIsConnectPerMC.CheckedState.BorderThickness = 0;
            this.chIsConnectPerMC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chIsConnectPerMC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chIsConnectPerMC.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chIsConnectPerMC.ForeColor = System.Drawing.Color.White;
            this.chIsConnectPerMC.Location = new System.Drawing.Point(37, 418);
            this.chIsConnectPerMC.Name = "chIsConnectPerMC";
            this.chIsConnectPerMC.Size = new System.Drawing.Size(130, 24);
            this.chIsConnectPerMC.TabIndex = 13;
            this.chIsConnectPerMC.Text = "Is Connect";
            this.chIsConnectPerMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chIsConnectPerMC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chIsConnectPerMC.UncheckedState.BorderRadius = 2;
            this.chIsConnectPerMC.UncheckedState.BorderThickness = 0;
            this.chIsConnectPerMC.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cmbDirectories
            // 
            this.cmbDirectories.BackColor = System.Drawing.Color.Transparent;
            this.cmbDirectories.BorderColor = System.Drawing.Color.White;
            this.cmbDirectories.BorderRadius = 20;
            this.cmbDirectories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDirectories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDirectories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirectories.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbDirectories.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbDirectories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbDirectories.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbDirectories.ForeColor = System.Drawing.Color.White;
            this.cmbDirectories.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbDirectories.IntegralHeight = false;
            this.cmbDirectories.ItemHeight = 35;
            this.cmbDirectories.Items.AddRange(new object[] {
            "D:\\Komax\\TopWin\\WPCS-Feedback\\Job.sdc.arc",
            "D:\\Komax\\Data\\WPCS-Feedback\\Job.sdc.arc"});
            this.cmbDirectories.Location = new System.Drawing.Point(37, 356);
            this.cmbDirectories.Name = "cmbDirectories";
            this.cmbDirectories.Size = new System.Drawing.Size(416, 41);
            this.cmbDirectories.TabIndex = 4;
            this.cmbDirectories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbDirectories.SelectedIndexChanged += new System.EventHandler(this.cmbDirectories_SelectedIndexChanged);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(469, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 27);
            this.guna2ControlBox1.TabIndex = 12;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Server Data";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 20;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Urgent_Manager.Properties.Resources.check;
            this.btnSave.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.IndicateFocus = true;
            this.btnSave.Location = new System.Drawing.Point(37, 459);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(416, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gtxtUser
            // 
            this.gtxtUser.BorderColor = System.Drawing.Color.White;
            this.gtxtUser.BorderRadius = 20;
            this.gtxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtUser.DefaultText = "";
            this.gtxtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gtxtUser.ForeColor = System.Drawing.Color.White;
            this.gtxtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUser.IconLeft = global::Urgent_Manager.Properties.Resources.user;
            this.gtxtUser.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.gtxtUser.IconLeftSize = new System.Drawing.Size(25, 25);
            this.gtxtUser.Location = new System.Drawing.Point(37, 227);
            this.gtxtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtUser.Name = "gtxtUser";
            this.gtxtUser.PasswordChar = '\0';
            this.gtxtUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtUser.PlaceholderText = "User Name";
            this.gtxtUser.SelectedText = "";
            this.gtxtUser.Size = new System.Drawing.Size(416, 41);
            this.gtxtUser.TabIndex = 2;
            this.gtxtUser.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtUser_KeyDown);
            // 
            // icEyes
            // 
            this.icEyes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icEyes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icEyes.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.icEyes.IconColor = System.Drawing.Color.White;
            this.icEyes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icEyes.IconSize = 35;
            this.icEyes.Location = new System.Drawing.Point(469, 294);
            this.icEyes.Name = "icEyes";
            this.icEyes.Size = new System.Drawing.Size(32, 32);
            this.icEyes.TabIndex = 8;
            this.icEyes.TabStop = false;
            this.icEyes.Click += new System.EventHandler(this.icEyes_Click);
            // 
            // gtxtPass
            // 
            this.gtxtPass.BorderColor = System.Drawing.Color.White;
            this.gtxtPass.BorderRadius = 20;
            this.gtxtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtPass.DefaultText = "";
            this.gtxtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gtxtPass.ForeColor = System.Drawing.Color.White;
            this.gtxtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtPass.IconLeft = global::Urgent_Manager.Properties.Resources.locked_padlock_;
            this.gtxtPass.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.gtxtPass.IconLeftSize = new System.Drawing.Size(25, 25);
            this.gtxtPass.Location = new System.Drawing.Point(37, 290);
            this.gtxtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtPass.Name = "gtxtPass";
            this.gtxtPass.PasswordChar = '●';
            this.gtxtPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtPass.PlaceholderText = "Passeword";
            this.gtxtPass.SelectedText = "";
            this.gtxtPass.Size = new System.Drawing.Size(416, 41);
            this.gtxtPass.TabIndex = 3;
            this.gtxtPass.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtPass.UseSystemPasswordChar = true;
            this.gtxtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtPass_KeyDown);
            // 
            // gtxtDbName
            // 
            this.gtxtDbName.BorderColor = System.Drawing.Color.White;
            this.gtxtDbName.BorderRadius = 20;
            this.gtxtDbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtDbName.DefaultText = "";
            this.gtxtDbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtDbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtDbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtDbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtDbName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtDbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtDbName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gtxtDbName.ForeColor = System.Drawing.Color.White;
            this.gtxtDbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtDbName.IconLeft = global::Urgent_Manager.Properties.Resources.database;
            this.gtxtDbName.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.gtxtDbName.IconLeftSize = new System.Drawing.Size(25, 25);
            this.gtxtDbName.Location = new System.Drawing.Point(37, 159);
            this.gtxtDbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtDbName.Name = "gtxtDbName";
            this.gtxtDbName.PasswordChar = '\0';
            this.gtxtDbName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtDbName.PlaceholderText = "Database Name";
            this.gtxtDbName.SelectedText = "";
            this.gtxtDbName.Size = new System.Drawing.Size(416, 41);
            this.gtxtDbName.TabIndex = 1;
            this.gtxtDbName.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtDbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtDbName_KeyDown);
            // 
            // gtxtServerName
            // 
            this.gtxtServerName.BorderColor = System.Drawing.Color.White;
            this.gtxtServerName.BorderRadius = 20;
            this.gtxtServerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtServerName.DefaultText = "";
            this.gtxtServerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtServerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtServerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtServerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtServerName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtServerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtServerName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gtxtServerName.ForeColor = System.Drawing.Color.White;
            this.gtxtServerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtServerName.IconLeft = global::Urgent_Manager.Properties.Resources.server;
            this.gtxtServerName.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.gtxtServerName.IconLeftSize = new System.Drawing.Size(25, 25);
            this.gtxtServerName.Location = new System.Drawing.Point(37, 91);
            this.gtxtServerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtServerName.Name = "gtxtServerName";
            this.gtxtServerName.PasswordChar = '\0';
            this.gtxtServerName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtServerName.PlaceholderText = "Server Name";
            this.gtxtServerName.SelectedText = "";
            this.gtxtServerName.Size = new System.Drawing.Size(416, 41);
            this.gtxtServerName.TabIndex = 0;
            this.gtxtServerName.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtServerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtServerName_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabPage2.Controls.Add(this.btnSaveData);
            this.tabPage2.Controls.Add(this.gtxtPath);
            this.tabPage2.Controls.Add(this.btnConnect);
            this.tabPage2.Controls.Add(this.gtxtUserAuth);
            this.tabPage2.Controls.Add(this.gtxtPassAuth);
            this.tabPage2.Controls.Add(this.guna2ControlBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.chIsConnect);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.gtxtUserConnect);
            this.tabPage2.Controls.Add(this.icEyeNewPass);
            this.tabPage2.Controls.Add(this.gtxtUserPass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Data";
            // 
            // btnConnect
            // 
            this.btnConnect.BorderRadius = 20;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Image = global::Urgent_Manager.Properties.Resources.user__1_;
            this.btnConnect.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnConnect.ImageSize = new System.Drawing.Size(30, 30);
            this.btnConnect.IndicateFocus = true;
            this.btnConnect.Location = new System.Drawing.Point(39, 181);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(416, 41);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btxtConnect_Click);
            // 
            // gtxtUserAuth
            // 
            this.gtxtUserAuth.BorderColor = System.Drawing.Color.White;
            this.gtxtUserAuth.BorderRadius = 20;
            this.gtxtUserAuth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtUserAuth.DefaultText = "";
            this.gtxtUserAuth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtUserAuth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtUserAuth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUserAuth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUserAuth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtUserAuth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUserAuth.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gtxtUserAuth.ForeColor = System.Drawing.Color.White;
            this.gtxtUserAuth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUserAuth.IconLeft = global::Urgent_Manager.Properties.Resources.user;
            this.gtxtUserAuth.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.gtxtUserAuth.IconLeftSize = new System.Drawing.Size(25, 25);
            this.gtxtUserAuth.Location = new System.Drawing.Point(39, 67);
            this.gtxtUserAuth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtUserAuth.Name = "gtxtUserAuth";
            this.gtxtUserAuth.PasswordChar = '\0';
            this.gtxtUserAuth.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtUserAuth.PlaceholderText = "User Name";
            this.gtxtUserAuth.SelectedText = "";
            this.gtxtUserAuth.Size = new System.Drawing.Size(416, 41);
            this.gtxtUserAuth.TabIndex = 15;
            this.gtxtUserAuth.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtUserAuth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtUserAuth_KeyDown);
            // 
            // gtxtPassAuth
            // 
            this.gtxtPassAuth.BorderColor = System.Drawing.Color.White;
            this.gtxtPassAuth.BorderRadius = 20;
            this.gtxtPassAuth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtPassAuth.DefaultText = "";
            this.gtxtPassAuth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtPassAuth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtPassAuth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPassAuth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPassAuth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtPassAuth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtPassAuth.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gtxtPassAuth.ForeColor = System.Drawing.Color.White;
            this.gtxtPassAuth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtPassAuth.IconLeft = global::Urgent_Manager.Properties.Resources.locked_padlock_;
            this.gtxtPassAuth.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.gtxtPassAuth.IconLeftSize = new System.Drawing.Size(25, 25);
            this.gtxtPassAuth.Location = new System.Drawing.Point(39, 124);
            this.gtxtPassAuth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtPassAuth.Name = "gtxtPassAuth";
            this.gtxtPassAuth.PasswordChar = '●';
            this.gtxtPassAuth.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtPassAuth.PlaceholderText = "Passeword";
            this.gtxtPassAuth.SelectedText = "";
            this.gtxtPassAuth.Size = new System.Drawing.Size(416, 41);
            this.gtxtPassAuth.TabIndex = 16;
            this.gtxtPassAuth.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtPassAuth.UseSystemPasswordChar = true;
            this.gtxtPassAuth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtPassAuth_KeyDown);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(471, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 27);
            this.guna2ControlBox2.TabIndex = 14;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(183, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Data";
            // 
            // chIsConnect
            // 
            this.chIsConnect.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.chIsConnect.CheckedState.BorderRadius = 2;
            this.chIsConnect.CheckedState.BorderThickness = 0;
            this.chIsConnect.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chIsConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chIsConnect.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chIsConnect.ForeColor = System.Drawing.Color.White;
            this.chIsConnect.Location = new System.Drawing.Point(39, 351);
            this.chIsConnect.Name = "chIsConnect";
            this.chIsConnect.Size = new System.Drawing.Size(130, 24);
            this.chIsConnect.TabIndex = 2;
            this.chIsConnect.Text = "Is Connect";
            this.chIsConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chIsConnect.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chIsConnect.UncheckedState.BorderRadius = 2;
            this.chIsConnect.UncheckedState.BorderThickness = 0;
            this.chIsConnect.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chIsConnect.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::Urgent_Manager.Properties.Resources.update;
            this.btnUpdate.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.IndicateFocus = true;
            this.btnUpdate.Location = new System.Drawing.Point(39, 385);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(416, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gtxtUserConnect
            // 
            this.gtxtUserConnect.BorderColor = System.Drawing.Color.White;
            this.gtxtUserConnect.BorderRadius = 20;
            this.gtxtUserConnect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtUserConnect.DefaultText = "";
            this.gtxtUserConnect.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtUserConnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtUserConnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUserConnect.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUserConnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtUserConnect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUserConnect.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gtxtUserConnect.ForeColor = System.Drawing.Color.White;
            this.gtxtUserConnect.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUserConnect.IconLeft = global::Urgent_Manager.Properties.Resources.user;
            this.gtxtUserConnect.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.gtxtUserConnect.IconLeftSize = new System.Drawing.Size(25, 25);
            this.gtxtUserConnect.Location = new System.Drawing.Point(39, 238);
            this.gtxtUserConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtUserConnect.Name = "gtxtUserConnect";
            this.gtxtUserConnect.PasswordChar = '\0';
            this.gtxtUserConnect.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtUserConnect.PlaceholderText = "New User Name";
            this.gtxtUserConnect.SelectedText = "";
            this.gtxtUserConnect.Size = new System.Drawing.Size(416, 41);
            this.gtxtUserConnect.TabIndex = 0;
            this.gtxtUserConnect.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtUserConnect.Visible = false;
            this.gtxtUserConnect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtUserConnect_KeyDown);
            // 
            // icEyeNewPass
            // 
            this.icEyeNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icEyeNewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icEyeNewPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.icEyeNewPass.IconColor = System.Drawing.Color.White;
            this.icEyeNewPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icEyeNewPass.IconSize = 35;
            this.icEyeNewPass.Location = new System.Drawing.Point(471, 299);
            this.icEyeNewPass.Name = "icEyeNewPass";
            this.icEyeNewPass.Size = new System.Drawing.Size(32, 32);
            this.icEyeNewPass.TabIndex = 12;
            this.icEyeNewPass.TabStop = false;
            this.icEyeNewPass.Visible = false;
            this.icEyeNewPass.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // gtxtUserPass
            // 
            this.gtxtUserPass.BorderColor = System.Drawing.Color.White;
            this.gtxtUserPass.BorderRadius = 20;
            this.gtxtUserPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtUserPass.DefaultText = "";
            this.gtxtUserPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtUserPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtUserPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUserPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUserPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtUserPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUserPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gtxtUserPass.ForeColor = System.Drawing.Color.White;
            this.gtxtUserPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUserPass.IconLeft = global::Urgent_Manager.Properties.Resources.locked_padlock_;
            this.gtxtUserPass.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.gtxtUserPass.IconLeftSize = new System.Drawing.Size(25, 25);
            this.gtxtUserPass.Location = new System.Drawing.Point(39, 295);
            this.gtxtUserPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtUserPass.Name = "gtxtUserPass";
            this.gtxtUserPass.PasswordChar = '●';
            this.gtxtUserPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtUserPass.PlaceholderText = "New Passeword";
            this.gtxtUserPass.SelectedText = "";
            this.gtxtUserPass.Size = new System.Drawing.Size(416, 41);
            this.gtxtUserPass.TabIndex = 1;
            this.gtxtUserPass.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtUserPass.UseSystemPasswordChar = true;
            this.gtxtUserPass.Visible = false;
            this.gtxtUserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtUserPass_KeyDown);
            // 
            // gtxtPath
            // 
            this.gtxtPath.BorderColor = System.Drawing.Color.White;
            this.gtxtPath.BorderRadius = 20;
            this.gtxtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtPath.DefaultText = "";
            this.gtxtPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtPath.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gtxtPath.ForeColor = System.Drawing.Color.White;
            this.gtxtPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtPath.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.gtxtPath.IconLeftSize = new System.Drawing.Size(25, 25);
            this.gtxtPath.Location = new System.Drawing.Point(39, 451);
            this.gtxtPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtPath.Name = "gtxtPath";
            this.gtxtPath.PasswordChar = '\0';
            this.gtxtPath.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtPath.PlaceholderText = "Path Name";
            this.gtxtPath.SelectedText = "";
            this.gtxtPath.Size = new System.Drawing.Size(416, 41);
            this.gtxtPath.TabIndex = 19;
            this.gtxtPath.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtPath.Visible = false;
            // 
            // btnSaveData
            // 
            this.btnSaveData.BorderRadius = 20;
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnSaveData.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnSaveData.ForeColor = System.Drawing.Color.White;
            this.btnSaveData.Image = global::Urgent_Manager.Properties.Resources.check;
            this.btnSaveData.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnSaveData.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveData.IndicateFocus = true;
            this.btnSaveData.Location = new System.Drawing.Point(39, 508);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(416, 41);
            this.btnSaveData.TabIndex = 21;
            this.btnSaveData.Text = "Save";
            this.btnSaveData.Visible = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // ServerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(522, 624);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerData";
            this.Load += new System.EventHandler(this.ServerData_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icEyes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icEyeNewPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2TextBox gtxtDbName;
        private Guna.UI2.WinForms.Guna2TextBox gtxtServerName;
        private Guna.UI2.WinForms.Guna2TextBox gtxtUser;
        private FontAwesome.Sharp.IconPictureBox icEyes;
        private Guna.UI2.WinForms.Guna2TextBox gtxtPass;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox chIsConnect;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox gtxtUserConnect;
        private FontAwesome.Sharp.IconPictureBox icEyeNewPass;
        private Guna.UI2.WinForms.Guna2TextBox gtxtUserPass;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Button btnConnect;
        private Guna.UI2.WinForms.Guna2TextBox gtxtUserAuth;
        private Guna.UI2.WinForms.Guna2TextBox gtxtPassAuth;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDirectories;
        private Guna.UI2.WinForms.Guna2CheckBox chIsConnectPerMC;
        private Guna.UI2.WinForms.Guna2Button btnSaveData;
        private Guna.UI2.WinForms.Guna2TextBox gtxtPath;
    }
}