namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNum1.Text))
            {
                MessageBox.Show("Please enter a number in the first text box.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxNum2.Text))
            {
                MessageBox.Show("Please enter a number in the second text box.");
                return;
            }

            if (!int.TryParse(textBoxNum1.Text, out _))
            {
                MessageBox.Show("Please enter a valid number in the first text box.");
                return;
            }

            if (!int.TryParse(textBoxNum2.Text, out _))
            {
                MessageBox.Show("Please enter a valid number in the second text box.");
                return;
            }

            int num1 = int.Parse(textBoxNum1.Text);
            int num2 = int.Parse(textBoxNum2.Text);

            string op = comboBoxOp.SelectedItem.ToString();

            switch(op)
            {
                case "+":
                    textBoxResult.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    textBoxResult.Text = (1.0*num1 / num2).ToString();
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxOp.SelectedIndex = 0;
        }
    }
}
