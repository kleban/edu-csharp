using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class ColoredWindow : Form
    {
        private Random rnd = new Random();
        public ColoredWindow()
        {
            InitializeComponent();
            ChangeColor();
            ChangeLocation();
        }

        public void ChangeColor()
        {
            this.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        public void ChangeLocation()
        {
            var height = Screen.PrimaryScreen.Bounds.Height;
            var width = Screen.PrimaryScreen.Bounds.Width;

            label1.Text = $"{height}x{width}";

            this.Location = new Point(rnd.Next(0, width - this.Width), rnd.Next(0, height - this.Height));
            label1.Text = $"{this.Location.X}x{this.Location.Y}";
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void ColoredWindow_Move(object sender, EventArgs e)
        {
            label1.Text = $"Moved: {this.Location.X}x{this.Location.Y}";
        }
    }
}
