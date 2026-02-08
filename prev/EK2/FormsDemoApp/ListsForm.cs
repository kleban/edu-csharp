using FormsDemoApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDemoApp
{
    public partial class ListsForm : Form
    {
        public ListsForm()
        {
            InitializeComponent();
        }

        List<Locality> _localities = new List<Locality>()
        {
            new Locality {Id = 1, Name = "Острог"},
            new Locality {Id = 2, Name = "Плоска"},
            new Locality {Id = 3, Name = "Верхів"},
            new Locality {Id = 4, Name = "Грозів"},
            new Locality {Id = 5, Name = "Нетішин"},
            new Locality {Id = 6, Name = "Здолбунів"}
        };

        private void ListsForm_Load(object sender, EventArgs e)
        {
            updateDataOnForm();
        }

        void updateDataOnForm()
        {
            listBoxLocalities.Items.Clear();
            listBoxLocalities.Items.AddRange(_localities.ToArray());

            comboBoxLocalities.Items.Clear();
            comboBoxLocalities.Items.AddRange(_localities.ToArray());
            comboBoxLocalities.SelectedIndex = 0;
        }

        private void listBoxLocalities_SelectedIndexChanged(object sender, EventArgs e)
        {
            Locality locality = new();

            if (sender is ListBox)
            {
                var senderList = sender as ListBox;
                buttonDeleteItem.Enabled = listBoxLocalities.SelectedIndex != -1;
                if (listBoxLocalities.SelectedIndex != -1)
                {

                    locality = senderList.SelectedItem as Locality;
                }
            }
            else if (sender is ComboBox)
                locality = comboBoxLocalities.SelectedItem as Locality;


            labelLocality.Text = locality.Info;
        }

        private void buttonShowBlock_Click(object sender, EventArgs e)
        {
            groupBoxNewLocality.Visible = !groupBoxNewLocality.Visible;

            buttonShowBlock.Text = groupBoxNewLocality.Visible ?
                "Сховати блок" :
                "Хочу додати населений пункт";
        }

        private void buttonSaveLocality_Click(object sender, EventArgs e)
        {
            //check - string empty
            if (string.IsNullOrEmpty(textBoxLocalityName.Text))
            {
                MessageBox.Show("Введіть назву населеного пункту",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var name = textBoxLocalityName.Text.Trim();

            //check - locality exists
            if (_localities.Any(x => x.Name.ToLower() == name.ToLower()))
            {
                MessageBox.Show("Населений пункт уже присутній у БД",
                   "Помилка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }

            _localities.Add(new Locality
            {
                Id = _localities.Max(x => x.Id) + 1,
                Name = name,
            });
            updateDataOnForm();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            var locality = listBoxLocalities.SelectedItem as Locality;
            _localities.Remove(locality);
            updateDataOnForm();
        }
    }
}
