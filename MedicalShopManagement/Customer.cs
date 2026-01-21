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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        string mode = "";
        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void Customer_Load(object sender, EventArgs e)
        {
            groupBox6.Enabled = false;
            groupBox5.Enabled = false;
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox6.Enabled=true;
            groupBox5.Enabled=true;
            panel1.Visible = true;
            cmbCustomerId.Visible = false;
            txtCustomerID.Visible = true;
            txtCustomerName.Enabled = true;
            txtCustomerName.BorderStyle = BorderStyle.Fixed3D;

            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cmbCustomerId.Text = "";

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            panel1.Visible = true;
            txtCustomerID.Visible = false;
            cmbCustomerId.Visible = true;
            txtCustomerName.Enabled = false;
            txtCustomerName.BorderStyle = BorderStyle.None;

            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cmbCustomerId.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            panel1.Visible = false;
            txtCustomerID.Visible = false;
            cmbCustomerId.Visible = true;
            txtCustomerName.Enabled = false;
            txtCustomerName.BorderStyle = BorderStyle.None;

            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cmbCustomerId.Text = "";

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                if(txtCustomerID.Text==""){
                    MessageBox.Show("Please enter customer id !");
                    txtCustomerID.Focus();
                }
                else if (txtCustomerName.Text == "")
                {
                    MessageBox.Show("Please enter customer name!");
                    txtCustomerName.Focus();
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please enter address !");
                    txtAddress.Focus();
                }
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Please enter phone no. !");
                    txtPhone.Focus();
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please enter email !");
                    txtEmail.Focus();
                }
                else
                {
                    objdbmanager = new DBManager();
                    objdt = new DataTable();
                    objdt = objdbmanager.GetData("select * from customer where id='" + txtCustomerID.Text + "'");

                    if (objdt.Rows.Count > 0)
                    {
                        MessageBox.Show("Customer id already exist !");
                    }
                    else
                    {
                        objdbmanager = new DBManager();
                        objdbmanager.EXESQL("insert into customer (id, name, address, phone, email) values('" + txtCustomerID.Text + "', '" + txtCustomerName.Text + "', '" + txtAddress.Text + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "') ");
                        MessageBox.Show("Record inserted successfully !");

                        groupBox6.Enabled = false;
                        groupBox5.Enabled = false;
                        txtCustomerID.Text = "";
                        txtCustomerName.Text = "";
                        txtAddress.Text = "";
                        txtPhone.Text = "";
                        txtEmail.Text = "";
                    }
                }
            }else if(mode == "Update"){

                objdbmanager = new DBManager();
                objdbmanager.EXESQL("update customer set address='" + txtAddress.Text + "', phone='" + txtPhone.Text + "', email='" + txtEmail.Text + "' where id ='" + cmbCustomerId.Text + "'");
                MessageBox.Show("Record Updated successfully !");

                groupBox6.Enabled = false;
                groupBox5.Enabled = false;
                cmbCustomerId.Text = "";
                txtCustomerName.Text="";
                txtAddress.Text="";
                txtPhone.Text="";
                txtEmail.Text="";
                
            }else if(mode == "Delete"){
                objdbmanager = new DBManager();
                objdbmanager.EXESQL("delete from customer where id='" + cmbCustomerId.Text + "'");
                MessageBox.Show("Record Deleted successfully !");

                groupBox6.Enabled = false;
                groupBox5.Enabled = false;
                panel1.Visible = false;
                cmbCustomerId.Text = "";
                txtCustomerName.Text = "";
            }
            
        }

        private void cmbCustomerId_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from customer");

            cmbCustomerId.Items.Clear();

            foreach(DataRow dr in objdt.Rows){
                cmbCustomerId.Items.Add(dr["id"].ToString());
            }
        }

        private void cmbCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomerName.Text=objdt.Rows[cmbCustomerId.SelectedIndex]["name"].ToString();

            if(mode=="Update"){
            txtAddress.Text = objdt.Rows[cmbCustomerId.SelectedIndex]["address"].ToString();
            txtPhone.Text = objdt.Rows[cmbCustomerId.SelectedIndex]["phone"].ToString();
            txtEmail.Text = objdt.Rows[cmbCustomerId.SelectedIndex]["email"].ToString();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
