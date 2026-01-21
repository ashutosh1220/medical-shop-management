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
    public partial class ViewSupplierByID : Form
    {
        public ViewSupplierByID()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewSupplierByID_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            lblSupplierID.Visible = false;
            cmbSupplierID.Visible = false;
            cmbSupplierID.Text = "";
        }

        private void rbtnViewByID_CheckedChanged(object sender, EventArgs e)
        {
            lblSupplierID.Visible = true;
            cmbSupplierID.Visible = true;
            cmbSupplierID.Text = "";
        }

        private void cmbSupplierID_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from supplier");
            cmbSupplierID.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbSupplierID.Items.Add(dr["supplierid"]);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();

            if (rbtnViewAll.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from supplier");
            }
            else if (rbtnViewByID.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from supplier where supplierid='" + cmbSupplierID.Text + "' ");
            }

            dgvSupplierByID.DataSource = objdt;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
