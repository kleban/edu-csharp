using DataReadWrite.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataReadWrite.MultyWindow
{
    public partial class Form2 : Form
    {
        private readonly IBookReaderWriter manager;
        private readonly string path;
        public Form2(IBookReaderWriter manager, string path)
        {
            InitializeComponent();
            this.manager = manager;
            this.path = path;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(manager.Read(path)
                .Select(x => $"{x.Id}. {x.Title}").ToArray());

           
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //check
            this.Close();
        }
    }
}
