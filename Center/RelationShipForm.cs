using System;
using System.Windows.Forms;

namespace Center
{
    public partial class RelationShipForm : Form
    {
        public RelationShipForm()
        {
            InitializeComponent();
        }

        private void btnSubmitRelation_Click(object sender, EventArgs e)
        {
            string input = "";
            if (radioMarried.Checked)
            {
                input = radioMarried.Text;
            }
            if (radioSingle.Checked)
            {
                input = radioSingle.Text;
            }
            if (radioInRelation.Checked)
            {
                input = radioInRelation.Text;
            }
            MessageBox.Show(input);
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {

        }

        private void btnBH_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.Show();
        }
    }
}
