using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtherWindows
{
    public partial class ChildForm : Form
    {
        public ChildForm(string title)
        {
            InitializeComponent();
            textBox1.Text = title;
        }

        public string Title
        {
            get { return textBox1.Text; }
        }

        public Product Product
        {
            get
            {
                return new Product
                {
                    Title = textBox1.Text
                };
            }
        }
    }
}
