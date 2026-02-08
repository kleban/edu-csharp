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
    public partial class MDI3 : Form
    {
        private string path;
        public MDI3(string path)
        {
            InitializeComponent();
            this.path = path;
        }

         private void MDI3_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Load(path);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Text = path;
            
        }
    }
}
