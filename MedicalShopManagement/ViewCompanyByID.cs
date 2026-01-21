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
    public partial class ViewCompanyByID : Form
    {
        public ViewCompanyByID()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewCompanyByID_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();

            if (rbtnViewAll.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from company");
            }
            else if (rbtnViewByID.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from company");
                objdt = objdbmanager.GetData("select * from company where companyid='" + cmbCompanyID.Text + "'");
            }

            objdt = new DataTable();
            dgvCompanyByID.DataSource = objdt;
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            lblCompanyID.Visible = false;
            cmbCompanyID.Visible = false;
            cmbCompanyID.Text = "";
        }

        private void rbtnViewByID_CheckedChanged(object sender, EventArgs e)
        {
            lblCompanyID.Visible = true;
            cmbCompanyID.Visible = true;
            cmbCompanyID.Text = "";
        }

        private void cmbCompanyID_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from company");
            cmbCompanyID.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbCompanyID.Items.Add(dr["companyid"]);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
