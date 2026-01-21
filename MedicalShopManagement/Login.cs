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
using MedicalShopManagement;

namespace MedicalShopManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void Login_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
            pictureBox1.BackgroundImage = Properties.Resources.loginbg;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginLogic()
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Please enter username !");
                txtusername.Focus();
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Please enter password !");
                txtpassword.Focus();
            }
            else
            {
                objdbmanager = new DBManager();
                objdt = new DataTable();
                objdt = objdbmanager.GetData("SELECT *FROM login WHERE username='" + txtusername.Text.Trim() + "' ");

                if (objdt.Rows.Count > 0)
                { 
                    if (objdt.Rows[0]["password"].ToString() == txtpassword.Text)
                    {
                        MedicalShopManagement.LoginStatus.loginStatus = "ok";
                        txtusername.Text = "";
                        txtpassword.Text = "";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password !");
                        txtpassword.Text = "";
                        txtpassword.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username !");
                    txtusername.Text = "";
                    txtpassword.Focus();
                }
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            LoginLogic();
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginLogic();
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginLogic();
            }
        }
    }
}
