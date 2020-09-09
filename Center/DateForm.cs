using System;
using System.Windows.Forms;

namespace Center
{
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datetime.Text = dtpicker.Value.ToString("dd dddd MM MMMM yyyy");
            date1.Text = dtpicker.Value.ToLongDateString();
            date2.Text = dtpicker.Value.ToShortDateString();
            time1.Text = dtpicker.Value.ToLongTimeString();
        }
    }
}
