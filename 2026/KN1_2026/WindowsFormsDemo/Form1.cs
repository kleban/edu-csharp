namespace WindowsFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createColoredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm f = new ChildForm();
            f.MdiParent = this;
            f.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arranceIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void createReColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var f in Application.OpenForms)
            {
                if (f is ReColorForm)
                    return;
            }

            var rf = new ReColorForm();
            rf.MdiParent = this;
            rf.Show();
        }
    }
}
