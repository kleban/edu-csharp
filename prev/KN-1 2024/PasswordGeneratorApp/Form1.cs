namespace PasswordGeneratorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (checkBoxLower.Checked || checkBoxUpper.Checked || checkBoxDigits.Checked || checkBoxSpecSymbols.Checked)
            {
                var password = PasswordGenerator.GeneratePassword(
                   length: (int)numericUpDownLength.Value,
                   useLowercase: checkBoxLower.Checked,
                   useUppercase: checkBoxUpper.Checked,
                   useNumbers: checkBoxDigits.Checked,
                   useSpecialChars: checkBoxSpecSymbols.Checked);

                textBoxPassword.Text = password;
                var (score_int, score_string) = PasswordGenerator.EvaluatePasswordStrength(password);
                progressBarPasswordLevel.Value = score_int;
                labelPasswordLevel.Text = score_string;
            }
            else
            {
                MessageBox.Show(
                    "Оберіть налаштування для генерації пароля!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        //}Ko6b[L3
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxPassword.Text);
        }
    }
}
