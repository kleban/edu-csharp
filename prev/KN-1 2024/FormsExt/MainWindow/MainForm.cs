namespace MainWindow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createColoredWindow(new Random().Next(2, 5));
        }

        void createColoredWindow(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                ColoredWindow win = new ColoredWindow();
                win.MdiParent = this;
                win.Show();
            }
        }

        private void moveChangeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is ColoredWindow)
                {
                    ColoredWindow win = (ColoredWindow)f;
                    win.ChangeColor();
                    win.ChangeLocation();
                }
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}
