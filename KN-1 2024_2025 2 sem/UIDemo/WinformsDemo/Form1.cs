namespace WinformsDemo
{
    public partial class Form1 : Form
    {
        bool firstLoad = true;
        public Form1()
        {
            InitializeComponent();
            comboBoxOperators.SelectedIndex = 0;
            //label1.Font = new Font("Arial", 25);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(256);
            int b = rnd.Next(256);
            int c = rnd.Next(256);
            // button1.BackColor = Color.FromArgb(a, b, c);
            //button1.Text = $"{a}, {b}, {c}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNum1.Text))
            {
                MessageBox.Show("Please enter a number in the first box.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxNum2.Text))
            {
                MessageBox.Show("Please enter a number in the second box.");
                return;
            }

            double num1, num2;
            if (!double.TryParse(textBoxNum1.Text, out num1))
            {
                MessageBox.Show("Please enter a valid number in the first box.");
                return;
            }

            if (!double.TryParse(textBoxNum2.Text, out num2))
            {
                MessageBox.Show("Please enter a valid number in the second box.");
                return;
            }

            var result = 0.0;
            var @operator = comboBoxOperators.SelectedItem.ToString();

            switch (@operator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }


            textBoxResult.Text = $"{result}";
        }

        private void comboBoxOperators_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
                buttonCalc_Click(null, null);
            firstLoad = false;
        }
    }
}
