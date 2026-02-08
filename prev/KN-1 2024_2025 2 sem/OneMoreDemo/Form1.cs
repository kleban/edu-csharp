namespace OneMoreDemo
{
    public partial class Form1 : Form
    {
        private List<MyObject> _objects = new List<MyObject>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                _objects.Add(new MyObject { Name = $"Object {i + 1}" });
            }
            listBox1.Items.AddRange(_objects.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_objects);
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _objects.Add(new MyObject { Name = $"Object {new Random().Next(0,100)}" });
            listBox1.Items.Clear();
            listBox1.Items.AddRange(_objects.ToArray());
        }
    }
}
