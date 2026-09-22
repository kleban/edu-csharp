using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class ReColorForm : Form
    {
        public ReColorForm()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            foreach(var f in Application.OpenForms)
            {
                var form = f as ChildForm;// null //var form = (ChildForm)f;
                
                if(form is not null)
                {
                    form.ChangeBg();
                }
            }
        }
    }
}
