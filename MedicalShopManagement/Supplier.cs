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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        string mode = "";
        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void Supplier_Load(object sender, EventArgs e)
        {
            groupBox6.Enabled = false;
            groupBox5.Enabled = false;
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            panel1.Visible = true;
            txtSupplierName.Enabled = true;
            txtSupplierID.Visible = true;
            cmbSupplierId.Visible = false;
            txtSupplierName.BorderStyle = BorderStyle.Fixed3D;
            cmbSupplierId.Text = "";
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            cmbCompanyID.Text = "";
            cmbMedicineID.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtWebsite.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                if (txtSupplierID.Text == "")
                {
                    MessageBox.Show("Please enter supplier id !");
                    txtSupplierID.Focus();
                }
                else if (txtSupplierName.Text == "")
                {
                    MessageBox.Show("Please enter supplier name!");
                    txtSupplierName.Focus();
                }
                else if (cmbCompanyID.Text == "")
                {
                    MessageBox.Show("Please select company !");
                    cmbCompanyID.Focus();
                }
                else if (cmbMedicineID.Text == "")
                {
                    MessageBox.Show("Please select medicine !");
                    cmbMedicineID.Focus();
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
                    objdt = new DataTable();
                    objdbmanager = new DBManager();
                    objdbmanager.GetData("select * from supplier where supplierid='" + txtSupplierID.Text + "'");

                    if (objdt.Rows.Count > 0)
                    {
                        MessageBox.Show("Supplier id already exist.");
                        txtSupplierID.Text = "";
                        txtSupplierID.Focus();
                    }
                    else
                    {
                        objdbmanager = new DBManager();
                        objdbmanager.EXESQL("insert into supplier (supplierid, suppliername, companyid, medicineid, address, phone, email, website) values ('" + txtSupplierID.Text + "', '" + txtSupplierName.Text + "', '" + cmbCompanyID.Text + "', '" + cmbMedicineID.Text + "', '" + txtAddress.Text + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "', '" + txtWebsite.Text + "')");

                        MessageBox.Show("New record inserted !");

                        txtSupplierID.Text = "";
                        txtSupplierName.Text = "";
                        cmbCompanyID.Text = "";
                        cmbMedicineID.Text = "";
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
                if (cmbCompanyID.Text == "")
                {
                    MessageBox.Show("Please select company !");
                    cmbCompanyID.Focus();
                }
                else if (cmbMedicineID.Text == "")
                {
                    MessageBox.Show("Please select medicine !");
                    cmbMedicineID.Focus();
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
                    objdbmanager.EXESQL("update supplier set companyid='" + cmbCompanyID.Text + "', medicineid='" + cmbMedicineID.Text + "', address='" + txtAddress.Text + "', phone='" + txtPhone.Text + "', email='" + txtEmail.Text + "', website='" + txtWebsite.Text + "' where medicineid='" + cmbMedicineID.Text + "'");

                    MessageBox.Show("Record updated successfully !");

                    cmbSupplierId.Text = "";
                    txtSupplierID.Text = "";
                    txtSupplierName.Text = "";
                    cmbCompanyID.Text = "";
                    cmbMedicineID.Text = "";
                    txtAddress.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    txtWebsite.Text = "";

                    groupBox5.Enabled = false;
                    groupBox6.Enabled = false;

                }
            }else if(mode=="Delete"){


                objdbmanager = new DBManager();
                objdbmanager.EXESQL("delete from supplier where supplierid='" + cmbSupplierId.Text + "'");
                MessageBox.Show("Record deleted successfully !");

                cmbSupplierId.Text = "";
                txtSupplierID.Text = "";
                txtSupplierName.Text = "";

                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
            }
        }

       

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            panel1.Visible = true;
            txtSupplierName.Enabled = false;
            txtSupplierID.Visible = false;
            cmbSupplierId.Visible = true;
            txtSupplierName.BorderStyle = BorderStyle.None;

            cmbSupplierId.Text = "";
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            cmbCompanyID.Text = "";
            cmbMedicineID.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtWebsite.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            panel1.Visible = false;
            txtSupplierName.Enabled = false;
            txtSupplierID.Visible = false;
            cmbSupplierId.Visible = true;
            txtSupplierName.BorderStyle = BorderStyle.None;

            cmbSupplierId.Text = "";
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            cmbCompanyID.Text = "";
            cmbMedicineID.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtWebsite.Text = "";
        }

        private void cmbMedicineID_Click(object sender, EventArgs e)
        {
            cmbMedicineID.Items.Clear();
            
            objdt = new DataTable();
            objdbmanager = new DBManager();
            objdt = objdbmanager.GetData("select * from medicine where companyid='" + cmbCompanyID.Text + "'");

            foreach (DataRow dr in objdt.Rows)
            {
                cmbMedicineID.Items.Add(dr["medicineid"].ToString());
            }
        }

        private void cmbCompanyID_Click(object sender, EventArgs e)
        {
            cmbCompanyID.Items.Clear();
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from company");

            foreach (DataRow dr in objdt.Rows)
            {
                cmbCompanyID.Items.Add(dr["companyid"].ToString());
            }
        }

        private void cmbSupplierId_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from supplier");
            cmbSupplierId.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbSupplierId.Items.Add(dr["supplierid"].ToString());
            }
        }

        private void cmbSupplierId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSupplierName.Text = objdt.Rows[cmbSupplierId.SelectedIndex]["suppliername"].ToString();

            if (mode == "Update")
            {
                cmbCompanyID.Text = objdt.Rows[cmbSupplierId.SelectedIndex]["companyid"].ToString();
                cmbMedicineID.Text = objdt.Rows[cmbSupplierId.SelectedIndex]["medicineid"].ToString();
                txtAddress.Text = objdt.Rows[cmbSupplierId.SelectedIndex]["address"].ToString();
                txtPhone.Text = objdt.Rows[cmbSupplierId.SelectedIndex]["phone"].ToString();
                txtEmail.Text = objdt.Rows[cmbSupplierId.SelectedIndex]["email"].ToString();
                txtWebsite.Text = objdt.Rows[cmbSupplierId.SelectedIndex]["website"].ToString();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
