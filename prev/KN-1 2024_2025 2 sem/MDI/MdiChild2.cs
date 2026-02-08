using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class MdiChild2 : Form
    {
        public MdiChild2()
        {
            InitializeComponent();
        }

        private void MdiChild2_Load(object sender, EventArgs e)
        {
            Random r = new Random();

            var date = new DateTime(r.Next(2000, 2025), r.Next(1, 13), r.Next(1, 29));
            this.Text = date.ToString("d");
            monthCalendar1.SelectionRange = new SelectionRange(date, date);
        }
    }
}
