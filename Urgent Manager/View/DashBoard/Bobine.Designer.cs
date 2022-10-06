namespace Urgent_Manager.View.DashBoard
{
    partial class Bobine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGReference = new System.Windows.Forms.Label();
            this.gtxtPvc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPvc = new System.Windows.Forms.Label();
            this.gtxtCableName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gtxtSection = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.gtxtColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.gtxtGReference = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Urgent_Manager.CustomViews.GradientPanel();
            this.gPFamilyLoad = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.gPUpload = new Guna.UI2.WinForms.Guna2Panel();
            this.gPicUpload = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gPUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPicUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MCName,
            this.Section,
            this.MCType,
            this.MCZone,
            this.GReference,
            this.User});
            this.guna2DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(24, 365);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(892, 229);
            this.guna2DataGridView1.TabIndex = 8;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // MCName
            // 
            this.MCName.FillWeight = 95.63452F;
            this.MCName.HeaderText = "Cable";
            this.MCName.Name = "MCName";
            this.MCName.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.FillWeight = 95.63452F;
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // MCType
            // 
            this.MCType.FillWeight = 95.63452F;
            this.MCType.HeaderText = "PVC";
            this.MCType.Name = "MCType";
            this.MCType.ReadOnly = true;
            // 
            // MCZone
            // 
            this.MCZone.FillWeight = 95.63452F;
            this.MCZone.HeaderText = "Color";
            this.MCZone.Name = "MCZone";
            this.MCZone.ReadOnly = true;
            // 
            // GReference
            // 
            this.GReference.FillWeight = 95.63452F;
            this.GReference.HeaderText = "Guide";
            this.GReference.Name = "GReference";
            this.GReference.ReadOnly = true;
            // 
            // User
            // 
            this.User.FillWeight = 121.8274F;
            this.User.HeaderText = "Entry Agent";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // lblGReference
            // 
            this.lblGReference.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGReference.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGReference.ForeColor = System.Drawing.Color.White;
            this.lblGReference.Location = new System.Drawing.Point(21, 217);
            this.lblGReference.Name = "lblGReference";
            this.lblGReference.Size = new System.Drawing.Size(132, 18);
            this.lblGReference.TabIndex = 22;
            this.lblGReference.Text = "Guide Reference : ";
            // 
            // gtxtPvc
            // 
            this.gtxtPvc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gtxtPvc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtPvc.BorderRadius = 20;
            this.gtxtPvc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtPvc.DefaultText = "";
            this.gtxtPvc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtPvc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtPvc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPvc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPvc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtPvc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtPvc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtPvc.ForeColor = System.Drawing.Color.White;
            this.gtxtPvc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtPvc.Location = new System.Drawing.Point(529, 73);
            this.gtxtPvc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtPvc.Name = "gtxtPvc";
            this.gtxtPvc.PasswordChar = '\0';
            this.gtxtPvc.PlaceholderText = "PVC ";
            this.gtxtPvc.SelectedText = "";
            this.gtxtPvc.Size = new System.Drawing.Size(292, 41);
            this.gtxtPvc.TabIndex = 1;
            this.gtxtPvc.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtPvc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtPvc_KeyDown);
            this.gtxtPvc.Leave += new System.EventHandler(this.gtxtPvc_Leave);
            // 
            // lblPvc
            // 
            this.lblPvc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPvc.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPvc.ForeColor = System.Drawing.Color.White;
            this.lblPvc.Location = new System.Drawing.Point(412, 85);
            this.lblPvc.Name = "lblPvc";
            this.lblPvc.Size = new System.Drawing.Size(111, 18);
            this.lblPvc.TabIndex = 21;
            this.lblPvc.Text = "PVC Type :  ";
            // 
            // gtxtCableName
            // 
            this.gtxtCableName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gtxtCableName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtCableName.BorderRadius = 20;
            this.gtxtCableName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtCableName.DefaultText = "";
            this.gtxtCableName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtCableName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtCableName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtCableName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtCableName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtCableName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtCableName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtCableName.ForeColor = System.Drawing.Color.White;
            this.gtxtCableName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtCableName.Location = new System.Drawing.Point(157, 73);
            this.gtxtCableName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtCableName.Name = "gtxtCableName";
            this.gtxtCableName.PasswordChar = '\0';
            this.gtxtCableName.PlaceholderText = "Cable";
            this.gtxtCableName.SelectedText = "";
            this.gtxtCableName.Size = new System.Drawing.Size(207, 41);
            this.gtxtCableName.TabIndex = 0;
            this.gtxtCableName.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtCableName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtCableName_KeyDown);
            this.gtxtCableName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gtxtCableName_KeyUp);
            this.gtxtCableName.Leave += new System.EventHandler(this.gtxtCableName_Leave);
            // 
            // lblCable
            // 
            this.lblCable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCable.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCable.ForeColor = System.Drawing.Color.White;
            this.lblCable.Location = new System.Drawing.Point(21, 85);
            this.lblCable.Name = "lblCable";
            this.lblCable.Size = new System.Drawing.Size(111, 18);
            this.lblCable.TabIndex = 19;
            this.lblCable.Text = "Cable Name : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 40);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(951, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = " Cable";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gtxtSection
            // 
            this.gtxtSection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gtxtSection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtSection.BorderRadius = 20;
            this.gtxtSection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtSection.DefaultText = "";
            this.gtxtSection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtSection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtSection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtSection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtSection.ForeColor = System.Drawing.Color.White;
            this.gtxtSection.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtSection.Location = new System.Drawing.Point(529, 141);
            this.gtxtSection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtSection.Name = "gtxtSection";
            this.gtxtSection.PasswordChar = '\0';
            this.gtxtSection.PlaceholderText = "Section";
            this.gtxtSection.SelectedText = "";
            this.gtxtSection.Size = new System.Drawing.Size(292, 41);
            this.gtxtSection.TabIndex = 3;
            this.gtxtSection.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtSection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtSection_KeyDown);
            this.gtxtSection.Leave += new System.EventHandler(this.gtxtSection_Leave);
            // 
            // lblSection
            // 
            this.lblSection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSection.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.White;
            this.lblSection.Location = new System.Drawing.Point(412, 153);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(111, 18);
            this.lblSection.TabIndex = 28;
            this.lblSection.Text = "Section : ";
            // 
            // gtxtColor
            // 
            this.gtxtColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gtxtColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtColor.BorderRadius = 20;
            this.gtxtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtColor.DefaultText = "";
            this.gtxtColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtColor.ForeColor = System.Drawing.Color.White;
            this.gtxtColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtColor.Location = new System.Drawing.Point(157, 141);
            this.gtxtColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtColor.Name = "gtxtColor";
            this.gtxtColor.PasswordChar = '\0';
            this.gtxtColor.PlaceholderText = "Color";
            this.gtxtColor.SelectedText = "";
            this.gtxtColor.Size = new System.Drawing.Size(207, 41);
            this.gtxtColor.TabIndex = 2;
            this.gtxtColor.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtxtColor_KeyDown);
            this.gtxtColor.Leave += new System.EventHandler(this.gtxtColor_Leave);
            // 
            // lblColor
            // 
            this.lblColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblColor.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(21, 153);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(111, 18);
            this.lblColor.TabIndex = 27;
            this.lblColor.Text = "Color : ";
            // 
            // gtxtGReference
            // 
            this.gtxtGReference.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gtxtGReference.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtGReference.BorderRadius = 20;
            this.gtxtGReference.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtGReference.DefaultText = "";
            this.gtxtGReference.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtGReference.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtGReference.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtGReference.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtGReference.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtGReference.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtGReference.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtGReference.ForeColor = System.Drawing.Color.White;
            this.gtxtGReference.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtGReference.Location = new System.Drawing.Point(157, 207);
            this.gtxtGReference.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtGReference.Name = "gtxtGReference";
            this.gtxtGReference.PasswordChar = '\0';
            this.gtxtGReference.PlaceholderText = "Guide";
            this.gtxtGReference.SelectedText = "";
            this.gtxtGReference.Size = new System.Drawing.Size(207, 41);
            this.gtxtGReference.TabIndex = 4;
            this.gtxtGReference.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.guna2DataGridView1;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.btnDelete.Image = global::Urgent_Manager.Properties.Resources.delete;
            this.btnDelete.IndicateFocus = true;
            this.btnDelete.Location = new System.Drawing.Point(406, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 41);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.btnUpdate.Image = global::Urgent_Manager.Properties.Resources.update;
            this.btnUpdate.IndicateFocus = true;
            this.btnUpdate.Location = new System.Drawing.Point(280, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 41);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BorderRadius = 20;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.btnSave.Image = global::Urgent_Manager.Properties.Resources.diskette;
            this.btnSave.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnSave.IndicateFocus = true;
            this.btnSave.Location = new System.Drawing.Point(157, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.label2.Location = new System.Drawing.Point(338, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.label3.Location = new System.Drawing.Point(785, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.label4.Location = new System.Drawing.Point(785, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.label5.Location = new System.Drawing.Point(338, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "*";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 40);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(967, 2);
            this.gradientPanel1.TabIndex = 24;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            // 
            // gPFamilyLoad
            // 
            this.gPFamilyLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gPFamilyLoad.BorderRadius = 5;
            this.gPFamilyLoad.Location = new System.Drawing.Point(531, 331);
            this.gPFamilyLoad.Name = "gPFamilyLoad";
            this.gPFamilyLoad.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.gPFamilyLoad.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.gPFamilyLoad.Size = new System.Drawing.Size(290, 15);
            this.gPFamilyLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.gPFamilyLoad.TabIndex = 81;
            this.gPFamilyLoad.Text = "guna2ProgressBar1";
            this.gPFamilyLoad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.gPFamilyLoad.Value = 40;
            this.gPFamilyLoad.Visible = false;
            // 
            // gPUpload
            // 
            this.gPUpload.AllowDrop = true;
            this.gPUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gPUpload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gPUpload.BorderRadius = 10;
            this.gPUpload.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gPUpload.BorderThickness = 2;
            this.gPUpload.Controls.Add(this.gPicUpload);
            this.gPUpload.Controls.Add(this.lblFileName);
            this.gPUpload.Location = new System.Drawing.Point(531, 193);
            this.gPUpload.Name = "gPUpload";
            this.gPUpload.Size = new System.Drawing.Size(290, 132);
            this.gPUpload.TabIndex = 80;
            this.gPUpload.DragDrop += new System.Windows.Forms.DragEventHandler(this.gPUpload_DragDrop);
            this.gPUpload.DragEnter += new System.Windows.Forms.DragEventHandler(this.gPUpload_DragEnter);
            // 
            // gPicUpload
            // 
            this.gPicUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gPicUpload.Image = global::Urgent_Manager.Properties.Resources.upload;
            this.gPicUpload.ImageRotate = 0F;
            this.gPicUpload.Location = new System.Drawing.Point(56, 9);
            this.gPicUpload.Name = "gPicUpload";
            this.gPicUpload.Size = new System.Drawing.Size(174, 67);
            this.gPicUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gPicUpload.TabIndex = 1;
            this.gPicUpload.TabStop = false;
            // 
            // lblFileName
            // 
            this.lblFileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFileName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(20, 76);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(249, 34);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "Drag The Cable File Here";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bobine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(951, 607);
            this.Controls.Add(this.gPFamilyLoad);
            this.Controls.Add(this.gPUpload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gtxtGReference);
            this.Controls.Add(this.gtxtSection);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.gtxtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblGReference);
            this.Controls.Add(this.gtxtPvc);
            this.Controls.Add(this.lblPvc);
            this.Controls.Add(this.gtxtCableName);
            this.Controls.Add(this.lblCable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bobine";
            this.Text = "Bobine";
            this.Load += new System.EventHandler(this.Bobine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gPUpload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gPicUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomViews.GradientPanel gradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblGReference;
        private Guna.UI2.WinForms.Guna2TextBox gtxtPvc;
        private System.Windows.Forms.Label lblPvc;
        private Guna.UI2.WinForms.Guna2TextBox gtxtCableName;
        private System.Windows.Forms.Label lblCable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox gtxtSection;
        private System.Windows.Forms.Label lblSection;
        private Guna.UI2.WinForms.Guna2TextBox gtxtColor;
        private System.Windows.Forms.Label lblColor;
        private Guna.UI2.WinForms.Guna2TextBox gtxtGReference;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn GReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ProgressBar gPFamilyLoad;
        private Guna.UI2.WinForms.Guna2Panel gPUpload;
        private Guna.UI2.WinForms.Guna2PictureBox gPicUpload;
        private System.Windows.Forms.Label lblFileName;
    }
}