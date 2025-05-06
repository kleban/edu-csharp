namespace PhotoDemo
{
    public partial class PlacesForm : Form
    {
        private PlaceManager placeManager;
        public PlacesForm()
        {
            InitializeComponent();
            placeManager = new PlaceManager();
        }

        private void PlacesForm_Load(object sender, EventArgs e)
        {
            updatePlaces();
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
            // Optionally, you can add the new image to the list
            string imgPath = Path.Combine("img", Path.GetFileName(labelPath.Text));
            var newPlace = new Place { 
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
    }
}
