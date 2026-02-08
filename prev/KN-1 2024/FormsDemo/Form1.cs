namespace FormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemoForm form = new DemoForm();
            form.MdiParent = this;
            form.Show();
        }

        private void reorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is DemoForm)
                {
                    DemoForm form = (DemoForm)f;
                    form.MoveRandom();
                }
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
