using System;
using System.Windows.Forms;

namespace Center
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            Text = "Welcome in home page";
            LoginForm login = new LoginForm();
            login.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblHomeWel.Text = "Welcome in home page";
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblHomeWel.Text = "Welcome ..";

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            //HomeForm home = new HomeForm();
            //home.Hide();
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            DateForm dateForm = new DateForm();
            this.Hide();
            dateForm.Show();
        }

        private void btnRelation_Click(object sender, EventArgs e)
        {
            RelationShipForm relation = new RelationShipForm();
            this.Hide();
            relation.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            DialogForm dialogForm = new DialogForm();
            this.Hide();
            dialogForm.Show();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            TeachersForm teachersForm = new TeachersForm();
            this.Hide();
            teachersForm.Show();
        }
    }
}
