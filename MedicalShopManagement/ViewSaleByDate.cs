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
    public partial class ViewSaleByDate : Form
    {
        public ViewSaleByDate()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewSaleByDate_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void rbtnViewByDate_CheckedChanged(object sender, EventArgs e)
        {
                panel1.Visible = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();

            if (rbtnViewAll.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from sale");
            }
            else if (rbtnViewByDate.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from sale where voucher_date between '" + dateTimePicker1.Value.ToShortDateString() + "' and '" + dateTimePicker2.Value.ToShortDateString() + "'");
            }

            dgvSale.DataSource = objdt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
