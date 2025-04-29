namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIChild f = new MDIChild();
            f.MdiParent = this;
            f.Show();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiChild2 f = new MdiChild2();
            f.MdiParent = this;
            f.Show();
        }

        private void �������³��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is MdiChild2)
                {
                    child.Text += "- 2";

                }
            }
        }

        private void �������³��������������ToolStripMenuItem_Click(object sender, EventArgs e)
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
