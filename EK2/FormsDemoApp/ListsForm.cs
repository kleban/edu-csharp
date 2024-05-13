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
            listBoxLocalities.Items.AddRange(_localities.ToArray());
            comboBoxLocalities.Items.AddRange(_localities.ToArray());
            comboBoxLocalities.SelectedIndex = 0;
        }

        private void listBoxLocalities_SelectedIndexChanged(object sender, EventArgs e)
        {
            Locality locality = new();

            if (sender is ListBox)
            {
                var senderList = sender as ListBox;
                if (listBoxLocalities.SelectedIndex != -1)
                {
                    /* var index = listBoxLocalities.SelectedIndex;
                     var locality = listBoxLocalities.Items[index] as Locality;*/

                    locality = senderList.SelectedItem as Locality;
                }
            }
            else if (sender is ComboBox)
                locality = comboBoxLocalities.SelectedItem as Locality;


            labelLocality.Text = locality.Info;
        }

        private void buttonShowHidePanel_Click(object sender, EventArgs e)
        {
            panel.Visible = !panel.Visible;
            buttonShowHidePanel.Text = panel.Visible ? "Hide Panel" : "Show Panel";
        }
    }
}
