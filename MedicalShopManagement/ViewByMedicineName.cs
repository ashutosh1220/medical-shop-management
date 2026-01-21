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
    public partial class ViewByMedicineName : Form
    {
        public ViewByMedicineName()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewByMedicineName_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            lblMedicineName.Visible = false;
            cmbMedicineName.Visible = false;
            cmbMedicineName.Text = "";
        }

        private void rbtnViewByID_CheckedChanged(object sender, EventArgs e)
        {
            lblMedicineName.Visible = true;
            cmbMedicineName.Visible = true;
            cmbMedicineName.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();

            if (rbtnViewAll.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from medicine");
            }
            else if (rbtnViewByID.Checked == true)
            {
                objdt = objdbmanager.GetData("select * from medicine where medicinename='" + cmbMedicineName.Text + "'");
            }

            dgvMedicineByName.DataSource = objdt;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMedicineName_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from medicine");
            cmbMedicineName.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbMedicineName.Items.Add(dr["medicinename"]);
            }
        }
    }
}
