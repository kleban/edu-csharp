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

            comboBoxChartType.Items.Add(SeriesChartType.Area);
            comboBoxChartType.Items.Add(SeriesChartType.Bar);
            comboBoxChartType.Items.Add(SeriesChartType.Column);
            comboBoxChartType.Items.Add(SeriesChartType.Line);
            comboBoxChartType.Items.Add(SeriesChartType.Point);
            comboBoxChartType.SelectedIndex = 0;
        }

        private void Chart1Form_Load(object sender, EventArgs e)
        {
            chart1.Series.Add("sales");
            foreach (var item in ChartDataService.GetSales(items))
            {
                chart1.Series["sales"].Points.AddXY(item.Key, item.Value);
            }
        }

        private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chart1.Series.Any())
                chart1.Series["sales"].ChartType = (SeriesChartType)comboBoxChartType.SelectedItem;
        }
    }
}
