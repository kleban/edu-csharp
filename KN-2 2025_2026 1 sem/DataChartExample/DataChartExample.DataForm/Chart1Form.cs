using DataChartExample.Domain;
using DataChartExample.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataChartExample.DataForm
{
    public partial class Chart1Form : Form
    {
        private List<CoffeDataItem> items;
        public Chart1Form(List<CoffeDataItem> items)
        {
            InitializeComponent();
            this.items = items;

            comboBoxChartType.Items.Add(SeriesChartType.Column);
            comboBoxChartType.Items.Add(SeriesChartType.Bar);
            comboBoxChartType.Items.Add(SeriesChartType.Area);
            comboBoxChartType.Items.Add(SeriesChartType.Line);
            comboBoxChartType.Items.Add(SeriesChartType.Point);
            comboBoxChartType.SelectedIndex = 0;
        }

        private void Chart1Form_Load(object sender, EventArgs e)
        {
            var r = new Random();
            chart1.Series.Add("sales");
            chart1.Series.Add("sales_rand");

            var sales = ChartDataService.GetSales(items);

            foreach (var item in sales)
            {
                chart1.Series["sales"].Points.AddXY(item.Key, item.Value);

                chart1.Series["sales_rand"].Points.AddXY(item.Key,
                    item.Value - r.Next((int)sales.Min(x => x.Value), (int)sales.Max(x => x.Value)));

            }
            chart1.Series["sales"].ChartType = SeriesChartType.Column;
            //chart1.Series["sales_rand"].ChartType = SeriesChartType.Line;
        }

        private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chart1.Series.Any())
                chart1.Series["sales"].ChartType = chart1.Series["sales_rand"].ChartType = (SeriesChartType)comboBoxChartType.SelectedItem;
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            chart1.SaveImage("img.png", ChartImageFormat.Png);
        }
    }
}
