namespace WinForm1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonClickMe.BackColor = Color.FromArgb(255, 0, 0, 255);

        }

        private void buttonClickMe_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);

            this.BackColor = Color.FromArgb(red, green, blue);
            button2.Visible = !button2.Visible;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonClickMe.Text = textBox1.Text;
        }
    }
}
