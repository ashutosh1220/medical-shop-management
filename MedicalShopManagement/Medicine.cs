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
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }

        string mode = "";
        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;

        private void lblname1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            groupBox6.Enabled = false;
            groupBox5.Enabled = false;

            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();

        }

        private void cmbCompanyId_Click(object sender, EventArgs e)
        {
            cmbCompanyId.Items.Clear();
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select *from company");
             
            foreach (DataRow dr in objdt.Rows)
            {
                cmbCompanyId.Items.Add(dr["companyid"].ToString());
            }
        }

        private void cmbCompanyId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode == "Delete")
            {
                txtMedicineName.Text = objdt.Rows[cmbMedicineId.SelectedIndex]["medicinename"].ToString();
            }
            if (mode == "Update")
            {
                cmbCompanyId.Text = objdt.Rows[cmbMedicineId.SelectedIndex]["companyid"].ToString();
                txtPrice.Text = objdt.Rows[cmbMedicineId.SelectedIndex]["price"].ToString();
                txtUnit.Text = objdt.Rows[cmbMedicineId.SelectedIndex]["unit"].ToString();
                dtpMfgDate.Text = objdt.Rows[cmbMedicineId.SelectedIndex]["mfgdate"].ToString();
                dtpExpDate.Text = objdt.Rows[cmbMedicineId.SelectedIndex]["expdate"].ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            panel1.Enabled = true;
            panel1.Visible = true;
            txtMedicineID.Visible = true;
            cmbMedicineId.Visible = false;
            txtMedicineName.BorderStyle = BorderStyle.Fixed3D;
            txtMedicineID.Text = "";
            txtMedicineName.Text = "";
            txtPrice.Text = "";
            txtUnit.Text = "";
            cmbCompanyId.Text = "";
            dtpExpDate.Text = "";
            dtpMfgDate.Text = "";
            cmbMedicineId.Text = "";
            txtMedicineName.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                if (txtMedicineID.Text == "")
                {
                    MessageBox.Show("Please enter medicine id !");
                    txtMedicineID.Focus();
                }
                else if (txtMedicineName.Text == "")
                {
                    MessageBox.Show("Please enter medicine name !");
                    txtMedicineName.Focus();
                }
                else if (cmbCompanyId.Text == "")
                {
                    MessageBox.Show("Please select company id !");
                    cmbCompanyId.Focus();
                }
                else if (txtPrice.Text == "")
                {
                    MessageBox.Show("Please enter medicine price !");
                    txtPrice.Focus();
                }
                else if (txtUnit.Text == "")
                {
                    MessageBox.Show("Please enter no. of units");
                    txtUnit.Focus();
                }
                else if (dtpExpDate.Text == "")
                {
                    MessageBox.Show("Please enter Mfg. date !");
                    dtpMfgDate.Focus();
                }
                else if (dtpExpDate.Text == "")
                {
                    MessageBox.Show("Please enter Exp. date !");
                    dtpExpDate.Focus();
                }
                else
                {
                    objdbmanager = new DBManager();
                    objdt = new DataTable();
                    objdt = objdbmanager.GetData("select * from medicine where medicineid='" + txtMedicineID.Text + "' ");

                    if (objdt.Rows.Count > 0)
                    {
                        MessageBox.Show("Medicine id already exist.");
                        txtMedicineID.Text = "";
                        txtMedicineID.Focus();
                    }
                    else
                    {
                        objdbmanager = new DBManager();
                        objdbmanager.EXESQL("insert into medicine (medicineid, medicinename, companyid, price, unit, mfgdate, expdate) values('" + txtMedicineID.Text + "', '" + txtMedicineName.Text + "', '" + cmbCompanyId.Text + "', '" + txtPrice.Text + "', '" + txtUnit.Text + "', '" + dtpMfgDate.Value.ToShortDateString() + "', '" + dtpExpDate.Value.ToShortDateString() + "') ");
                        MessageBox.Show("Record inserted successfully !");

                        groupBox6.Enabled = false;
                        groupBox5.Enabled = false;
                        panel1.Enabled = false;
                        txtMedicineName.Enabled = false;
                        txtMedicineID.Text = "";
                        txtMedicineName.Text = "";
                        txtPrice.Text = "";
                        txtUnit.Text = "";
                        cmbCompanyId.Text = "";
                        dtpExpDate.Text = "";
                        dtpMfgDate.Text = "";
                    }
                }
            }
            else if (mode == "Update")
            {

                if (cmbMedicineId.Text == "")
                {
                    MessageBox.Show("Please select medicine id !");
                    cmbMedicineId.Focus();
                }
                else if (txtMedicineName.Text == "")
                {
                    MessageBox.Show("Please enter medicine name !");
                    txtMedicineName.Focus();
                }
                else if (cmbCompanyId.Text == "")
                {
                    MessageBox.Show("Please select company id !");
                    cmbCompanyId.Focus();
                }
                else if (txtPrice.Text == "")
                {
                    MessageBox.Show("Please enter medicine price !");
                    txtPrice.Focus();
                }
                else if (txtUnit.Text == "")
                {
                    MessageBox.Show("Please enter no. of units");
                    txtUnit.Focus();
                }
                else if (dtpExpDate.Text == "")
                {
                    MessageBox.Show("Please enter Mfg. date !");
                    dtpMfgDate.Focus();
                }
                else if (dtpExpDate.Text == "")
                {
                    MessageBox.Show("Please enter Exp. date !");
                    dtpExpDate.Focus();
                }
                else
                {
                    objdbmanager = new DBManager();
                    objdbmanager.EXESQL("update medicine set companyid='" + cmbCompanyId.Text + "', price='" + txtPrice.Text + "', unit='" + txtUnit.Text + "', mfgdate='" + dtpMfgDate.Value.ToShortDateString() + "', expdate='" + dtpExpDate.Value.ToShortDateString() + "' where medicineid='" + cmbMedicineId.Text + "'");
                    MessageBox.Show("Record Updated successfully !");

                    groupBox6.Enabled = false;
                    groupBox5.Enabled = false;
                    panel1.Enabled = false;
                    cmbMedicineId.Text = "";
                    txtMedicineName.Text = "";
                    txtPrice.Text = "";
                    txtUnit.Text = "";
                    cmbCompanyId.Text = "";
                    dtpExpDate.Text = "";
                    dtpMfgDate.Text = "";
                }
            }
            else if (mode == "Delete")
            {
                objdbmanager = new DBManager();
                objdbmanager.EXESQL("delete from medicine where medicineid='" + cmbMedicineId.Text + "'");
                MessageBox.Show("Record Deleted successfully !");

                groupBox6.Enabled = false;
                groupBox5.Enabled = false;
                panel1.Enabled = false;
                cmbMedicineId.Text = "";
                txtMedicineName.Text = "";
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            panel1.Enabled = true;
            panel1.Visible = true;
            txtMedicineName.Enabled = false;
            txtMedicineID.Visible = false;
            cmbMedicineId.Visible = true;
            txtMedicineName.BorderStyle = BorderStyle.None;
            txtMedicineID.Text = "";
            txtMedicineName.Text = "";
            txtPrice.Text = "";
            txtUnit.Text = "";
            cmbCompanyId.Text = "";
            dtpExpDate.Text = "";
            dtpMfgDate.Text = "";
            cmbMedicineId.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            panel1.Visible = false;
            txtMedicineID.Visible = false;
            cmbMedicineId.Visible = true;
            txtMedicineName.BorderStyle = BorderStyle.None;
            txtMedicineID.Text = "";
            txtMedicineName.Text = "";
            txtPrice.Text = "";
            txtUnit.Text = "";
            cmbCompanyId.Text = "";
            dtpExpDate.Text = "";
            dtpMfgDate.Text = "";
            cmbMedicineId.Text = "";
            txtMedicineName.Enabled = false;
        }

        

        private void cmbMedicineId_Click(object sender, EventArgs e)
        {
            cmbCompanyId.Items.Clear();
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from medicine");
            
            cmbMedicineId.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbMedicineId.Items.Add(dr["medicineid"].ToString());
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMedicineId_SelectedIndexChanged(object sender, EventArgs e)
        {
            objdt = new DataTable();
            objdbmanager = new DBManager();
            objdt = objdbmanager.GetData("select * from medicine where medicineid='" + cmbMedicineId.Text + "' ");

            txtMedicineName.Text=objdt.Rows[0]["medicinename"].ToString();
            cmbCompanyId.Text = objdt.Rows[0]["companyid"].ToString();
            txtPrice.Text = objdt.Rows[0]["price"].ToString();
            txtUnit.Text = objdt.Rows[0]["unit"].ToString();
            dtpMfgDate.Value = Convert.ToDateTime(objdt.Rows[0]["mfgdate"]);
            dtpExpDate.Value = Convert.ToDateTime(objdt.Rows[0]["expdate"]);
            
        }
    }
}
