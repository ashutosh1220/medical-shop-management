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
    public partial class ViewByCompanyName : Form
    {
        public ViewByCompanyName()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewByCompanyName_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            lblCompanyName.Visible = false;
            cmbCompanyName.Visible = false;
            cmbCompanyName.Text = "";
        }

        private void rbtnViewByID_CheckedChanged(object sender, EventArgs e)
        {
            lblCompanyName.Visible = true;
            cmbCompanyName.Visible = true;
            cmbCompanyName.Text = "";
        }

        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCompanyName_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from company");
            
            cmbCompanyName.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbCompanyName.Items.Add(dr["companyname"]);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            objdt = new DataTable();
            objdbmanager = new DBManager();

            if (rbtnViewAll.Checked == true)
            { 
                objdt = objdbmanager.GetData("select * from company");
            }
            else if (rbtnViewByID.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from company where companyname='" + cmbCompanyName.Text + "' ");
            }
            dgvCompany.DataSource = objdt;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
