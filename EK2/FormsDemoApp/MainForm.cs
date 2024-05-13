namespace FormsDemoApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int clicks = 0;

        private void buttonOpenListsForm_Click(object sender, EventArgs e)
        {
            ListsForm form = new ListsForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button b = sender as Button; //null

            button1.Text = $"Click Me! ({++clicks})";
            textBoxDemo.Text += clicks;
        }

        private void buttonReadTextBox_Click(object sender, EventArgs e)
        {
            linkLabelText.Text = textBoxDemo.Text;
        }

        private void buttonAddNewLine_Click(object sender, EventArgs e)
        {
            var r = new Random();
            textArea.Text += $"Demo text {r.Next()}\r\n";
        }

        private void numericUpDownProgress_ValueChanged(object sender, EventArgs e)
        {
            progressBar.Value = trackBarProgress.Value = (int)numericUpDownProgress.Value;
        }

        private void trackBarProgress_Scroll(object sender, EventArgs e)
        {
            numericUpDownProgress.Value = progressBar.Value = trackBarProgress.Value;
        }
    }
}
