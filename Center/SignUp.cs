using System;
using System.Windows.Forms;

namespace Center
{
    public partial class SignUp : Form
    {

        public static string fName;
        public static string lName;
        public static string emailAddress;
        public static string password;
        public static bool smsNotification;
        public static bool report;
        public static bool transaction;
        Confirmation confirmation = new Confirmation();

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            fName = txtFirstName.Text;
            lName = txtLastName.Text;
            emailAddress = txtEmailAddress.Text;
            password = txtPassword.Text;
            this.Hide();
            confirmation.Show();
        }


        private void chkSmsNotification_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSmsNotification.Checked)
            {
                smsNotification = true;
                lblSmsNotifaction.Text = "Apply will swt changes for sms";
            }
            else
            {
                smsNotification = false;
                lblSmsNotifaction.Text = " . . . . ";
            }
        }

        private void chkReport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReport.Checked)
            {
                report = true;
                lblReport.Text = "Apply will swt changes for report";
            }
            else
            {
                report = false;
                lblReport.Text = " . . . . "
;
            }
        }

        private void chkTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransaction.Checked)
            {
                transaction = true;
                lblTransaction.Text = "Apply will swt changes for transaction";
            }
            else
            {
                transaction = false;
                lblTransaction.Text = " . . . . "
;
            }
        }



    }
}
