namespace OtherWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm("Назва чогось там");
            var result = childForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                string title = childForm.Title;
                MessageBox.Show($"Відкрито: {title}");

                label1.Text = $"{childForm.Product.Title} - ${Math.Round(childForm.Product.Price)}";
            }
            else
            {
                MessageBox.Show("Діалог закрито без збереження.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNumbersWindow_Click(object sender, EventArgs e)
        {
            NumbersWindow numbersWindow = new NumbersWindow();
            var res = numbersWindow.ShowDialog();

            if (res == DialogResult.OK)
            {
                var numbers = numbersWindow.GetNumbers();
                listBoxNumbers.Items.Clear();
                foreach (var number in numbers)
                {
                    listBoxNumbers.Items.Add(number);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonListWindow form = new PersonListWindow(4);
            var res = form.ShowDialog();

            if(res == DialogResult.OK)
            {
                var data = form.GetPeople();
                _dg.DataSource = data;
            } 
            else
            {
                MessageBox.Show("Діалог закрито без збереження.");
            }
        }
    }
}
