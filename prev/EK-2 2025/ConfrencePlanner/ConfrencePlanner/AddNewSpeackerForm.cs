using ConfrencePlanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfrencePlanner
{
    public partial class AddNewSpeackerForm : Form
    {
        private List<Position> _positions;

        public Speaker Speaker { get; set; } = new Speaker();

        public AddNewSpeackerForm(List<Position> positions)
        {
            InitializeComponent();
            _positions = positions;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void AddNewSpeackerForm_Load(object sender, EventArgs e)
        {
            comboBoxPosition.Items.Clear();
            foreach (var p in _positions)
            {
                comboBoxPosition.Items.Add(p);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //check data

            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (comboBoxPosition.SelectedItem == null)
            {
                MessageBox.Show("Please select a position.");
                return;
            }

            Speaker.FullName = textBoxName.Text;
            Speaker.Position = (Position)comboBoxPosition.SelectedItem;
            Speaker.Org = textBoxOrg.Text;
            Speaker.Email = textBoxEmail.Text;
        }
    }
}
