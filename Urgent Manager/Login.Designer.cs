namespace Urgent_Manager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblWrongCredentials = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.icUpdatedPass = new FontAwesome.Sharp.IconPictureBox();
            this.gtxtUpdatedPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.icEyes = new FontAwesome.Sharp.IconPictureBox();
            this.gtxtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.cmbRoles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gradientPanel1 = new Urgent_Manager.CustomViews.GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icUpdatedPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.lblLoading);
            this.panel1.Controls.Add(this.lblWrongCredentials);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.icUpdatedPass);
            this.panel1.Controls.Add(this.gtxtUpdatedPass);
            this.panel1.Controls.Add(this.icEyes);
            this.panel1.Controls.Add(this.gtxtPass);
            this.panel1.Controls.Add(this.gtxtUserName);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.cmbRoles);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.guna2ControlBox3);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(302, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 600);
            this.panel1.TabIndex = 1;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.lblLoading.Location = new System.Drawing.Point(30, 519);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(362, 29);
            this.lblLoading.TabIndex = 12;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoading.Visible = false;
            // 
            // lblWrongCredentials
            // 
            this.lblWrongCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWrongCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongCredentials.ForeColor = System.Drawing.Color.Red;
            this.lblWrongCredentials.Location = new System.Drawing.Point(26, 553);
            this.lblWrongCredentials.Name = "lblWrongCredentials";
            this.lblWrongCredentials.Size = new System.Drawing.Size(415, 43);
            this.lblWrongCredentials.TabIndex = 11;
            this.lblWrongCredentials.Text = "If you have forgotten your Credentials, please contact your system administrator";
            this.lblWrongCredentials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrongCredentials.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose Your Role To Sign In\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::Urgent_Manager.Properties.Resources.user__1_;
            this.btnLogin.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnLogin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogin.IndicateFocus = true;
            this.btnLogin.Location = new System.Drawing.Point(28, 464);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(364, 44);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log In";
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // icUpdatedPass
            // 
            this.icUpdatedPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icUpdatedPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icUpdatedPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.icUpdatedPass.IconColor = System.Drawing.Color.White;
            this.icUpdatedPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icUpdatedPass.IconSize = 35;
            this.icUpdatedPass.Location = new System.Drawing.Point(399, 398);
            this.icUpdatedPass.Name = "icUpdatedPass";
            this.icUpdatedPass.Size = new System.Drawing.Size(32, 32);
            this.icUpdatedPass.TabIndex = 8;
            this.icUpdatedPass.TabStop = false;
            this.icUpdatedPass.Visible = false;
            this.icUpdatedPass.Click += new System.EventHandler(this.icUpdatedPass_Click);
            // 
            // gtxtUpdatedPass
            // 
            this.gtxtUpdatedPass.BorderColor = System.Drawing.Color.White;
            this.gtxtUpdatedPass.BorderRadius = 20;
            this.gtxtUpdatedPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtUpdatedPass.DefaultText = "";
            this.gtxtUpdatedPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtUpdatedPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtUpdatedPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUpdatedPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUpdatedPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtUpdatedPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUpdatedPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gtxtUpdatedPass.ForeColor = System.Drawing.Color.White;
            this.gtxtUpdatedPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUpdatedPass.IconLeft = global::Urgent_Manager.Properties.Resources.locked_padlock_;
            this.gtxtUpdatedPass.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.gtxtUpdatedPass.IconLeftSize = new System.Drawing.Size(25, 25);
            this.gtxtUpdatedPass.Location = new System.Drawing.Point(28, 397);
            this.gtxtUpdatedPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtUpdatedPass.Name = "gtxtUpdatedPass";
            this.gtxtUpdatedPass.PasswordChar = '●';
            this.gtxtUpdatedPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtUpdatedPass.PlaceholderText = "Update Your Password";
            this.gtxtUpdatedPass.SelectedText = "";
            this.gtxtUpdatedPass.Size = new System.Drawing.Size(364, 41);
            this.gtxtUpdatedPass.TabIndex = 3;
            this.gtxtUpdatedPass.TextOffset = new System.Drawing.Point(63, 0);
            this.gtxtUpdatedPass.UseSystemPasswordChar = true;
            this.gtxtUpdatedPass.Visible = false;
            this.gtxtUpdatedPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtUpdatedPass_KeyDown);
            // 
            // icEyes
            // 
            this.icEyes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icEyes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icEyes.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.icEyes.IconColor = System.Drawing.Color.White;
            this.icEyes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icEyes.IconSize = 35;
            this.icEyes.Location = new System.Drawing.Point(399, 334);
            this.icEyes.Name = "icEyes";
            this.icEyes.Size = new System.Drawing.Size(32, 32);
            this.icEyes.TabIndex = 6;
            this.icEyes.TabStop = false;
            this.icEyes.Visible = false;
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
            this.gtxtPass.Location = new System.Drawing.Point(28, 333);
            this.gtxtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtPass.Name = "gtxtPass";
            this.gtxtPass.PasswordChar = '●';
            this.gtxtPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtPass.PlaceholderText = "Passeword";
            this.gtxtPass.SelectedText = "";
            this.gtxtPass.Size = new System.Drawing.Size(364, 41);
            this.gtxtPass.TabIndex = 2;
            this.gtxtPass.TextOffset = new System.Drawing.Point(63, 0);
            this.gtxtPass.UseSystemPasswordChar = true;
            this.gtxtPass.Visible = false;
            this.gtxtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtPass_KeyDown);
            // 
            // gtxtUserName
            // 
            this.gtxtUserName.BorderColor = System.Drawing.Color.White;
            this.gtxtUserName.BorderRadius = 20;
            this.gtxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtUserName.DefaultText = "";
            this.gtxtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gtxtUserName.ForeColor = System.Drawing.Color.White;
            this.gtxtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUserName.IconLeft = global::Urgent_Manager.Properties.Resources.user;
            this.gtxtUserName.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.gtxtUserName.IconLeftSize = new System.Drawing.Size(25, 25);
            this.gtxtUserName.Location = new System.Drawing.Point(28, 270);
            this.gtxtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtUserName.Name = "gtxtUserName";
            this.gtxtUserName.PasswordChar = '\0';
            this.gtxtUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gtxtUserName.PlaceholderText = "User Name";
            this.gtxtUserName.SelectedText = "";
            this.gtxtUserName.Size = new System.Drawing.Size(364, 41);
            this.gtxtUserName.TabIndex = 1;
            this.gtxtUserName.TextOffset = new System.Drawing.Point(63, 0);
            this.gtxtUserName.Visible = false;
            this.gtxtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtUserName_KeyDown);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 35;
            this.iconPictureBox2.Location = new System.Drawing.Point(52, 214);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // cmbRoles
            // 
            this.cmbRoles.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoles.BorderColor = System.Drawing.Color.White;
            this.cmbRoles.BorderRadius = 20;
            this.cmbRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRoles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbRoles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbRoles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbRoles.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbRoles.ForeColor = System.Drawing.Color.White;
            this.cmbRoles.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbRoles.IntegralHeight = false;
            this.cmbRoles.ItemHeight = 35;
            this.cmbRoles.Items.AddRange(new object[] {
            "Administrator",
            "Alimentation",
            "Entry Agent",
            "Shift Leader"});
            this.cmbRoles.Location = new System.Drawing.Point(28, 210);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(364, 41);
            this.cmbRoles.TabIndex = 0;
            this.cmbRoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 120;
            this.iconPictureBox1.Location = new System.Drawing.Point(159, 26);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(353, 1);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(401, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.panel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Black;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(302, 600);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "All Rights Reserved | 2022 V1.0.0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Developed By Hamdach Abdelouahhab";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::Urgent_Manager.Properties.Resources.alarm;
            this.pictureBox2.Location = new System.Drawing.Point(112, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 89);
            this.label2.TabIndex = 2;
            this.label2.Text = "Our team believes that the future relies on the work we do, the solutions we deve" +
    "lop and the story we’re creating together every day.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doing the Right Thing, The Right Way. Always.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Urgent_Manager.Properties.Resources.aptiveDark1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.gradientPanel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icUpdatedPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomViews.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRoles;
        private Guna.UI2.WinForms.Guna2TextBox gtxtUserName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox gtxtPass;
        private FontAwesome.Sharp.IconPictureBox icEyes;
        private FontAwesome.Sharp.IconPictureBox icUpdatedPass;
        private Guna.UI2.WinForms.Guna2TextBox gtxtUpdatedPass;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWrongCredentials;
        private System.Windows.Forms.Label lblLoading;
    }
}

