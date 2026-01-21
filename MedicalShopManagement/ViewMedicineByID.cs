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
    public partial class ViewMedicineByID : Form
    {
        public ViewMedicineByID()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewMedicineByID_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            lblMedicineID.Visible = false;
            cmbMedicineID.Visible = false;
        }

        private void rbtnViewByID_CheckedChanged(object sender, EventArgs e)
        {
            lblMedicineID.Visible = true;
            cmbMedicineID.Visible = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();

            if(rbtnViewAll.Checked==true){
                objdt = objdbmanager.GetData("select * from mrdicine");
            }
            else if (rbtnViewByID.Checked==true)
            {
                objdt = objdbmanager.GetData("select * from mrdicine where medicineid='" + cmbMedicineID.Text + "'");
            }
            
            dgvMedicineByID.DataSource = objdt;
            
        }

        private void cmbMedicineID_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from mrdicine");
            cmbMedicineID.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbMedicineID.Items.Add(dr["medicineid"]);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
