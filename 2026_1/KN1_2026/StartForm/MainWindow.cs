namespace StartForm
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Owner = this;
            var dialogResult = loginForm.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                var login = loginForm.LoginData;
                label1.Text = $"{login.Email} -> {login.Password}";
            } 
            else
            {
                this.Close();
            }
        }
    }
}
