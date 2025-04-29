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
    public partial class MDIChild : Form
    {
        public MDIChild()
        {
            InitializeComponent();
        }

        Random r = new Random();
        private void MDIChild_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }
    }
}
