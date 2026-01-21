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
    public partial class ViewPurchaseByDate : Form
    {
        public ViewPurchaseByDate()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewPurchaseByDate_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void lblVoucherNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();

            if (rbtnViewAll.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from purchase");
            }
            else if (rbtnViewByDate.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from purchase where voucher_date between '" + dateTimePicker1.Value.ToShortDateString() + "' and '" + dateTimePicker2.Value.ToShortDateString() + "'");
            }

            dgvPurchase.DataSource = objdt;
        
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void rbtnViewByDate_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
