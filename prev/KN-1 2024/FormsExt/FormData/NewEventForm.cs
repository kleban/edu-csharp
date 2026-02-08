using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormData
{
    public partial class NewEventForm : Form
    {
        public NewEventForm(DateTime maxDate)
        {
            InitializeComponent();
            dateTimePicker.MaxDate = maxDate;
        }

        public Event NewEvent { get; set; }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewEvent = new Event { Date = dateTimePicker.Value, Title = textBoxTitle.Text };
        }
    }
}
