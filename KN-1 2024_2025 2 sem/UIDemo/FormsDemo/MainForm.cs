namespace FormsDemo
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer t;
        public MainForm()
        {
            InitializeComponent();
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += T_Tick;

        }

        private void T_Tick(object? sender, EventArgs e)
        {
            button4_Click(null, null);
            button3_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm f = new ChildForm();
            f.SpecText = new Random().Next(10000).ToString();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var f in Application.OpenForms)
            {
                if (f is ChildForm)
                {
                    var form = f as ChildForm;
                    form.ChangePosition();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var f in Application.OpenForms)
            {
                if (f is ChildForm)
                {
                    var form = f as ChildForm;
                    form.ChangeColor();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                button1_Click(null, null);
        }

        private void buttonStartTimer_Click(object sender, EventArgs e)
        {
            t.Enabled = true;
            t.Start();
        }
    }
}
