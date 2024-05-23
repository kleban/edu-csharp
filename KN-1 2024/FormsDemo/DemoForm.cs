using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDemo
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
            GetLocation();
        }

        void GetLocation()
        {
            var x = this.Location.X;
            var y = this.Location.Y;
            label1.Text = $"{x}x{y}";
        }
        private Random r = new Random();
        public void MoveRandom()
        {
            var x = this.MdiParent.Width - this.Width;
            var y = this.MdiParent.Height - this.Height;
            this.Location = new Point(r.Next(0, x), r.Next(0, y));
        }

        private void DemoForm_Move(object sender, EventArgs e)
        {
            GetLocation();
        }

        private void DemoForm_MouseHover(object sender, EventArgs e)
        {
            MoveRandom();
        }
    }
}
