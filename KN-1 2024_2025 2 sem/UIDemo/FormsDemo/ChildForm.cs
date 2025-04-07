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
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
            ChangePosition();
            ChangeColor();
        }

        public void ChangePosition()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, Screen.PrimaryScreen.WorkingArea.Width - this.Width);
            int y = rnd.Next(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            this.Location = new Point(x, y);
        }

        public void ChangeColor()
        {
            Random rnd = new Random();
            int a = rnd.Next(256);
            int b = rnd.Next(256);
            int c = rnd.Next(256);
            this.BackColor = Color.FromArgb(a, b, c);
        }
        private string sptext = "";
        public string SpecText
        {
            get { return sptext; }
            set
            {
                sptext = value;
                label1.Text = sptext;
            }
        }
    }
}
