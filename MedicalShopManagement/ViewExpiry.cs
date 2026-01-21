using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedicalShopManagement
{
    public partial class ViewExpiry : Form
    {
        public ViewExpiry()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewExpiry_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            objdbmanager = new DBManager();
            objdt = new DataTable();

            if (rbtnViewAll.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from medicine");
            }
            else if (rbtnViewByDate.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from medicine where expdate between '" + dateTimePicker1.Value.ToShortDateString() + "' and '" + dateTimePicker2.Value.ToShortDateString() + "'");
            }

            dgvSalary.DataSource = objdt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void rbtnViewByDate_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
