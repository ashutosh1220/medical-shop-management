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
    public partial class ViewSaleByVoucher : Form
    {
        public ViewSaleByVoucher()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewSaleByVoucher_Load(object sender, EventArgs e)
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
            lblVoucherNumber.Visible = true;
            cmbVoucherNumber.Visible = true;
            cmbVoucherNumber.Text = "";
        }

        private void cmbVoucherNumber_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from sale");
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
                objdt = objdbmanager.GetData("select * from sale");
            }
            else if (rbtnViewByVoucherNumber.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from sale where voucher_number='" + cmbVoucherNumber.Text + "'");
            }

            dgvSale.DataSource = objdt;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
