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
    public partial class ViewPurchaseByVoucher : Form
    {
        public ViewPurchaseByVoucher()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewPurchaseByVoucher_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            lblVoucherNumber.Visible = false;
            cmbVoucherNumber.Visible = false;
            cmbVoucherNumber.Text = "";
        }

        private void rbtnViewByVoucherNumber_CheckedChanged(object sender, EventArgs e)
        {
            lblVoucherNumber.Visible = false;
            cmbVoucherNumber.Visible = false;
            cmbVoucherNumber.Text = "";
        }

        private void cmbVoucherNumber_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select voucher_number from purchase");
            cmbVoucherNumber.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbVoucherNumber.Items.Add(dr["voucher_number"]);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            objdbmanager = new DBManager();
            objdt = new DataTable();
            
            if (rbtnViewAll.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from purchase");
            }
            else if (rbtnViewByVoucherNumber.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from purchase where voucher_number='" + cmbVoucherNumber.Text + "'");
            }

            dgvPurchaseByVoucherNo.DataSource = objdt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
