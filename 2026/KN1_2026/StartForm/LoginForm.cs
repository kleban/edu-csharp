using StartForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StartForm
{
    public partial class LoginForm : Form
    {
        private LoginData _login = new();

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginData LoginData
        {
            get { return _login; }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            _login.Email = textBoxEmail.Text;
            _login.Password = textBoxPassword.Text;
        }
    }
}
