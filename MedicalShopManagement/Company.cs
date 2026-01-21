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
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        SqlCommand objcomm;
        DataTable objdt;
        DBConnection objdc;
        DBManager dbm;
        string mode = "";

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Company_Load(object sender, EventArgs e)
        {
            groupBox6.Enabled = false;
            groupBox5.Enabled = false;
            objdc = new DBConnection();
            objconn = objdc.GetConnection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            panel1.Visible = true;
            txtCompanyID.Visible = true;
            cmbCompanyId.Visible = false;
            txtCompanyName.Enabled = true;
            txtCompanyName.BorderStyle = BorderStyle.Fixed3D;

            txtCompanyID.Text = "";
            txtCompanyName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtWebsite.Text = "";
            cmbCompanyId.Text = "";
            cmbCompanyId.Text = "";
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {


                if (txtCompanyID.Text == "")
                {
                    MessageBox.Show("Please enter supplier id !");
                    txtCompanyID.Focus();
                }
                else if (txtCompanyName.Text == "")
                {
                    MessageBox.Show("Please enter company name !");
                    txtCompanyName.Focus();
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
                else if (txtWebsite.Text == "")
                {
                    MessageBox.Show("Please enter website !");
                    txtWebsite.Focus();
                }
                else
                {
                    
                    qstr = "select * from company where companyid='" + txtCompanyID.Text + "'";
                    dbm = new DBManager();
                    objdt = new DataTable();

                    objdt = dbm.GetData(qstr);

                    if (objdt.Rows.Count > 0)
                    {
                        MessageBox.Show("Company id already exist.");
                        txtCompanyID.Text = "";
                        txtCompanyID.Focus();
                    }
                    else
                    {

                        objcomm = new SqlCommand("insert into company (companyid, companyname, address, phone, email, website) values ('" + txtCompanyID.Text + "', '" + txtCompanyName.Text + "', '" + txtAddress.Text + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "', '" + txtWebsite.Text + "')", objconn);

                        objconn.Open();
                        objcomm.ExecuteNonQuery();
                        objconn.Close();

                        MessageBox.Show("New company added.");

                        txtCompanyID.Text = "";
                        txtCompanyName.Text = "";
                        txtAddress.Text = "";
                        txtPhone.Text = "";
                        txtEmail.Text = "";
                        txtWebsite.Text = "";

                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                    }
                }
            }
            else if (mode == "Update")
            {
                objcomm = new SqlCommand("update company set address='" + txtAddress.Text + "', phone='" + txtPhone.Text + "', email='" + txtEmail.Text + "' , website='"+txtWebsite.Text+"' where companyid ='" + cmbCompanyId.Text + "' ", objconn);
                objconn.Open();
                objcomm.ExecuteNonQuery();
                objconn.Close();
                MessageBox.Show("Record Updated successfully !");
                groupBox6.Enabled = false;
                groupBox5.Enabled = false;
                txtCompanyID.Text = "";
                txtCompanyName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtWebsite.Text = "";
                cmbCompanyId.Text = "";
                cmbCompanyId.Text = "";
            }
            else if (mode == "Delete")
            {
                objcomm = new SqlCommand("delete from company where companyid='" + cmbCompanyId.Text + "' ", objconn);
                objconn.Open();
                objcomm.ExecuteNonQuery();
                objconn.Close();
                MessageBox.Show("Record Deleted successfully !");
                groupBox6.Enabled = false;
                groupBox5.Enabled = false;
                panel1.Visible = false;
                cmbCompanyId.Text = "";
                txtCompanyName.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            panel1.Visible = true;
            txtCompanyID.Visible = false;
            cmbCompanyId.Visible = true;
            txtCompanyName.Enabled = false;
            txtCompanyName.BorderStyle = BorderStyle.None;

            txtCompanyID.Text = "";
            txtCompanyName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtWebsite.Text = "";
            cmbCompanyId.Text = "";
            cmbCompanyId.Text = "";

        }

        private void cmbCompanyId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCompanyName.Text = objdt.Rows[cmbCompanyId.SelectedIndex]["companyname"].ToString();

            if (mode == "Update")
            {
                txtAddress.Text = objdt.Rows[cmbCompanyId.SelectedIndex]["address"].ToString();
                txtPhone.Text = objdt.Rows[cmbCompanyId.SelectedIndex]["phone"].ToString();
                txtEmail.Text = objdt.Rows[cmbCompanyId.SelectedIndex]["email"].ToString();
                txtWebsite.Text = objdt.Rows[cmbCompanyId.SelectedIndex]["website"].ToString();
            }
        }
        string qstr;
        private void cmbCompanyId_Click(object sender, EventArgs e)
        {
            cmbCompanyId.Items.Clear();
            /*objadapt = new SqlDataAdapter("select * from company", objconn);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            */
            dbm = new DBManager();
            qstr = "select * from company";
            objdt = dbm.GetData(qstr);

             cmbCompanyId.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbCompanyId.Items.Add(dr["companyid"].ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            panel1.Visible = false;
            txtCompanyID.Visible = false;
            cmbCompanyId.Visible = true;
            txtCompanyName.Enabled = false;
            txtCompanyName.BorderStyle = BorderStyle.None;

            txtCompanyID.Text = "";
            txtCompanyName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtWebsite.Text = "";
            cmbCompanyId.Text = "";
            cmbCompanyId.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
