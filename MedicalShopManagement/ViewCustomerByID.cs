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
    public partial class ViewCustomerByID : Form
    {
        public ViewCustomerByID()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewCustomerByID_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            lblCustomerID.Visible = false;
            cmbCustomerId.Visible = false;
            cmbCustomerId.Text = "";
        }

        private void rbtnViewByID_CheckedChanged(object sender, EventArgs e)
        {
            lblCustomerID.Visible = true;
            cmbCustomerId.Visible = true;
            cmbCustomerId.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();

            if (rbtnViewAll.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from customer");
            }
            else if (rbtnViewByID.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from company where id='" + cmbCustomerId.Text + "'");
            }

            dgvCustomerByID.DataSource = objdt;
        }

        private void cmbCustomerId_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from customer");
            cmbCustomerId.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbCustomerId.Items.Add(dr["id"]);
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
