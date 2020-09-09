using System;
using System.Windows.Forms;

namespace Center
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblShowFN.Text = SignUp.fName;
            lblShowLN.Text = SignUp.lName;
            lblShowEmail.Text = SignUp.emailAddress;
            lblShowPassword.Text = SignUp.password;
            if (SignUp.smsNotification)
            {
                lblConfirmlSmsNotifaction.Text = "✓";
            }
            if (SignUp.report)
            {
                lblConfirmReport.Text = "✓";

            }
            if (SignUp.transaction)
            {
                lblConfirmTransaction.Text = "✓";

            }
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            this.Hide();
            homeForm.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
