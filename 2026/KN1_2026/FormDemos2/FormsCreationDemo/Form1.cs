namespace FormsCreationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            DemoForm form = new DemoForm();
            form.Owner = this;
            form.Show();
        }
    }
}
