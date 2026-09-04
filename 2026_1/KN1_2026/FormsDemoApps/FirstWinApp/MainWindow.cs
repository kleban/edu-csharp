namespace FirstWinApp
{
    public partial class MainWindow : Form
    {
        private Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeColor();
            button1.Text = textBox1.Text;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        void changeColor()
        {
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);

            button1.BackColor = Color.FromArgb(r, g, b);
        }

        private void button1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            changeLocation();
        }

        void changeLocation()
        {
            int x = this.Location.X + random.Next(50, 100) * (random.Next() % 2 == 0 ? -1 : 1);
            int y = this.Location.Y + random.Next(50, 100) * (random.Next() % 2 == 0 ? -1 : 1);
            this.Location = new Point(x, y);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            changeLocation();
            changeColor();
        }
    }
}
