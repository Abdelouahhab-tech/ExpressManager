namespace Urgent_Manager.View.OptimaisationWindows
{
    partial class ArchiveManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gdateTimeUrgent = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.icExport = new FontAwesome.Sharp.IconButton();
            this.lblLoading = new System.Windows.Forms.Label();
            this.icPrint = new FontAwesome.Sharp.IconButton();
            this.panelCmbPlanBMachine = new System.Windows.Forms.Panel();
            this.cmbPlanBMc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gSwitchFilter = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.chPrintAll = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.gtxtUnico = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(19, 160);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(909, 401);
            this.guna2DataGridView1.TabIndex = 3;
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.guna2DataGridView1;
            // 
            // gdateTimeUrgent
            // 
            this.gdateTimeUrgent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gdateTimeUrgent.BackColor = System.Drawing.Color.Transparent;
            this.gdateTimeUrgent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gdateTimeUrgent.BorderRadius = 18;
            this.gdateTimeUrgent.BorderThickness = 2;
            this.gdateTimeUrgent.Checked = true;
            this.gdateTimeUrgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gdateTimeUrgent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gdateTimeUrgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gdateTimeUrgent.ForeColor = System.Drawing.Color.White;
            this.gdateTimeUrgent.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.gdateTimeUrgent.Location = new System.Drawing.Point(650, 44);
            this.gdateTimeUrgent.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gdateTimeUrgent.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gdateTimeUrgent.Name = "gdateTimeUrgent";
            this.gdateTimeUrgent.Size = new System.Drawing.Size(278, 40);
            this.gdateTimeUrgent.TabIndex = 0;
            this.gdateTimeUrgent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gdateTimeUrgent.Value = new System.DateTime(2022, 7, 7, 8, 22, 58, 917);
            this.gdateTimeUrgent.ValueChanged += new System.EventHandler(this.gdateTimeUrgent_ValueChanged);
            // 
            // icExport
            // 
            this.icExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icExport.FlatAppearance.BorderSize = 0;
            this.icExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icExport.ForeColor = System.Drawing.Color.White;
            this.icExport.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.icExport.IconColor = System.Drawing.Color.White;
            this.icExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icExport.IconSize = 40;
            this.icExport.Location = new System.Drawing.Point(192, 44);
            this.icExport.Name = "icExport";
            this.icExport.Size = new System.Drawing.Size(45, 38);
            this.icExport.TabIndex = 1;
            this.icExport.UseVisualStyleBackColor = true;
            this.icExport.Click += new System.EventHandler(this.icExport_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.lblLoading.Location = new System.Drawing.Point(3, 50);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(88, 19);
            this.lblLoading.TabIndex = 10;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.Visible = false;
            // 
            // icPrint
            // 
            this.icPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icPrint.FlatAppearance.BorderSize = 0;
            this.icPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icPrint.ForeColor = System.Drawing.Color.White;
            this.icPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icPrint.IconColor = System.Drawing.Color.White;
            this.icPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icPrint.IconSize = 40;
            this.icPrint.Location = new System.Drawing.Point(141, 44);
            this.icPrint.Name = "icPrint";
            this.icPrint.Size = new System.Drawing.Size(45, 38);
            this.icPrint.TabIndex = 11;
            this.icPrint.UseVisualStyleBackColor = true;
            this.icPrint.Click += new System.EventHandler(this.icPrint_Click);
            // 
            // panelCmbPlanBMachine
            // 
            this.panelCmbPlanBMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCmbPlanBMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelCmbPlanBMachine.Location = new System.Drawing.Point(514, 75);
            this.panelCmbPlanBMachine.Name = "panelCmbPlanBMachine";
            this.panelCmbPlanBMachine.Size = new System.Drawing.Size(117, 2);
            this.panelCmbPlanBMachine.TabIndex = 23;
            // 
            // cmbPlanBMc
            // 
            this.cmbPlanBMc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPlanBMc.BackColor = System.Drawing.Color.Transparent;
            this.cmbPlanBMc.BorderThickness = 0;
            this.cmbPlanBMc.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbPlanBMc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPlanBMc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanBMc.DropDownWidth = 250;
            this.cmbPlanBMc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbPlanBMc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPlanBMc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPlanBMc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPlanBMc.ForeColor = System.Drawing.Color.White;
            this.cmbPlanBMc.IntegralHeight = false;
            this.cmbPlanBMc.ItemHeight = 30;
            this.cmbPlanBMc.Location = new System.Drawing.Point(515, 41);
            this.cmbPlanBMc.Name = "cmbPlanBMc";
            this.cmbPlanBMc.Size = new System.Drawing.Size(117, 36);
            this.cmbPlanBMc.TabIndex = 22;
            this.cmbPlanBMc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbPlanBMc.SelectedIndexChanged += new System.EventHandler(this.cmbPlanBMc_SelectedIndexChanged);
            // 
            // gSwitchFilter
            // 
            this.gSwitchFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gSwitchFilter.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.gSwitchFilter.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gSwitchFilter.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.gSwitchFilter.CheckedState.InnerColor = System.Drawing.Color.White;
            this.gSwitchFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gSwitchFilter.Location = new System.Drawing.Point(459, 58);
            this.gSwitchFilter.Name = "gSwitchFilter";
            this.gSwitchFilter.Size = new System.Drawing.Size(43, 20);
            this.gSwitchFilter.TabIndex = 25;
            this.gSwitchFilter.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gSwitchFilter.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gSwitchFilter.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.gSwitchFilter.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.gSwitchFilter.CheckedChanged += new System.EventHandler(this.gSwitchFilter_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(351, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 58);
            this.label2.TabIndex = 24;
            this.label2.Text = "Filter By Date And Machine";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chPrintAll
            // 
            this.chPrintAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chPrintAll.AutoSize = true;
            this.chPrintAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.chPrintAll.CheckedState.BorderRadius = 2;
            this.chPrintAll.CheckedState.BorderThickness = 0;
            this.chPrintAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.chPrintAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chPrintAll.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chPrintAll.ForeColor = System.Drawing.Color.White;
            this.chPrintAll.Location = new System.Drawing.Point(244, 55);
            this.chPrintAll.Name = "chPrintAll";
            this.chPrintAll.Size = new System.Drawing.Size(99, 22);
            this.chPrintAll.TabIndex = 26;
            this.chPrintAll.Text = "Print All MC";
            this.chPrintAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chPrintAll.UncheckedState.BorderRadius = 2;
            this.chPrintAll.UncheckedState.BorderThickness = 0;
            this.chPrintAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chPrintAll.CheckedChanged += new System.EventHandler(this.chPrintAll_CheckedChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(239, 244);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(421, 29);
            this.lblMessage.TabIndex = 37;
            this.lblMessage.Text = "You Don\'t Have Any Data For Now";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // gtxtUnico
            // 
            this.gtxtUnico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gtxtUnico.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUnico.BorderRadius = 20;
            this.gtxtUnico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtUnico.DefaultText = "";
            this.gtxtUnico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtUnico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtUnico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUnico.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUnico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtUnico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtUnico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtUnico.ForeColor = System.Drawing.Color.White;
            this.gtxtUnico.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtUnico.IconLeft = global::Urgent_Manager.Properties.Resources.search;
            this.gtxtUnico.Location = new System.Drawing.Point(650, 101);
            this.gtxtUnico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtUnico.Name = "gtxtUnico";
            this.gtxtUnico.PasswordChar = '\0';
            this.gtxtUnico.PlaceholderText = "Unico";
            this.gtxtUnico.SelectedText = "";
            this.gtxtUnico.Size = new System.Drawing.Size(278, 40);
            this.gtxtUnico.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.gtxtUnico.TabIndex = 38;
            this.gtxtUnico.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gtxtUnico_KeyUp);
            this.gtxtUnico.Leave += new System.EventHandler(this.gtxtUnico_Leave);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRefresh.Image = global::Urgent_Manager.Properties.Resources.refresh;
            this.btnRefresh.ImageSize = new System.Drawing.Size(35, 35);
            this.btnRefresh.Location = new System.Drawing.Point(94, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRefresh.Size = new System.Drawing.Size(45, 38);
            this.btnRefresh.TabIndex = 39;
            // 
            // ArchiveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(940, 641);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gtxtUnico);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.chPrintAll);
            this.Controls.Add(this.gSwitchFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelCmbPlanBMachine);
            this.Controls.Add(this.cmbPlanBMc);
            this.Controls.Add(this.icPrint);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.gdateTimeUrgent);
            this.Controls.Add(this.icExport);
            this.Controls.Add(this.guna2DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArchiveManager";
            this.Text = "ArchiveManager";
            this.Load += new System.EventHandler(this.ArchiveManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton icExport;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker gdateTimeUrgent;
        private System.Windows.Forms.Label lblLoading;
        private FontAwesome.Sharp.IconButton icPrint;
        private System.Windows.Forms.Panel panelCmbPlanBMachine;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPlanBMc;
        private Guna.UI2.WinForms.Guna2ToggleSwitch gSwitchFilter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox chPrintAll;
        private System.Windows.Forms.Label lblMessage;
        private Guna.UI2.WinForms.Guna2TextBox gtxtUnico;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}