namespace ComponentsDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value = (int)numericUpDown1.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = progressBar1.Value = trackBar1.Value;
        }

        private void buttonChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if(DialogResult.OK == ofd.ShowDialog())
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
