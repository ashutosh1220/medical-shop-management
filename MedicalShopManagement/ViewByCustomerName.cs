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
    public partial class ViewByCustomerName : Form
    {
        public ViewByCustomerName()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewByCustomerName_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            lblCustomerName.Visible = false;
            cmbCustomerName.Visible = false;
            cmbCustomerName.Text = "";
        }

        private void rbtnViewByName_CheckedChanged(object sender, EventArgs e)
        {
            lblCustomerName.Visible = true;
            cmbCustomerName.Visible = true;
            cmbCustomerName.Text = "";
        }

        private void rbtnViewByID_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCustomerID_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from customer");
            cmbCustomerName.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbCustomerName.Items.Add(dr["name"]);
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            objdt = new DataTable();
            objdbmanager = new DBManager();

            if (rbtnViewAll.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from customer");
            }
            else if (rbtnViewByID.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from customer where name='" + cmbCustomerName.Text + "' ");
            }
            dgvCustomerByName.DataSource = objdt;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
