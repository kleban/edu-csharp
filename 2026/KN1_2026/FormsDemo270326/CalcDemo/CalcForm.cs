namespace CalcDemo
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        public void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtA.Text))
            {
                MessageBox.Show("Введи число у 1-ше тектове поле",
                    "Помилка введення",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtB.Text))
            {
                MessageBox.Show("Введи число у 2-ше тектове поле",
                    "Помилка введення",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            labelResult.Text = $"Результат: {a + b}";
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            comboColors.Items.Add("Жовтий");
            comboColors.Items.Add("Білий");
            comboColors.Items.Add("Червоний");
            comboColors.SelectedIndex = 0;
            changeColor();
        }

        void changeColor()
        {
            var selectedColor = comboColors.SelectedItem.ToString();
            switch (selectedColor)
            {
                case "Червоний":
                    this.BackColor = Color.MediumVioletRed;
                    break;
                case "Жовтий":
                    this.BackColor = Color.Yellow;
                    break;
                case "Білий":
                    this.BackColor = Color.WhiteSmoke;
                    break;
            }
        }

        private void comboColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeColor();
        }
    }
}
