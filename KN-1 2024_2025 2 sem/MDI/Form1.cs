namespace MDI
{
    public partial class Form1 : Form
    {
        private List<string> images = new List<string>()
        {
            "https://images.unsplash.com/photo-1728044849236-5e8a061e1895",
            "https://images.unsplash.com/photo-1745794621090-d856c53b0cc2",
            "https://plus.unsplash.com/premium_photo-1720744786849-a7412d24ffbf",
            "https://images.unsplash.com/photo-1745666890553-68a1098c51ae",
            "https://images.unsplash.com/photo-1733503711060-1df31554390f",
            "https://images.unsplash.com/photo-1745594618508-6e3abfce30ef"
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
            MDI3 f = new MDI3(images[new Random().Next(images.Count)]);
            f.MdiParent = this;
            f.Show();
        }
    }
}
