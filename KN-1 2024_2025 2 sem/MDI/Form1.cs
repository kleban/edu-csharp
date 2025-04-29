namespace MDI
{
    public partial class Form1 : Form
    {
        private List<string> images = new List<string>()
        {
            "https://images.unsplash.com/photo-1728044849236-5e8a061e1895",
            "https://unsplash.com/photos/modern-dining-room-with-table-chairs-and-kitchen-urH155LONWs",
            "3.jpg",
            "4.jpg",
            "5.jpg",
            "6.jpg",
            "7.jpg",
            "8.jpg",
            "9.jpg",
            "10.jpg"
        };
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void íîâåÂ³êíîÇÇîáğàæåííÿìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI3 f = new MDI3(images[0]);
            f.MdiParent = this;
            f.Show();
        }
    }
}
