namespace Urgent_Manager.View.DashBoard
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.piechart = new LiveCharts.WinForms.PieChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gSwitchMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.cmbMachine = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbArea = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.livePreview = new System.Windows.Forms.Timer(this.components);
            this.gSTotalUrgentsPerM = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblShifts = new System.Windows.Forms.Label();
            this.cmbShifts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTotalFinishedHead = new System.Windows.Forms.Label();
            this.lblTotalFinished = new System.Windows.Forms.Label();
            this.chTotal = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gradientPanel1 = new Urgent_Manager.CustomViews.GradientPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 141);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(720, 138);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Visible = false;
            // 
            // piechart
            // 
            this.piechart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.piechart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piechart.Location = new System.Drawing.Point(840, 91);
            this.piechart.Name = "piechart";
            this.piechart.Size = new System.Drawing.Size(248, 216);
            this.piechart.TabIndex = 1;
            this.piechart.Text = "Urgents / Areas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gSwitchMode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 50);
            this.panel1.TabIndex = 2;
            // 
            // gSwitchMode
            // 
            this.gSwitchMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.gSwitchMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gSwitchMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.gSwitchMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.gSwitchMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gSwitchMode.Location = new System.Drawing.Point(385, 16);
            this.gSwitchMode.Name = "gSwitchMode";
            this.gSwitchMode.Size = new System.Drawing.Size(43, 20);
            this.gSwitchMode.TabIndex = 3;
            this.gSwitchMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gSwitchMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gSwitchMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.gSwitchMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.gSwitchMode.CheckedChanged += new System.EventHandler(this.gSwitchMode_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(277, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Live Preview";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 50;
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
            this.btnRefresh.Location = new System.Drawing.Point(204, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRefresh.Size = new System.Drawing.Size(66, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urgent Statistics";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.guna2DateTimePicker1.BorderRadius = 15;
            this.guna2DateTimePicker1.BorderThickness = 1;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(38, 91);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(243, 36);
            this.guna2DateTimePicker1.TabIndex = 4;
            this.guna2DateTimePicker1.TextOffset = new System.Drawing.Point(20, 0);
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 7, 19, 14, 16, 57, 496);
            this.guna2DateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged_1);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartesianChart1.Location = new System.Drawing.Point(27, 394);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1094, 244);
            this.cartesianChart1.TabIndex = 6;
            this.cartesianChart1.Text = "Hourly Urgents";
            // 
            // cmbMachine
            // 
            this.cmbMachine.BackColor = System.Drawing.Color.Transparent;
            this.cmbMachine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbMachine.BorderRadius = 15;
            this.cmbMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMachine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbMachine.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMachine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMachine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMachine.ForeColor = System.Drawing.Color.White;
            this.cmbMachine.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbMachine.IntegralHeight = false;
            this.cmbMachine.ItemHeight = 30;
            this.cmbMachine.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbMachine.Location = new System.Drawing.Point(415, 328);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(115, 36);
            this.cmbMachine.TabIndex = 7;
            this.cmbMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbMachine.SelectedIndexChanged += new System.EventHandler(this.cmbMachine_SelectedIndexChanged_1);
            // 
            // cmbArea
            // 
            this.cmbArea.BackColor = System.Drawing.Color.Transparent;
            this.cmbArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbArea.BorderRadius = 15;
            this.cmbArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbArea.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbArea.ForeColor = System.Drawing.Color.White;
            this.cmbArea.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbArea.IntegralHeight = false;
            this.cmbArea.ItemHeight = 30;
            this.cmbArea.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbArea.Location = new System.Drawing.Point(594, 328);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(115, 36);
            this.cmbArea.TabIndex = 8;
            this.cmbArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged_1);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbStatus.BorderRadius = 15;
            this.cmbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.White;
            this.cmbStatus.IntegralHeight = false;
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Express",
            "Finished"});
            this.cmbStatus.Location = new System.Drawing.Point(413, 91);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(243, 36);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(320, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(329, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Machine : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(535, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Area : ";
            // 
            // livePreview
            // 
            this.livePreview.Interval = 10000;
            this.livePreview.Tick += new System.EventHandler(this.livePreview_Tick_1);
            // 
            // gSTotalUrgentsPerM
            // 
            this.gSTotalUrgentsPerM.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.gSTotalUrgentsPerM.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gSTotalUrgentsPerM.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.gSTotalUrgentsPerM.CheckedState.InnerColor = System.Drawing.Color.White;
            this.gSTotalUrgentsPerM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gSTotalUrgentsPerM.Location = new System.Drawing.Point(279, 336);
            this.gSTotalUrgentsPerM.Name = "gSTotalUrgentsPerM";
            this.gSTotalUrgentsPerM.Size = new System.Drawing.Size(43, 20);
            this.gSTotalUrgentsPerM.TabIndex = 15;
            this.gSTotalUrgentsPerM.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gSTotalUrgentsPerM.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gSTotalUrgentsPerM.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.gSTotalUrgentsPerM.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.gSTotalUrgentsPerM.CheckedChanged += new System.EventHandler(this.gSTotalUrgentsPerM_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(20, 337);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(256, 18);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Show Total Urgents Per Machine";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(27, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 244);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(338, 99);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(421, 29);
            this.lblMessage.TabIndex = 39;
            this.lblMessage.Text = "You Don\'t Have Any Data For Now";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // chart1
            // 
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))))};
            series1.BackImageTransparentColor = System.Drawing.Color.Black;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Express";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1108, 244);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.lblLoading.Location = new System.Drawing.Point(228, 291);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(362, 29);
            this.lblLoading.TabIndex = 13;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoading.Visible = false;
            // 
            // lblShifts
            // 
            this.lblShifts.AutoSize = true;
            this.lblShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShifts.ForeColor = System.Drawing.Color.White;
            this.lblShifts.Location = new System.Drawing.Point(713, 337);
            this.lblShifts.Name = "lblShifts";
            this.lblShifts.Size = new System.Drawing.Size(61, 18);
            this.lblShifts.TabIndex = 18;
            this.lblShifts.Text = "Shifts :";
            this.lblShifts.Visible = false;
            // 
            // cmbShifts
            // 
            this.cmbShifts.BackColor = System.Drawing.Color.Transparent;
            this.cmbShifts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbShifts.BorderRadius = 15;
            this.cmbShifts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbShifts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbShifts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShifts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbShifts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbShifts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbShifts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbShifts.ForeColor = System.Drawing.Color.White;
            this.cmbShifts.IntegralHeight = false;
            this.cmbShifts.ItemHeight = 30;
            this.cmbShifts.Items.AddRange(new object[] {
            "All",
            "Matin",
            "Soir",
            "Nuit"});
            this.cmbShifts.Location = new System.Drawing.Point(774, 328);
            this.cmbShifts.Name = "cmbShifts";
            this.cmbShifts.Size = new System.Drawing.Size(115, 36);
            this.cmbShifts.TabIndex = 17;
            this.cmbShifts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbShifts.Visible = false;
            this.cmbShifts.SelectedIndexChanged += new System.EventHandler(this.cmbShifts_SelectedIndexChanged);
            // 
            // lblTotalFinishedHead
            // 
            this.lblTotalFinishedHead.AutoSize = true;
            this.lblTotalFinishedHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFinishedHead.ForeColor = System.Drawing.Color.White;
            this.lblTotalFinishedHead.Location = new System.Drawing.Point(895, 337);
            this.lblTotalFinishedHead.Name = "lblTotalFinishedHead";
            this.lblTotalFinishedHead.Size = new System.Drawing.Size(61, 18);
            this.lblTotalFinishedHead.TabIndex = 19;
            this.lblTotalFinishedHead.Text = "Total : ";
            this.lblTotalFinishedHead.Visible = false;
            // 
            // lblTotalFinished
            // 
            this.lblTotalFinished.AutoSize = true;
            this.lblTotalFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFinished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.lblTotalFinished.Location = new System.Drawing.Point(956, 337);
            this.lblTotalFinished.Name = "lblTotalFinished";
            this.lblTotalFinished.Size = new System.Drawing.Size(17, 18);
            this.lblTotalFinished.TabIndex = 20;
            this.lblTotalFinished.Text = "0";
            this.lblTotalFinished.Visible = false;
            // 
            // chTotal
            // 
            this.chTotal.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.chTotal.CheckedState.BorderRadius = 2;
            this.chTotal.CheckedState.BorderThickness = 0;
            this.chTotal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chTotal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTotal.ForeColor = System.Drawing.Color.White;
            this.chTotal.Location = new System.Drawing.Point(27, 364);
            this.chTotal.Name = "chTotal";
            this.chTotal.Size = new System.Drawing.Size(130, 24);
            this.chTotal.TabIndex = 21;
            this.chTotal.Text = "Total Shift";
            this.chTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chTotal.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chTotal.UncheckedState.BorderRadius = 2;
            this.chTotal.UncheckedState.BorderThickness = 0;
            this.chTotal.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chTotal.Visible = false;
            this.chTotal.CheckedChanged += new System.EventHandler(this.chTotal_CheckedChanged);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 50);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1200, 2);
            this.gradientPanel1.TabIndex = 3;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1167, 650);
            this.Controls.Add(this.chTotal);
            this.Controls.Add(this.lblTotalFinished);
            this.Controls.Add(this.lblTotalFinishedHead);
            this.Controls.Add(this.lblShifts);
            this.Controls.Add(this.cmbShifts);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gSTotalUrgentsPerM);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.cmbMachine);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.piechart);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private LiveCharts.WinForms.PieChart piechart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomViews.GradientPanel gradientPanel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMachine;
        private Guna.UI2.WinForms.Guna2ComboBox cmbArea;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch gSwitchMode;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer livePreview;
        private Guna.UI2.WinForms.Guna2ToggleSwitch gSTotalUrgentsPerM;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblShifts;
        private Guna.UI2.WinForms.Guna2ComboBox cmbShifts;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTotalFinishedHead;
        private System.Windows.Forms.Label lblTotalFinished;
        private Guna.UI2.WinForms.Guna2CheckBox chTotal;
    }
}