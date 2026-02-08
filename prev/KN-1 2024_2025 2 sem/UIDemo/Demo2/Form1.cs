namespace Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar.Value = progressBar1.Value = (int)numericUpDown.Value;
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown.Value = progressBar1.Value = trackBar.Value;
        }
    }
}
