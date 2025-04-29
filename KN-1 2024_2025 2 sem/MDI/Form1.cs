namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void íîâåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIChild f = new MDIChild();
            f.MdiParent = this;
            f.Show();
        }

        private void êàñêàäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ãîğèçîíòàëüíîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void âåğòèêàëüíîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void íîâåÇÊàëåíäàğåìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiChild2 f = new MdiChild2();
            f.MdiParent = this;
            f.Show();
        }

        private void îíîâèòèÂ³êíàÇÊàëåíäàğåìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is MdiChild2)
                {
                    child.Text += "- 2";

                }
            }
        }

        private void çàêğèòèÂ³êíàÇÊàëåíäàğåìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is MdiChild2)
                {
                    child.Close();

                }
            }
        }
    }
}
