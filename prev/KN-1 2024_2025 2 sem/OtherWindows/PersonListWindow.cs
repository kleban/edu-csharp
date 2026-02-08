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
    public partial class PersonListWindow : Form
    {
        private List<Person> people;
        public PersonListWindow(int count = 0)
        {
            InitializeComponent();
            people = new List<Person>();

            for (int i = 0; i < count; ++i)
            {
                buttonAdd_Click(null, null);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            people.Add(new Person
            {
                Name = "Person_" + (people.Count + 1),
                Age = new Random().Next(18, 100)
            });
            listBoxPersons.Items.Clear();
            listBoxPersons.Items.AddRange(people.ToArray());
        }
        public List<Person> GetPeople()
        {
            return people;
        }

        private void PersonListWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
