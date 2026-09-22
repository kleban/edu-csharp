using System.Globalization;

namespace CalcDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(300, 25);
            btn.BackColor = SystemColors.ControlDark;
            btn.Location = new Point(0, 0);
            btn.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss", new CultureInfo("uk-UA"));
            this.Controls.Add(btn);
        }

        private void ButtonWithNumber_Click(object sender, EventArgs e)
        {
           Button btn = (Button)sender;
            label1.Text += btn.Text + " ";
        }
    }
}
