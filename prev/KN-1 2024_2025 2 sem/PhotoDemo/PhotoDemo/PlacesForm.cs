using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PhotoDemo
{
    public partial class PlacesForm : Form
    {
        private PlaceManager placeManager;
        private Image gifImage;
        private int currentFrame = 0;
        private int frameCount;
        public PlacesForm()
        {
            InitializeComponent();
            placeManager = new PlaceManager();
        }

        private void PlacesForm_Load(object sender, EventArgs e)
        {          
            gifImage = Image.FromFile("img/giphy.gif");
            frameCount = gifImage.GetFrameCount(FrameDimension.Time);
            getNextFrame();
            updatePlaces();            
        }
        private void getNextFrame()
        {
            currentFrame = (currentFrame + 1) % frameCount;
            gifImage.SelectActiveFrame(FrameDimension.Time, currentFrame);
            
            pictureBox2.Image = gifImage;
            currentFrame = (currentFrame + 1) % frameCount;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var place = listBox1.SelectedItem as Place;
                if (place != null)
                {
                    pictureBox1.ImageLocation = place.ImagePath;
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                labelPath.Text = selectedImagePath;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string imgPath = Path.Combine("img", Path.GetFileName(labelPath.Text));

            var newPlace = new Place
            {
                Title = textBoxTitle.Text,
                ImagePath = imgPath
            };

            File.Copy(labelPath.Text, imgPath, true);

            placeManager.AddPlace(newPlace);
            updatePlaces();
        }

        private void updatePlaces()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(placeManager.GetPlaces().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
