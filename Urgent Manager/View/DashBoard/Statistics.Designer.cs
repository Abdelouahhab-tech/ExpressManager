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
            this.gradientPanel1 = new Urgent_Manager.CustomViews.GradientPanel();
            this.panel1.SuspendLayout();
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
            // 
            // piechart
            // 
            this.piechart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.piechart.Location = new System.Drawing.Point(849, 91);
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
            this.panel1.Size = new System.Drawing.Size(1184, 50);
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
            this.cartesianChart1.Location = new System.Drawing.Point(27, 394);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1111, 244);
            this.cartesianChart1.TabIndex = 6;
            this.cartesianChart1.Text = "Hourly Urgents";
            // 
            // cmbMachine
            // 
            this.cmbMachine.BackColor = System.Drawing.Color.Transparent;
            this.cmbMachine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbMachine.BorderRadius = 15;
            this.cmbMachine.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbMachine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbMachine.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMachine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMachine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMachine.ForeColor = System.Drawing.Color.White;
            this.cmbMachine.IntegralHeight = false;
            this.cmbMachine.ItemHeight = 30;
            this.cmbMachine.Location = new System.Drawing.Point(123, 329);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(243, 36);
            this.cmbMachine.TabIndex = 7;
            this.cmbMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbMachine.SelectedIndexChanged += new System.EventHandler(this.cmbMachine_SelectedIndexChanged_1);
            // 
            // cmbArea
            // 
            this.cmbArea.BackColor = System.Drawing.Color.Transparent;
            this.cmbArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbArea.BorderRadius = 15;
            this.cmbArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbArea.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbArea.ForeColor = System.Drawing.Color.White;
            this.cmbArea.IntegralHeight = false;
            this.cmbArea.ItemHeight = 30;
            this.cmbArea.Location = new System.Drawing.Point(445, 329);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(243, 36);
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
            this.label3.Location = new System.Drawing.Point(30, 338);
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
            this.label5.Location = new System.Drawing.Point(382, 338);
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
            this.ClientSize = new System.Drawing.Size(1184, 650);
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
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}