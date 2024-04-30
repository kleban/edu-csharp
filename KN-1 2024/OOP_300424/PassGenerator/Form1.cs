namespace PassGenerator
{
    public partial class Form1 : Form
    {
        private PasswordGenerator _passGenerator = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var password = _passGenerator.Generate(
                lenght: (int)numericUpDownPassLength.Value,
                useLowercase: checkBoxLettersLower.Checked,
                useUppercase: checkBoxLettersUpper.Checked,
                useNumbers: checkBoxDigits.Checked,
                useSymbols: checkBoxSymbols.Checked);

            textBoxPassword.Text = password;
        }
        // ?[?!<*<[
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxPassword.Text);
            MessageBox.Show("Пароль скопійовано до буфера обміну!");
        }
    }
}
