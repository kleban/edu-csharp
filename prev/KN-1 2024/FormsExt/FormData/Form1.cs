namespace FormData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            var form = new NewEventForm(dateTimePickerMaxEventDate.Value);

            if(form.ShowDialog() == DialogResult.OK)
            {
                listBoxEvents.Items.Add(form.NewEvent);
            }
        }
    }
}
