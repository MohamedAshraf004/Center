using System;
using System.Data;
using System.Windows.Forms;

namespace Center
{
    public partial class TeachersForm : Form
    {
        DataTable dt = new DataTable();
        DataTable dts = new DataTable();
        DataTable dtsSpec = new DataTable();
        public TeachersForm()
        {
            InitializeComponent();
        }

        private void InitDT()
        {
            dt.Columns.Add("TID", typeof(int));
            dt.Columns.Add("TName");
            dt.Columns.Add("TAddress");
            dt.Rows.Add(1, "Mohamed", "Mans");
            dt.Rows.Add(2, "Ahmed", "Mans");
            dt.Rows.Add(3, "Ashraf", "Mans");
        }
        private void InitDTSubject()
        {
            dts.Columns.Add("TID", typeof(int));
            dts.Columns.Add("SName");
            dts.Columns.Add("SType");
            dts.Rows.Add(1, "ir", "pr");
            dts.Rows.Add(1, "ai", "pr");
            dts.Rows.Add(1, "web", "des");
            dts.Rows.Add(2, "fit", "spo");
            dts.Rows.Add(2, "jkdsj", "dd");
            dts.Rows.Add(3, "kfd", "fdff");
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            InitDT();
            InitDTSubject();
            comboTeacher.DataSource = dt;
            comboTeacher.DisplayMember = "TName";
            //comboTeacher.ValueMember = "TID";
        }


        private void comboTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblName.Text = dt.Rows[comboTeacher.SelectedIndex]["TName"].ToString();

            //InitDTSubject();
            dtsSpec =
                dts.Select("TID =" + dt.Rows[comboTeacher.SelectedIndex]["TID"]).CopyToDataTable();
            comboSubject.DataSource = dtsSpec;
            comboSubject.DisplayMember = "SName";
        }
        private void comboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSubject.Text = dtsSpec.Rows[comboSubject.SelectedIndex]["SName"].ToString();

        }

    }
}
