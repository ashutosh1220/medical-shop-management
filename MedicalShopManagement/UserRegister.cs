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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        string mode = "";
        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void btncancel_Click(object sender, EventArgs e)
        {
            UserRegister objUsrReg = new UserRegister();
            objUsrReg.Close();
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();

            panel1.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            txtEmployeeName.BorderStyle = BorderStyle.Fixed3D;
            txtEmployeeID.Visible = true;
            cmbEmpid.Visible = false;
            panel1.Visible = true;
            panel1.Enabled = true;
            groupBox5.Enabled = true;
            groupBox6.Enabled = true;
            txtPhone.Enabled = true;
            cmbEmpid.Visible = false;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtEmployeeName.Enabled = true;
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            txtEmployeeName.BorderStyle = BorderStyle.None;
            txtEmployeeID.Visible = false;
            txtEmployeeName.Enabled = false;
            panel1.Visible = true;
            cmbEmpid.Visible = true;
            panel1.Enabled = true;
            groupBox5.Enabled = true;
            groupBox6.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            cmbEmpid.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            cmbEmpid.Visible = true;
            panel1.Visible = false;
            groupBox5.Enabled = true;
            groupBox6.Enabled = true; ;
            txtEmployeeID.Visible = false;
            txtEmployeeName.Enabled = false;
            txtEmployeeName.BorderStyle = BorderStyle.None;
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            cmbEmpid.Text = "";
        }

        private void cmbEmpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmployeeName.Text = objdt.Rows[cmbEmpid.SelectedIndex]["name"].ToString();
            if (mode == "Update")
            {
                txtAddress.Text = objdt.Rows[cmbEmpid.SelectedIndex]["address"].ToString();
                txtPhone.Text = objdt.Rows[cmbEmpid.SelectedIndex]["phone"].ToString();
                txtEmail.Text = objdt.Rows[cmbEmpid.SelectedIndex]["email"].ToString();
                txtSalary.Text = objdt.Rows[cmbEmpid.SelectedIndex]["salary"].ToString();
            }
        }

        private void cmbEmpid_Click(object sender, EventArgs e)
        {
            cmbEmpid.Items.Clear();
            objdt = new DataTable();
            objdbmanager = new DBManager();
            objdbmanager.GetData("select * from employee");
            
            foreach (DataRow dr in objdt.Rows)
            {
                cmbEmpid.Items.Add(dr["empid"].ToString());
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                if (txtEmployeeID.Text == "")
                {
                    MessageBox.Show("Please enter employee id!");
                    txtEmployeeID.Focus();
                }
                else if (txtEmployeeName.Text == "")
                {
                    MessageBox.Show("Please enter employee name!");
                    txtEmployeeName.Focus();
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please enter address!");
                    txtAddress.Focus();
                }
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Please enter phone!");
                    txtPhone.Focus();
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please enter email!");
                    txtEmail.Focus();
                }
                else
                {
                    objdt = new DataTable();
                    objdbmanager = new DBManager();
                    objdbmanager.GetData("select * from employee where empid='" + txtEmployeeID.Text + "'");

                    if (objdt.Rows.Count > 0)
                    {
                        MessageBox.Show("Employee id already exist.");
                        txtEmployeeID.Text = "";
                        txtEmployeeID.Focus();
                    }
                    else{

                        objdbmanager = new DBManager();
                        objdbmanager.EXESQL("insert into employee (empid, name, address, phone, email, salary) values('" + txtEmployeeID.Text + "', '" + txtEmployeeName.Text + "', '" + txtAddress.Text + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "', '"+txtSalary.Text+"'");
                        MessageBox.Show("Record Inserted successfully");
                        
                        txtEmployeeID.Text = "";
                        txtEmployeeName.Text = "";
                        txtAddress.Text = "";
                        txtEmail.Text = "";
                        txtPhone.Text = "";
                        txtSalary.Text = "";
                    }
                }
            }
            else if (mode == "Update")
            {
                if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please enter address!");
                    txtAddress.Focus();
                }
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Please enter phone!");
                    txtPhone.Focus();
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please enter email!");
                    txtEmail.Focus();
                }
                else
                {
                    objdbmanager = new DBManager();
                    objdbmanager.EXESQL("update employee set address='" + txtAddress.Text + "', phone='" + txtPhone.Text + "', email='" + txtEmail.Text + "', salary='" + txtSalary.Text + "' where empid='" + cmbEmpid.Text + "' ");
                    MessageBox.Show("Record Updated Successfully.");

                    cmbEmpid.Text = "";
                    txtEmployeeName.Text = "";
                    txtAddress.Text = "";
                    txtEmail.Text = "";
                    txtPhone.Text = "";
                    cmbEmpid.Text = "";
                    txtSalary.Text = "";
                    
                }
            }
            else if (mode == "Delete")
            {
                objdbmanager = new DBManager();
                objdbmanager.EXESQL("delete from employee where empid='" + cmbEmpid.Text + "'");

                MessageBox.Show("Record Deleted Successfully.");
                cmbEmpid.Text = "";
                txtEmployeeName.Text = "";
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                cmbEmpid.Text = "";
                txtSalary.Text = "";
                
            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
