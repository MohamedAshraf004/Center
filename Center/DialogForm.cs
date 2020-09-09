using System;
using System.Windows.Forms;

namespace Center
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        private void btnDecide_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("1) yes \n 2) no 3) cancel", "Purchesing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                lblDialog.Text = "Congrates";
            }
            switch (dr)
            {
                case DialogResult.Yes:
                    lblDialog.Text = "Congrates";
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.No:
                    lblDialog.Text = "canceled";
                    break;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }
    }
}
