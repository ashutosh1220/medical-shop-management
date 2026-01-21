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
    public partial class ViewBySupplierName : Form
    {
        public ViewBySupplierName()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewBySupplierName_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            lblSupplierName.Visible = false;
            cmbSupplierName.Visible = false;
            cmbSupplierName.Text = "";
        }

        private void rbtnViewByName_CheckedChanged(object sender, EventArgs e)
        {
            lblSupplierName.Visible = true;
            cmbSupplierName.Visible = true;
            cmbSupplierName.Text = "";
        }

        private void rbtnViewByID_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            objdt = new DataTable();
            objdbmanager = new DBManager();

            if (rbtnViewAll.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from supplier");
            }
            else if (rbtnViewByName.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from supplier where suppliername='" + cmbSupplierName.Text + "' ");
            }

            dgvSupplierByName.DataSource = objdt;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSupplierName_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from supplier");
            cmbSupplierName.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbSupplierName.Items.Add(dr["suppliername"]);
            }
        }
    }
}
