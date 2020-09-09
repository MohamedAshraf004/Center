using System;
using System.Windows.Forms;

namespace Center
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "Enter User Name";
            txtUserName.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                Reset();
            }
        }

        private void Reset()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = "";
        }
        private void Login()
        {
            if (txtUserName.Text == "moh" && txtPassword.Text == "123")
            {
                this.Hide();
                HomeForm home = new HomeForm();
                home.Show();

            }
            else
            {
                MessageBox.Show("Invalide login ...");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();

            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
