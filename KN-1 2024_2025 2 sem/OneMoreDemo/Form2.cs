using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneMoreDemo
{
    public partial class Form2 : Form
    {
        private List<MyObject> myObjects;
        public Form2(List<MyObject> objects)
        {
            myObjects = objects;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(myObjects.ToArray());
        }
    }
}
