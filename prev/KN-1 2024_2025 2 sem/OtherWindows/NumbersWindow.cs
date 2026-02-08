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
    public partial class NumbersWindow : Form
    {
        private List<int> numbers = new List<int>();
        public NumbersWindow()
        {
            InitializeComponent();
        }

        void updateList()
        {
            listBox1.Items.Clear();
            foreach (int number in numbers)
            {
                listBox1.Items.Add(number);
            }
        }

        Random r = new Random();

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            numbers.Add(r.Next(1, 100));
            updateList();
        }

        public List<int> GetNumbers()
        {
            return numbers;
        }
    }
}
