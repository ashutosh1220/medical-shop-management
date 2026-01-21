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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        string mode = "";
        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void Salary_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();

            txtEmployeeName.Enabled = false;
            txtBasicSalary.Enabled = false;

            txtEmployeeName.BorderStyle = BorderStyle.None;
            txtBasicSalary.BorderStyle = BorderStyle.None;
            txtNetSalary.BorderStyle = BorderStyle.None;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(cmbEmployeeID.Text==""){
                MessageBox.Show("Please select employee id !");
            }
            else if (txtNumberOfLeaves.Text == "")
            {
                MessageBox.Show("Please enter number of leaves !");
            }
            else if (txtAllowence.Text == "")
            {
                MessageBox.Show("Please enter allowence !");
            }
            else if (txtDeduction.Text == "")
            {
                MessageBox.Show("Please enter deduction !");
            }
            else
            {

                objdbmanager = new DBManager();
                objdbmanager.EXESQL("insert into salary(date_of_salary,employee_id,no_of_leave,allowance,deduction,netsalary) values('" + dtpDateOfSalary.Value.ToShortDateString() + "','" + cmbEmployeeID.Text + "','" + txtNumberOfLeaves.Text + "','" + txtAllowence.Text + "','" + txtDeduction.Text + "','" + txtNetSalary.Text + "')");

                MessageBox.Show("Record inserted successfully");

                txtEmployeeName.Text = "";
                txtBasicSalary.Text = "";
                txtAllowence.Text = "";
                txtDeduction.Text = "";
                txtNetSalary.Text = "";
                txtNumberOfLeaves.Text = "";
                cmbEmployeeID.Text = "";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmployeeName.Text=objdt.Rows[cmbEmployeeID.SelectedIndex]["name"].ToString();
            txtBasicSalary.Text = objdt.Rows[cmbEmployeeID.SelectedIndex]["salary"].ToString();
        }

        private void txtDeduction_TextChanged(object sender, EventArgs e)
        {
            int leaveamount;

            if (txtDeduction.Text != "" && txtNumberOfLeaves.Text != "" && txtAllowence.Text != "")
            {

            leaveamount=Convert.ToInt32(txtBasicSalary.Text)/30* Convert.ToInt32(txtNumberOfLeaves.Text);
            txtNetSalary.Text=Convert.ToString(Convert.ToInt32(txtBasicSalary.Text)+Convert.ToInt32(txtAllowence.Text)-Convert.ToInt32(txtDeduction.Text)-leaveamount);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBasicSalary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
