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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gtxtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.icEyes = new FontAwesome.Sharp.IconPictureBox();
            this.gtxtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtDbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtServerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chIsConnect = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.gtxtUserConnect = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.gtxtUserPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icEyes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(522, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
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
            this.tabPage1.Size = new System.Drawing.Size(514, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server Data";
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
            this.btnSave.Location = new System.Drawing.Point(37, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(416, 41);
            this.btnSave.TabIndex = 4;
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
            this.tabPage2.Controls.Add(this.guna2ControlBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.chIsConnect);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.gtxtUserConnect);
            this.tabPage2.Controls.Add(this.iconPictureBox1);
            this.tabPage2.Controls.Add(this.gtxtUserPass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Data";
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
            this.label2.Location = new System.Drawing.Point(185, 49);
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
            this.chIsConnect.Location = new System.Drawing.Point(39, 278);
            this.chIsConnect.Name = "chIsConnect";
            this.chIsConnect.Size = new System.Drawing.Size(130, 24);
            this.chIsConnect.TabIndex = 2;
            this.chIsConnect.Text = "Is Connect";
            this.chIsConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chIsConnect.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chIsConnect.UncheckedState.BorderRadius = 2;
            this.chIsConnect.UncheckedState.BorderThickness = 0;
            this.chIsConnect.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chIsConnect.CheckedChanged += new System.EventHandler(this.chIsConnect_CheckedChanged);
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
            this.btnUpdate.Location = new System.Drawing.Point(39, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(416, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
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
            this.gtxtUserConnect.Location = new System.Drawing.Point(39, 137);
            this.gtxtUserConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtUserConnect.Name = "gtxtUserConnect";
            this.gtxtUserConnect.PasswordChar = '\0';
            this.gtxtUserConnect.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtUserConnect.PlaceholderText = "User Name";
            this.gtxtUserConnect.SelectedText = "";
            this.gtxtUserConnect.Size = new System.Drawing.Size(416, 41);
            this.gtxtUserConnect.TabIndex = 0;
            this.gtxtUserConnect.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtUserConnect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtUserConnect_KeyDown);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(471, 204);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
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
            this.gtxtUserPass.Location = new System.Drawing.Point(39, 200);
            this.gtxtUserPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtUserPass.Name = "gtxtUserPass";
            this.gtxtUserPass.PasswordChar = '●';
            this.gtxtUserPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtUserPass.PlaceholderText = "Passeword";
            this.gtxtUserPass.SelectedText = "";
            this.gtxtUserPass.Size = new System.Drawing.Size(416, 41);
            this.gtxtUserPass.TabIndex = 1;
            this.gtxtUserPass.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtUserPass.UseSystemPasswordChar = true;
            this.gtxtUserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtUserPass_KeyDown);
            // 
            // ServerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(522, 501);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServerData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerData";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icEyes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
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
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox gtxtUserPass;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}