using Guna.UI2.WinForms;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Controller;

namespace Urgent_Manager.View.DashBoard
{
    public partial class Statistics : Form
    {
        StatisticsController statisticsController = new StatisticsController();
        UrgentController urgentController = new UrgentController();
        System.Windows.Forms.DataVisualization.Charting.Series finished = new System.Windows.Forms.DataVisualization.Charting.Series();
        string status = "All";
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DefaultLegend customLegend = new DefaultLegend();
            customLegend.Foreground = System.Windows.Media.Brushes.White;
            cartesianChart1.DefaultLegend = customLegend;
            totalUrgentCount();
            urgentController.FillCombobox("Machine", "Machine", cmbMachine);
            urgentController.FillCombobox("Area", "ZoneName", cmbArea);
            cmbShifts.Text = getShift();
            chart();
            string[] hours = getShift() == "Matin" ? new string[] { "6", "7", "8", "9", "10", "11", "12", "13" } : getShift() == "Soir" ? new string[] { "14", "15", "16", "17", "18", "19", "20", "21" } : new string[] { "22", "23", "00", "1", "2", "3", "4", "5" };
            ChartValues<int> CurrentUrgent;
            ChartValues<int> FinishedUrgents;
            if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
            {
                string date     = Convert.ToDateTime(DateTime.Now).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
                CurrentUrgent   = statisticsController.getValues("Express", hours, false, date);
                FinishedUrgents = statisticsController.getValues("Finished", hours, true, date);
            }
            else
            {
                CurrentUrgent   = statisticsController.getValues("Express", hours, false, DateTime.Now.ToShortDateString());
                FinishedUrgents = statisticsController.getValues("Finished", hours, true, DateTime.Now.ToShortDateString());
            }
            HourlyChart(CurrentUrgent, FinishedUrgents);
            shiftHours();
        }

        private Guna2Panel card(string Name, int values, Color bk)
        {

            Guna2Panel p = new Guna2Panel();
            p.Size = new Size(220, 100);
            p.Margin = new Padding(5);
            p.BorderRadius = 8;
            p.FillColor = bk;
            Label title = new Label();
            title.ForeColor = Color.White;
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            title.Text = Name;
            title.BackColor = Color.Transparent;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Location = new Point(60, 5);
            title.Height = 40;
            Label value = new Label();
            value.ForeColor = Color.White;
            value.Width = 220;
            value.Font = new Font("Arial", 10);
            value.Text = bk == Color.FromArgb(255, 52, 206, 13) || bk == Color.FromArgb(255, 0,152,120) ? "Total Finished : " + values : "Total Express : "+values;
            value.BackColor = Color.Transparent;
            value.TextAlign = ContentAlignment.MiddleCenter;
            value.Location = new Point(0, 60);

            p.Controls.Add(title);
            p.Controls.Add(value);
            if (values > 0)
                p.Visible = true;
            else
                p.Visible = false;

            return p;
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        private void chart()
        {
            SeriesCollection series = new SeriesCollection();
            string date = Convert.ToDateTime(DateTime.Now).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
            series.Clear();
            ArrayList list = statisticsController.getAreas();
            foreach (string area in list)
            {
                if (cmbStatus.Text == "Finished")
                {
                    int expressCount = DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6 ? statisticsController.urgentCount(area, cmbStatus.Text, date) : statisticsController.urgentCount(area, cmbStatus.Text, DateTime.Now.ToShortDateString());
                    if (expressCount > 0)
                        series.Add(new PieSeries() { Title = area, Values = new ChartValues<int> { expressCount }, DataLabels = true, LabelPoint = labelPoint });
                }
                else
                {
                    int expressCount = statisticsController.urgentCount(area, cmbStatus.Text);
                    if (expressCount > 0)
                        series.Add(new PieSeries() { Title = area, Values = new ChartValues<int> { expressCount }, DataLabels = true, LabelPoint = labelPoint });
                }
            }

            piechart.DefaultLegend.Foreground = System.Windows.Media.Brushes.White;
            piechart.Series = series;
            piechart.LegendLocation = LegendLocation.Top;
        }

        private void chartWithDate(string date)
        {
            SeriesCollection series = new SeriesCollection();

            series.Clear();
            ArrayList list = statisticsController.getAreas();
            foreach (string area in list)
            {
                int expressCount = statisticsController.urgentCount(area, "Finished", date);
                if (expressCount > 0)
                    series.Add(new PieSeries() { Title = area, Values = new ChartValues<int> { expressCount }, DataLabels = true, LabelPoint = labelPoint });
            }

            piechart.DefaultLegend.Foreground = System.Windows.Media.Brushes.White;
            piechart.Series = series;
            piechart.LegendLocation = LegendLocation.Top;
        }

        private void HourlyChart(ChartValues<int> CurrentUrgent, ChartValues<int> FinishedUrgents)
        {
            cartesianChart1.Series.Clear();
            SeriesCollection series2 = new SeriesCollection()
            {

              new LineSeries
                {
                    Title = "Current Urgents",
                    Values = CurrentUrgent,
                    Stroke = System.Windows.Media.Brushes.Red
                },
                new LineSeries
                {
                    Title = "Finished Urgents",
                    Values = FinishedUrgents,
                    Stroke = System.Windows.Media.Brushes.Green
                }
            };

            cartesianChart1.Series = series2;
            cartesianChart1.LegendLocation = LegendLocation.Top;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CuttingAreaTotal = 0;
            if (chTotal.Checked)
            {
                chart1.Series.RemoveAt(1);
                totalUrgent();
            }
            else
            {
                totalUrgentCount();
            }
            if (cmbStatus.Text == "Finished")
            {
                chart();
                flowLayoutPanel1.Controls.Clear();
                ArrayList list = statisticsController.getAreas();
                string date = Convert.ToDateTime(DateTime.Now).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
                foreach (string area in list)
                {
                    int expressCount = DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6 ? statisticsController.urgentCount(area, cmbStatus.Text, date) : statisticsController.urgentCount(area, cmbStatus.Text, DateTime.Now.ToShortDateString());
                    CuttingAreaTotal += expressCount;
                    Guna2Panel p = card(area, expressCount, Color.FromArgb(255, 52, 206, 13));
                    flowLayoutPanel1.Controls.Add(p);
                }

                if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
                {
                    Guna2Panel p2 = card("Cutting Total", CuttingAreaTotal, Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p2);
                    Guna2Panel p1 = card("Production Line Total", statisticsController.leadPrepTotal("Cutting","Finished",true,date), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p1);
                    Guna2Panel p3 = card("Twist Total", statisticsController.leadPrepTotal("Twist", "Finished", true, date), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p3);
                    Guna2Panel p4 = card("LP Total", statisticsController.leadPrepTotal("LP", "Finished", true, date), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p4);
                }
                else
                {
                    Guna2Panel p2 = card("Cutting Total", CuttingAreaTotal, Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p2);
                    Guna2Panel p1 = card("Production Line Total", statisticsController.leadPrepTotal("Cutting", "Finished", true, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p1);
                    Guna2Panel p3 = card("Twist Total", statisticsController.leadPrepTotal("Twist", "Finished", true, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p3);
                    Guna2Panel p4 = card("LP Total", statisticsController.leadPrepTotal("LP", "Finished", true, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p4);
                }

            }
            else
            {
                chart();
                flowLayoutPanel1.Controls.Clear();
                ArrayList list = statisticsController.getAreas();
                foreach (string area in list)
                {
                    int expressCount = statisticsController.urgentCount(area, cmbStatus.Text);
                    CuttingAreaTotal += expressCount;
                    Guna2Panel p = card(area, expressCount, Color.FromArgb(255, 234, 79, 12));
                    flowLayoutPanel1.Controls.Add(p);
                }

                Guna2Panel p2 = card("Cutting Total", CuttingAreaTotal, Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p2);
                Guna2Panel p1 = card("Production Line Total", statisticsController.leadPrepTotal("Cutting", "Express", false, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p1);
                Guna2Panel p3 = card("Twist Total", statisticsController.leadPrepTotal("Twist", "Express", false, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p3);
                Guna2Panel p4 = card("LP Total", statisticsController.leadPrepTotal("LP", "Express", false, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p4);
            }
        }

        // get shift Hours

        private string getShift()
        {
            string shift = "";
            try
            {
                if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 14)
                {
                    return "Matin";
                }
                else if (DateTime.Now.Hour >= 14 && DateTime.Now.Hour < 22)
                {
                    return "Soir";
                }
                else
                {
                    return "Nuit";
                }
            }
            catch (Exception)
            {
                return shift;
            }
        }

        // Shift Hours

        private void shiftHours()
        {
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisX.Add(new Axis()
            {

                Title = "Shift Hours",
                Labels = getShift() == "Matin" ? new string[] { "6h", "7h", "8h", "9h", "10h", "11h", "12h", "13h" } : getShift() == "Soir" ? new string[] { "14h", "15h", "16h", "17h", "18h", "19h", "20h", "21h" } : new string[] { "22h", "23h", "00h", "1h", "2h", "3h", "4h", "5h" }

            });

            cartesianChart1.AxisY.Add(new Axis()
            {

                Title = "Urgents"

            });
        }

        private void livePreview_Tick_1(object sender, EventArgs e)
        {
            int CuttingAreaTotal = 0;
            if (chTotal.Checked)
            {
                chart1.Series.RemoveAt(1);
                totalUrgent();
            }
            else
            {
                totalUrgentCount();
            }
            shiftHours();
            chart();
            if (cmbStatus.Text == "Finished")
            {
                chart();
                flowLayoutPanel1.Controls.Clear();
                ArrayList list = statisticsController.getAreas();
                string date = Convert.ToDateTime(DateTime.Now).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
                foreach (string area in list)
                {
                    int expressCount = DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6 ? statisticsController.urgentCount(area, cmbStatus.Text, date) : statisticsController.urgentCount(area, cmbStatus.Text, DateTime.Now.ToShortDateString());
                    CuttingAreaTotal += expressCount;
                    Guna2Panel p = card(area, expressCount, Color.FromArgb(255, 52, 206, 13));
                    flowLayoutPanel1.Controls.Add(p);
                }

                if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
                {
                    Guna2Panel p2 = card("Cutting Total", CuttingAreaTotal, Color.FromArgb(255, 0, 152,120));
                    flowLayoutPanel1.Controls.Add(p2);
                    Guna2Panel p1 = card("Production Line Total", statisticsController.leadPrepTotal("Cutting", "Finished", true, date), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p1);
                    Guna2Panel p3 = card("Twist Total", statisticsController.leadPrepTotal("Twist", "Finished", true, date), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p3);
                    Guna2Panel p4 = card("LP Total", statisticsController.leadPrepTotal("LP", "Finished", true, date), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p4);
                }
                else
                {
                    Guna2Panel p2 = card("Cutting Total", CuttingAreaTotal, Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p2);
                    Guna2Panel p1 = card("Production Line Total", statisticsController.leadPrepTotal("Cutting", "Finished", true, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p1);
                    Guna2Panel p3 = card("Twist Total", statisticsController.leadPrepTotal("Twist", "Finished", true, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p3);
                    Guna2Panel p4 = card("LP Total", statisticsController.leadPrepTotal("LP", "Finished", true, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p4);
                }

            }
            else
            {
                chart();
                flowLayoutPanel1.Controls.Clear();
                ArrayList list = statisticsController.getAreas();
                foreach (string area in list)
                {
                    int expressCount = statisticsController.urgentCount(area, cmbStatus.Text);
                    CuttingAreaTotal += expressCount;
                    Guna2Panel p = card(area, expressCount, Color.FromArgb(255, 234, 79, 12));
                    flowLayoutPanel1.Controls.Add(p);
                }

                Guna2Panel p2 = card("Cutting Total", CuttingAreaTotal, Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p2);
                Guna2Panel p1 = card("Production Line Total", statisticsController.leadPrepTotal("Cutting", "Express", false, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p1);
                Guna2Panel p3 = card("Twist Total", statisticsController.leadPrepTotal("Twist", "Express", false, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p3);
                Guna2Panel p4 = card("LP Total", statisticsController.leadPrepTotal("LP", "Express", false, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p4);
            }
            string[] hours = getShift() == "Matin" ? new string[] { "6", "7", "8", "9", "10", "11", "12", "13" } : getShift() == "Soir" ? new string[] { "14", "15", "16", "17", "18", "19", "20", "21" } : new string[] { "22", "23", "00", "1", "2", "3", "4", "5" };

            if (status == "All")
            {
                ChartValues<int> CurrentUrgent;
                ChartValues<int> FinishedUrgents;
                if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
                {
                    string date = Convert.ToDateTime(DateTime.Now).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
                    CurrentUrgent = statisticsController.getValues("Express", hours, false, date);
                    FinishedUrgents = statisticsController.getValues("Finished", hours, true, date);
                }
                else
                {
                    CurrentUrgent = statisticsController.getValues("Express", hours, false, DateTime.Now.ToShortDateString());
                    FinishedUrgents = statisticsController.getValues("Finished", hours, true, DateTime.Now.ToShortDateString());
                }
                HourlyChart(CurrentUrgent, FinishedUrgents);
            }
            else if (status == "Machine")
            {
                ChartValues<int> CurrentUrgent;
                ChartValues<int> FinishedUrgents;
                if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
                {
                    string date = Convert.ToDateTime(DateTime.Now).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
                    CurrentUrgent = statisticsController.getValues(cmbMachine.Text, "Express", hours, false, date);
                    FinishedUrgents = statisticsController.getValues(cmbMachine.Text, "Finished", hours, true, date);
                }
                else
                {
                    CurrentUrgent = statisticsController.getValues(cmbMachine.Text, "Express", hours, false, DateTime.Now.ToShortDateString());
                    FinishedUrgents = statisticsController.getValues(cmbMachine.Text, "Finished", hours, true, DateTime.Now.ToShortDateString());
                }
                HourlyChart(CurrentUrgent, FinishedUrgents);
            }
            else if (status == "Area")
            {
                ChartValues<int> CurrentUrgent;
                ChartValues<int> FinishedUrgents;
                if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
                {
                    string date = Convert.ToDateTime(DateTime.Now).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
                    CurrentUrgent = statisticsController.getValuesPerArea(cmbArea.Text, "Express", hours, false,date);
                    FinishedUrgents = statisticsController.getValuesPerArea(cmbArea.Text, "Finished", hours, true, date);
                }
                else
                {
                    CurrentUrgent   =  statisticsController.getValuesPerArea(cmbArea.Text, "Express", hours, false, DateTime.Now.ToShortDateString());
                    FinishedUrgents = statisticsController.getValuesPerArea(cmbArea.Text, "Finished", hours, true, DateTime.Now.ToShortDateString());
                }
                HourlyChart(CurrentUrgent, FinishedUrgents);
            }
        }

        private void guna2DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (chTotal.Checked)
                {
                    chart1.Series.RemoveAt(1);
                    totalUrgent();
                }
                else
                {
                    totalUrgentCount();
                }
                int CuttingTotal = 0;
                cmbStatus.SelectedIndex = 1;
                chartWithDate(guna2DateTimePicker1.Value.ToShortDateString());
                flowLayoutPanel1.Controls.Clear();
                ArrayList list = statisticsController.getAreas();
                foreach (string area in list)
                {
                    int count = statisticsController.urgentCount(area, "Finished", guna2DateTimePicker1.Value.ToShortDateString());
                    CuttingTotal += count;
                    Guna2Panel p = card(area, count, Color.FromArgb(255, 52, 206, 13));
                    flowLayoutPanel1.Controls.Add(p);
                }
                Guna2Panel p2 = card("Cutting Total", CuttingTotal, Color.FromArgb(255, 0, 152, 120));
                flowLayoutPanel1.Controls.Add(p2);
                Guna2Panel p1 = card("Production Line Total", statisticsController.leadPrepTotal("Cutting", "Finished", true, guna2DateTimePicker1.Value.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                flowLayoutPanel1.Controls.Add(p1);
                Guna2Panel p3 = card("Twist Total", statisticsController.leadPrepTotal("Twist", "Finished", true, guna2DateTimePicker1.Value.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                flowLayoutPanel1.Controls.Add(p3);
                Guna2Panel p4 = card("LP Total", statisticsController.leadPrepTotal("LP", "Finished", true, guna2DateTimePicker1.Value.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                flowLayoutPanel1.Controls.Add(p4);

            }
            catch (Exception ex)
            {

            }
        }

        private void cmbMachine_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                status = "Machine";
                if (cmbMachine.Text != "")
                {
                    string[] hours = getShift() == "Matin" ? new string[] { "6", "7", "8", "9", "10", "11", "12", "13" } : getShift() == "Soir" ? new string[] { "14", "15", "16", "17", "18", "19", "20", "21" } : new string[] { "22", "23", "00", "1", "2", "3", "4", "5" };
                    ChartValues<int> CurrentUrgent;
                    ChartValues<int> FinishedUrgents;
                    if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
                    {
                        string date = Convert.ToDateTime(DateTime.Now).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
                        CurrentUrgent   = statisticsController.getValues(cmbMachine.Text, "Express", hours, false,date);
                        FinishedUrgents = statisticsController.getValues(cmbMachine.Text, "Finished", hours, true, date);
                    }
                    else
                    {
                        CurrentUrgent   = statisticsController.getValues(cmbMachine.Text, "Express", hours, false, DateTime.Now.ToShortDateString());
                        FinishedUrgents = statisticsController.getValues(cmbMachine.Text, "Finished", hours, true, DateTime.Now.ToShortDateString());
                    }
                    HourlyChart(CurrentUrgent, FinishedUrgents);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbArea_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                status = "Area";
                if (cmbArea.Text != "")
                {
                    string[] hours = getShift() == "Matin" ? new string[] { "6", "7", "8", "9", "10", "11", "12", "13" } : getShift() == "Soir" ? new string[] { "14", "15", "16", "17", "18", "19", "20", "21" } : new string[] { "22", "23", "00", "1", "2", "3", "4", "5" };
                    ChartValues<int> CurrentUrgent;
                    ChartValues<int> FinishedUrgents;
                    if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
                    {
                        string date = Convert.ToDateTime(DateTime.Now).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
                        CurrentUrgent   = statisticsController.getValuesPerArea(cmbArea.Text, "Express", hours, false,date);
                        FinishedUrgents = statisticsController.getValuesPerArea(cmbArea.Text, "Finished", hours, true, date);
                    }
                    else
                    {
                        CurrentUrgent   = statisticsController.getValuesPerArea(cmbArea.Text, "Express", hours, false, DateTime.Now.ToShortDateString());
                        FinishedUrgents = statisticsController.getValuesPerArea(cmbArea.Text, "Finished", hours, true, DateTime.Now.ToShortDateString());
                    }
                    HourlyChart(CurrentUrgent, FinishedUrgents);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            shiftHours();
            guna2DateTimePicker1.Value = DateTime.Now;
            if (chTotal.Checked)
            {
                chart1.Series.RemoveAt(1);
                totalUrgent();
            }
            else
            {
                totalUrgentCount();
            }
            cmbShifts.Text = getShift();
            int CuttingAreaTotal = 0;
            cmbMachine.SelectedIndex = -1;
            cmbArea.SelectedIndex = -1;
            status = "All";
            string date = Convert.ToDateTime(DateTime.Now).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
            if (cmbStatus.Text == "Express")
            {
                chart();
                string[] hours = getShift() == "Matin" ? new string[] { "6", "7", "8", "9", "10", "11", "12", "13" } : getShift() == "Soir" ? new string[] { "14", "15", "16", "17", "18", "19", "20", "21" } : new string[] { "22", "23", "00", "1", "2", "3", "4", "5" };
                ChartValues<int> CurrentUrgent;
                ChartValues<int> FinishedUrgents;
                if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
                {
                    CurrentUrgent   = statisticsController.getValues("Express", hours, false, date);
                    FinishedUrgents = statisticsController.getValues("Finished", hours, true, date);
                }
                else
                {
                    CurrentUrgent   = statisticsController.getValues("Express", hours, false, DateTime.Now.ToShortDateString());
                    FinishedUrgents = statisticsController.getValues("Finished", hours, true, DateTime.Now.ToShortDateString());
                }
                HourlyChart(CurrentUrgent, FinishedUrgents);
                flowLayoutPanel1.Controls.Clear();
                ArrayList list = statisticsController.getAreas();
                foreach (string area in list)
                {
                    int expressCount = statisticsController.urgentCount(area, cmbStatus.Text);
                    CuttingAreaTotal += expressCount;
                    Guna2Panel p = card(area, expressCount, Color.FromArgb(255, 234, 79, 12));
                    flowLayoutPanel1.Controls.Add(p);
                }

                Guna2Panel p2 = card("Cutting Total", CuttingAreaTotal, Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p2);
                Guna2Panel p1 = card("Production Line Total", statisticsController.leadPrepTotal("Cutting", "Express", false, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p1);
                Guna2Panel p3 = card("Twist Total", statisticsController.leadPrepTotal("Twist", "Express", false, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p3);
                Guna2Panel p4 = card("LP Total", statisticsController.leadPrepTotal("LP", "Express", false, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 255, 6, 6));
                flowLayoutPanel1.Controls.Add(p4);
            }
            else
            {
                chart();
                string[] hours = getShift() == "Matin" ? new string[] { "6", "7", "8", "9", "10", "11", "12", "13" } : getShift() == "Soir" ? new string[] { "14", "15", "16", "17", "18", "19", "20", "21" } : new string[] { "22", "23", "00", "1", "2", "3", "4", "5" };
                ChartValues<int> CurrentUrgent;
                ChartValues<int> FinishedUrgents;
                if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
                {
                    CurrentUrgent   = statisticsController.getValues("Express", hours, false,date);
                    FinishedUrgents = statisticsController.getValues("Finished", hours, true, date);
                }
                else
                {
                    CurrentUrgent   = statisticsController.getValues("Express", hours, false, DateTime.Now.ToShortDateString());
                    FinishedUrgents = statisticsController.getValues("Finished", hours, true, DateTime.Now.ToShortDateString());
                }
                HourlyChart(CurrentUrgent, FinishedUrgents);
                flowLayoutPanel1.Controls.Clear();
                ArrayList list = statisticsController.getAreas();
                foreach (string area in list)
                {
                    int expressCount = DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6 ? statisticsController.urgentCount(area, cmbStatus.Text, date) : statisticsController.urgentCount(area, cmbStatus.Text, DateTime.Now.ToShortDateString());
                    CuttingAreaTotal += expressCount;
                    Guna2Panel p = card(area, expressCount, Color.FromArgb(255, 52, 206, 13));
                    flowLayoutPanel1.Controls.Add(p);
                }

                if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
                {
                    Guna2Panel p2 = card("Cutting Total", CuttingAreaTotal, Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p2);
                    Guna2Panel p1 = card("Production Line Total", statisticsController.leadPrepTotal("Cutting", "Finished", true, date), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p1);
                    Guna2Panel p3 = card("Twist Total", statisticsController.leadPrepTotal("Twist", "Finished", true, date), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p3);
                    Guna2Panel p4 = card("LP Total", statisticsController.leadPrepTotal("LP", "Finished", true, date), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p4);
                }
                else
                {
                    Guna2Panel p2 = card("Cutting Total", CuttingAreaTotal, Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p2);
                    Guna2Panel p1 = card("Production Line Total", statisticsController.leadPrepTotal("Cutting", "Finished", true, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p1);
                    Guna2Panel p3 = card("Twist Total", statisticsController.leadPrepTotal("Twist", "Finished", true, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p3);
                    Guna2Panel p4 = card("LP Total", statisticsController.leadPrepTotal("LP", "Finished", true, DateTime.Now.ToShortDateString()), Color.FromArgb(255, 0, 152, 120));
                    flowLayoutPanel1.Controls.Add(p4);
                }
            }
        }

        private void gSwitchMode_CheckedChanged_1(object sender, EventArgs e)
        {
            if (gSwitchMode.Checked)
            {
                livePreview.Enabled = true;
                livePreview.Start();

            }
            else
            {
                livePreview.Stop();
                livePreview.Enabled = false;
            }
        }

        private void gSTotalUrgentsPerM_CheckedChanged(object sender, EventArgs e)
        {
            if (gSTotalUrgentsPerM.Checked)
            {
                lblTotal.Text = "Show Urgents Status Hourly";
                cartesianChart1.Visible = false;
                panel2.Visible = true;
                cmbMachine.Enabled = false;
                cmbArea.Enabled = false;
                cmbShifts.Visible = true;
                lblShifts.Visible = true;
                lblTotalFinishedHead.Visible = true;
                lblTotalFinished.Visible = true;
                chTotal.Visible = true;
            }
            else
            {
                lblTotal.Text = "Show Total Urgents Per Machine";
                cartesianChart1.Visible = true;
                panel2.Visible = false;
                cmbMachine.Enabled = true;
                cmbArea.Enabled = true;
                cmbShifts.Visible = false;
                lblShifts.Visible = false;
                lblTotalFinishedHead.Visible = false;
                lblTotalFinished.Visible = false;
                chTotal.Visible = false;
            }
        }

        private void totalUrgentCount()
        {
            try
            {
                chart1.Width = 1108;
                int totalCount = 0;
                chart1.Series["Express"].Points.Clear();
                chart1.BackColor = Color.FromArgb(255, 34, 34, 34);
                chart1.ChartAreas[0].AxisX.LineColor = Color.White;
                chart1.ChartAreas[0].AxisY.LineColor = Color.White;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
                chart1.ChartAreas[0].BackColor = Color.FromArgb(255, 34, 34, 34);
                chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisX.IsLabelAutoFit = true;

                if (cmbStatus.Text == "Express")
                {
                    chart1.Series["Express"].LegendText = "Express";
                    chart1.Series["Express"].Color = Color.Red;
                    ArrayList list = urgentController.machines("Express");

                    foreach (string machine in list)
                    {
                        int data = 0;
                        if (cmbShifts.Text == "All")
                        {
                             data = statisticsController.totalCount(machine,"",true,"");
                            totalCount += data;
                        }
                        else
                        {
                             data = statisticsController.totalCount(machine,cmbShifts.Text,false,guna2DateTimePicker1.Value.ToShortDateString());
                            totalCount += data;
                        }
                      
                        if(data > 0)
                        {
                            chart1.Series["Express"].Points.AddXY(machine, data);
                            chart1.Series["Express"].IsValueShownAsLabel = true;
                            chart1.Series["Express"].LabelBackColor = Color.White;
                            chart1.Series["Express"].LabelForeColor = Color.FromArgb(255, 34, 34, 34);
                            chart1.Series["Express"].Color = Color.Red;
                            chart1.ChartAreas[0].AxisX.Title = "Machines";
                            chart1.ChartAreas[0].AxisY.Title = "Total Urgents Per MC";
                            chart1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
                            chart1.ChartAreas[0].AxisY.TitleForeColor = Color.White;
                            if (list.Count > 20)
                                chart1.Width += 20;
                        }
                    }
                    lblTotalFinished.Text = totalCount.ToString();
                    lblTotalFinished.ForeColor = Color.Red;
                }
                else
                {
                    chart1.Series["Express"].LegendText = "Finished";
                    chart1.Series["Express"].Color = Color.FromArgb(255,0,152,120);
                    if (cmbShifts.Text != "")
                    {
                        ArrayList list = urgentController.machines("Finished");

                        foreach (string machine in list)
                        {
                            int data = statisticsController.totalCount(machine,cmbShifts.Text,guna2DateTimePicker1.Value.ToShortDateString());
                            totalCount += data;
                            if (data > 0)
                            {
                                chart1.Series["Express"].Points.AddXY(machine, data);
                                chart1.Series["Express"].IsValueShownAsLabel = true;
                                chart1.Series["Express"].LabelBackColor = Color.White;
                                chart1.Series["Express"].LabelForeColor = Color.FromArgb(255, 34, 34, 34);
                                chart1.ChartAreas[0].AxisX.Title = "Machines";
                                chart1.ChartAreas[0].AxisY.Title = "Total Finished Urgents Per Mc";
                                chart1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
                                chart1.ChartAreas[0].AxisY.TitleForeColor = Color.White;

                                if (list.Count > 20)
                                    chart1.Width += 20;
                            }
                        }
                        lblTotalFinished.Text = totalCount.ToString();
                        lblTotalFinished.ForeColor = Color.FromArgb(255,0,152,120);
                    }
                    else
                    {
                        ArrayList list = urgentController.machines("Finished");

                        foreach (string machine in list)
                        {
                            int data = statisticsController.totalCount(machine, getShift(), guna2DateTimePicker1.Value.ToShortDateString());
                            totalCount += data;
                            if (data > 0)
                            {
                                chart1.Series["Express"].Points.AddXY(machine, data);
                                chart1.Series["Express"].IsValueShownAsLabel = true;
                                chart1.Series["Express"].LabelBackColor = Color.White;
                                chart1.Series["Express"].LabelForeColor = Color.FromArgb(255, 34, 34, 34);
                                chart1.ChartAreas[0].AxisX.Title = "Machines";
                                chart1.ChartAreas[0].AxisY.Title = "Total Finished Urgents Per Mc";
                                chart1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
                                chart1.ChartAreas[0].AxisY.TitleForeColor = Color.White;

                                if (list.Count > 20)
                                    chart1.Width += 20;
                            }
                        }
                        lblTotalFinished.Text = totalCount.ToString();
                        lblTotalFinished.ForeColor = Color.FromArgb(255, 0, 152, 120);
                    }
                }

                if(chart1.Series["Express"].Points.Count <= 0)
                {
                    chart1.Visible = false;
                    lblMessage.Visible = true;
                }
                else
                {
                    chart1.Visible = true;
                    lblMessage.Visible = false;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Handling Your Request Try Latter!\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void totalUrgent()
        {
            try
            {
                chart1.Width = 1108;
                chart1.Series["Express"].Points.Clear();
                chart1.Series.Add("Finished");
                chart1.Series["Finished"].LegendText = "Finished";
                chart1.Series["Express"].Color = Color.Red;
                chart1.Series["Finished"].Color = Color.FromArgb(255, 0, 152, 120);
                chart1.BackColor = Color.FromArgb(255, 34, 34, 34);
                chart1.ChartAreas[0].AxisX.LineColor = Color.White;
                chart1.ChartAreas[0].AxisY.LineColor = Color.White;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
                chart1.ChartAreas[0].BackColor = Color.FromArgb(255, 34, 34, 34);
                chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                for (int i = 1;i < cmbShifts.Items.Count;i++)
                {
                    int totalUrgents = statisticsController.Total(guna2DateTimePicker1.Value.ToShortDateString(), cmbShifts.Items[i].ToString(), false);
                    int totalFinished = statisticsController.Total(guna2DateTimePicker1.Value.ToShortDateString(), cmbShifts.Items[i].ToString(), true);
                    if(totalUrgents > 0)
                    {
                        chart1.Series["Express"].Points.AddXY(cmbShifts.Items[i].ToString(), totalUrgents);
                        chart1.Series["Express"].IsValueShownAsLabel = true;
                        chart1.Series["Express"].LabelBackColor = Color.White;
                        chart1.Series["Express"].LabelForeColor = Color.FromArgb(255, 34, 34, 34);
                        chart1.ChartAreas[0].AxisX.Title = "Shifts";
                        chart1.ChartAreas[0].AxisY.Title = "Total";
                        chart1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
                        chart1.ChartAreas[0].AxisY.TitleForeColor = Color.White;
                    }

                    if (totalFinished > 0)
                    {
                        chart1.Series["Finished"].Points.AddXY(cmbShifts.Items[i].ToString(), totalFinished);
                        chart1.Series["Finished"].IsValueShownAsLabel = true;
                        chart1.Series["Finished"].LabelBackColor = Color.White;
                        chart1.Series["Finished"].LabelForeColor = Color.FromArgb(255, 34, 34, 34);
                        chart1.ChartAreas[0].AxisX.Title = "Shifts";
                        chart1.ChartAreas[0].AxisY.Title = "Total";
                        chart1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
                        chart1.ChartAreas[0].AxisY.TitleForeColor = Color.White;
                    }

                }
                if(chart1.Series["Express"].Points.Count == 0 && chart1.Series["Finished"].Points.Count == 0)
                {
                    lblMessage.Visible = true;
                    chart1.Visible = false;
                }
                else
                {
                    lblMessage.Visible = false;
                    chart1.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Handling Your Request Try Latter!\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            lblLoading.Location = new Point(228, 180);
            if(count == 3)
            {
                guna2DateTimePicker1.Value = DateTime.Now;
                cmbStatus.SelectedIndex = 0;
                flowLayoutPanel1.Visible = true;
                timer1.Stop();
                timer1.Enabled = false;
                lblLoading.Visible = false;
                lblLoading.Location = new Point(228, 291);
            }

            count++;
        }

        private void cmbShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chTotal.Checked)
            {
                chart1.Series.RemoveAt(1);
                totalUrgent();
            }
            else
            {
                totalUrgentCount();
            }
        }

        private void chTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (chTotal.Checked)
            {
                lblMessage.Visible = false;
                chart1.Visible = true;
                totalUrgent();
            }
            else
            {
                chart1.Series.RemoveAt(1);
                totalUrgentCount();
            }
        }
    }
}
