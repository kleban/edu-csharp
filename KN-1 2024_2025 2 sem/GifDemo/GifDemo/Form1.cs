using System.Drawing.Imaging;

namespace GifDemo
{
    public partial class Form1 : Form
    {
        private Image gifImage;
        private int currentFrame = 0;
        private int frameCount;

        public Form1()
        {
            InitializeComponent();
            // Load your GIF
            gifImage = Image.FromFile("giphy.gif");
            frameCount = gifImage.GetFrameCount(FrameDimension.Time);

            // PictureBox setup
            pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill,
                Image = (Image)gifImage.Clone()
            };

            // Button to change frame
            nextFrameButton = new Button
            {
                Text = "Next Frame",
                Dock = DockStyle.Bottom
            };
            nextFrameButton.Click += ShowNextFrame;

            Controls.Add(pictureBox);
            Controls.Add(nextFrameButton);
        }

        private void ShowNextFrame(object sender, EventArgs e)
        {
            currentFrame = (currentFrame + 1) % frameCount;
            gifImage.SelectActiveFrame(FrameDimension.Time, currentFrame);
            pictureBox.Image = (Image)gifImage.Clone(); // Force refresh
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
