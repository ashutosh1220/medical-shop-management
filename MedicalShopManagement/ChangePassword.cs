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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        string mode = "";
        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
            txtUsername.Focus();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text==""){
                MessageBox.Show("Please enter username !");
                txtUsername.Focus();
            }
            else if (txtOldPassword.Text == "")
            {
                MessageBox.Show("Please enter old password !");
                txtOldPassword.Focus();
            }
            else if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Please enter new password !");
                txtNewPassword.Focus();
            }
            else if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please enter confirm password !");
               //txtConfirmPassword.Text = "";
                txtConfirmPassword.Focus();
            }
            else
            {
                objdbmanager = new DBManager();
                objdt = new DataTable();
                objdt = objdbmanager.GetData("select *from login where username='" + txtUsername.Text.Trim() + "'");

                if (objdt.Rows.Count > 0)
                {
                    if (objdt.Rows[0]["password"].ToString() == txtOldPassword.Text)
                    {
                        if (txtNewPassword.Text == txtConfirmPassword.Text)
                        {
                            objdbmanager = new DBManager();
                            objdbmanager.EXESQL("update login set password='"+txtNewPassword.Text+"' where username='"+txtUsername.Text.Trim()+"' ");
                            MessageBox.Show("Password successfully updated.");

                            txtUsername.Text = "";
                            txtOldPassword.Text = "";
                            txtNewPassword.Text = "";
                            txtConfirmPassword.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Password doesn't match !");
                            txtConfirmPassword.Text = "";
                            txtConfirmPassword.Focus();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid password !");
                        txtOldPassword.Text = "";
                        txtOldPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username !");
                    txtUsername.Text = "";
                    txtUsername.Focus();
                }   
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
