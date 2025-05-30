namespace ScrollDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)numericUpDown1.Value;
            trackBar1.Value = value;
            progressBar1.Value = value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            numericUpDown1.Value = value;
            progressBar1.Value = value;
        }
    }
}
