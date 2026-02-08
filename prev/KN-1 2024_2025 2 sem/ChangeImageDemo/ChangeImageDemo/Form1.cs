namespace ChangeImageDemo
{
    public partial class Form1 : Form
    {
        public List<Hero> Heroes { get; set; } = new List<Hero>
        {
            new Hero { Name = "Green", ImageUrl = "img\\GreenWizard.png" },
            new Hero { Name = "Yellow", ImageUrl =  "img\\YellowWizard.png" },
            new Hero { Name = "Red", ImageUrl =  "img\\RedWizard.png" }
        };

        private int Selectedndex { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatePicture();
        }

        void updatePicture()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            pictureBox1.Image = Image.FromFile(Heroes[Selectedndex].ImageUrl);


            buttonPrev.Enabled = Selectedndex > 0;
            buttonNext.Enabled = Selectedndex < Heroes.Count - 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Selectedndex++;
            updatePicture();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            Selectedndex--;
            updatePicture();
        }
    }
}
