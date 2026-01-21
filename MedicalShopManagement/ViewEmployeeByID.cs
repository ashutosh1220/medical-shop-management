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
    public partial class ViewEmployeeByID : Form
    {
        public ViewEmployeeByID()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ViewEmployeeByID_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void rbtnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            lblEmployeeID.Visible = false;
            cmbEmployeeID.Visible = false;
            cmbEmployeeID.Text = "";
        }

        private void rbtnViewByID_CheckedChanged(object sender, EventArgs e)
        {
            lblEmployeeID.Visible = true;
            cmbEmployeeID.Visible = true;
            cmbEmployeeID.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            objdt = new DataTable();
            objdbmanager = new DBManager();

            if(rbtnViewAll.Checked==true){
                objdt = objdbmanager.GetData("select * from employee");
            }
            else if (rbtnViewByID.Checked==true)
            {
                objdt = objdbmanager.GetData("select * from employee where empid='" + cmbEmployeeID.Text + "'");
            }
            
            dgvEmployeeByID.DataSource = objdt;
            
        }

        private void cmbEmployeeID_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from employee");
            cmbEmployeeID.Items.Clear();

            foreach(DataRow dr in objdt.Rows){
                cmbEmployeeID.Items.Add(dr["empid"]);
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
