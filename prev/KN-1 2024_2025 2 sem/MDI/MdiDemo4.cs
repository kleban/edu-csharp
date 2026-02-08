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
    public partial class MdiDemo4 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public MdiDemo4()
        {
            InitializeComponent();
            this.timer.Interval = new Random().Next(500, 3000);
            this.timer.Tick += new EventHandler(this.timer_Tick);
            
        }

        private int counter = 0;

        private void timer_Tick(object? sender, EventArgs e)
        {
            counter += new Random().Next(1, 10);
            if(counter > 100) 
                counter = 0;
            progressBar1.Value = counter;
        }

        private void MdiDemo4_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
        }
    }
}
