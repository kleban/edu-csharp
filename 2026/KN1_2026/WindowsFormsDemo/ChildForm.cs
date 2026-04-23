using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class ChildForm : Form
    {

        public ChildForm()
        {
            InitializeComponent();
            ChangeBg();
        }

        public void ChangeBg()
        {
            var r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }
    }
}
