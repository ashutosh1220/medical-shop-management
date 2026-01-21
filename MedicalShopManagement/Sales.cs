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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void lblname1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;
        string mode;

        private void clear_form()
        {
            txtCustomerID.Text = "";
            cmbcustomerid.Text = "";
            txtAddress.Text = "";
            txtCustomerName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtvoucherno.Text = "";
            txtQuantity.Text = "";
            txtAmount.Text = "0";
            txtUnitPrice.Text = "0";
            cmbcompanyid2.Text = "";
            cmbMedicineID.Text = "";
            txtCustomerName.Text = "";
            cmbVoucherNumber.Text = "";

            lbCompanyID.Items.Clear();
            lbMedicineID.Items.Clear();
            lbUnitPrice.Items.Clear();
            lbQuantity.Items.Clear();
            lbAmount.Items.Clear();

            txtTotalAmount.Text = "0";
            txtDiscount.Text = "";
            txtFinalAmount.Text = "0";
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();
 
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            rbtNew.Checked = true;
            txtTotalAmount.Enabled = false;
            txtFinalAmount.Enabled = false;
            txtAmount.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtTotalAmount.Text = "0";
            txtFinalAmount.Text = "0";
            txtAmount.Text = "0";
        }

        private void lbAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCompanyID.SelectedIndex = lbAmount.SelectedIndex;
            lbMedicineID.SelectedIndex = lbAmount.SelectedIndex;
            lbUnitPrice.SelectedIndex = lbAmount.SelectedIndex;
            lbQuantity.SelectedIndex = lbAmount.SelectedIndex;
        }

        private void rbtNew_Click(object sender, EventArgs e)
        {
            txtCustomerID.Visible = true;
            cmbcustomerid.Visible = false;
            txtCustomerID.Enabled = true;
            txtCustomerName.Enabled = true;
            clear_form();
        }

        private void rbtnExisting_Click(object sender, EventArgs e)
        {
            txtCustomerID.Visible = false;
            cmbcustomerid.Visible = true;
            txtCustomerName.Enabled = false;
            clear_form();
        }

        private void rbtNew_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerID.Visible = true;
            cmbcustomerid.Visible = false;
            clear_form();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            panel1.Visible = true;
            panel2.Visible = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            txtCustomerID.Enabled = true;
            txtCustomerName.Enabled = true;
            txtvoucherno.Visible = true;
            cmbVoucherNumber.Visible = false;
            txtCustomerID.Visible = true;
            cmbcustomerid.Visible = false;
            clear_form();

            txtCustomerID.BorderStyle = BorderStyle.Fixed3D;
            txtCustomerName.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                
                if (txtvoucherno.Text == "")
                {
                    MessageBox.Show("Please enter voucher number !");
                }
                else if (txtCustomerID.Text == "")
                {
                    MessageBox.Show("Please enter customer id !");
                }
                else if (txtCustomerName.Text == "")
                {
                    MessageBox.Show("Please enter customer name !");
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please enter address !");
                }
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Please enter phone !");
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please enter email !");
                }
                else if (lbCompanyID.Items.Count < 1)
                {
                    MessageBox.Show("Please add at least one transaction !");
                }
                else if (txtDiscount.Text == "")
                {
                    MessageBox.Show("Please enter discount !");
                }
                else
                {
                    objdbmanager = new DBManager();
                    objdt = new DataTable();

                    objdt = objdbmanager.GetData("select * from sale where voucher_number='" + txtvoucherno.Text + "'");

                    if (objdt.Rows.Count > 0)
                    {
                        MessageBox.Show("Voucher number already exist !");
                        txtvoucherno.Text = "";
                        txtvoucherno.Focus();
                    }
                    else
                    {
                        

                        if (rbtNew.Checked == true)
                        {
                            objdbmanager = new DBManager();
                            objdt = new DataTable();
                            objdbmanager.EXESQL("insert into customer (id, name, address, phone, email) values('" + txtCustomerID.Text + "', '" + txtCustomerName.Text + "', '" + txtAddress.Text + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "')");
                        }

                        string customerid;
                        if (rbtNew.Checked == true)
                        {
                            customerid = txtCustomerID.Text;
                        }
                        else
                        {
                            customerid = cmbcustomerid.Text;
                        }

                        objdbmanager = new DBManager();
                        objdbmanager.EXESQL("insert into sale(voucher_number,voucher_date,customer_id,total_amount,discount,final_amount)values('" + txtvoucherno.Text + "','" + dtpDate.Value.ToShortDateString().ToString() + "','" + customerid + "','" + txtTotalAmount.Text + "','" + txtDiscount.Text + "','" + txtFinalAmount.Text + "')");

                        int i;

                        for (i = 0; i < lbCompanyID.Items.Count; i++)
                        {
                            objdbmanager = new DBManager();
                            objdbmanager.EXESQL("insert into tempsale(voucher_number,companyid,medicineid,quantity,amount) values('" + txtvoucherno.Text + "','" + lbCompanyID.Items[i].ToString() + "','" + lbMedicineID.Items[i].ToString() + "','" + lbQuantity.Items[i].ToString() + "','" + lbAmount.Items[i].ToString() + "')");
                        }
                         
                        MessageBox.Show("Record inserted successfully !");

                        clear_form();
                    }
                }
            }
            else if (mode == "Update")
            {

                objdbmanager = new DBManager();
                objdbmanager.EXESQL("update sale set voucher_date='" + dtpDate.Value.ToShortDateString().ToString() + "', total_amount='" + txtTotalAmount.Text + "', discount='" + txtDiscount.Text + "',final_amount='" + txtFinalAmount.Text + "' where voucher_number ='" + cmbVoucherNumber.Text + "'" );
                objdbmanager.EXESQL("delete tempsale where voucher_number ='" + cmbVoucherNumber.Text + "'" );
                 


                int i;
                for (i = 0; i < lbCompanyID.Items.Count; i++)
                {
                    objdbmanager = new DBManager();
                    objdbmanager.EXESQL("insert into tempsale(voucher_number,companyid,medicineid,quantity,amount) values('" + cmbVoucherNumber.Text + "','" + lbCompanyID.Items[i].ToString() + "','" + lbMedicineID.Items[i].ToString() + "','" + lbQuantity.Items[i].ToString() + "','" + lbAmount.Items[i].ToString() + "')" );
                     
                }

                 
                MessageBox.Show("Record Updated successfully !");

                clear_form();
            }
        }

        private void cmbcustomerid_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            cmbcustomerid.Items.Clear();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from customer" );           
            foreach (DataRow dr in objdt.Rows) 
            {
                cmbcustomerid.Items.Add(dr["id"].ToString());
            }
        }

        private void cmbcustomerid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomerID.Text = objdt.Rows[cmbcustomerid.SelectedIndex]["id"].ToString();
            txtCustomerName.Text = objdt.Rows[cmbcustomerid.SelectedIndex]["name"].ToString();
            txtAddress.Text = objdt.Rows[cmbcustomerid.SelectedIndex]["address"].ToString();
            txtEmail.Text = objdt.Rows[cmbcustomerid.SelectedIndex]["email"].ToString();
            txtPhone.Text = objdt.Rows[cmbcustomerid.SelectedIndex]["phone"].ToString();
           
        }


        private void cmbMedicineID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnitPrice.Text = objdt.Rows[cmbMedicineID.SelectedIndex]["price"].ToString();
            txtQuantity.Text = "";
            txtAmount.Text = "0";
            txtQuantity.Focus();
        }

        private void cmbMedicineID_Click(object sender, EventArgs e)
        {
            cmbMedicineID.Items.Clear();
            objdt = new DataTable();
            objdbmanager = new DBManager();
            objdt = objdbmanager.GetData("select * from medicine where companyid='" + cmbcompanyid2.Text + "'" );
            
            foreach (DataRow dr in objdt.Rows)
            {
                cmbMedicineID.Items.Add(dr["medicineid"].ToString());
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            int numericValue;
            bool isNumber = int.TryParse(txtQuantity.Text, out numericValue);
            if (txtQuantity.Text != "" && isNumber)
            {
                txtAmount.Text = Convert.ToString(Convert.ToInt32(txtUnitPrice.Text) * Convert.ToInt32(txtQuantity.Text));
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {

            if(cmbcompanyid2.Text == ""){
                MessageBox.Show("Please select Company id !");
            }
            else if (cmbMedicineID.Text == "")
            {
                MessageBox.Show("Please select Medicine id !");
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please enter quantity !");
            }
            else
            {
                lbCompanyID.Items.Add(cmbcompanyid2.Text);
                lbMedicineID.Items.Add(cmbMedicineID.Text);
                lbUnitPrice.Items.Add(txtUnitPrice.Text);
                lbQuantity.Items.Add(txtQuantity.Text);
                lbAmount.Items.Add(txtAmount.Text);

                if (txtTotalAmount.Text != "")
                {
                    txtTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) + Convert.ToInt32(txtAmount.Text));
                }
            }

        }

        private void lbCompanyID_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbMedicineID.SelectedIndex = lbCompanyID.SelectedIndex;
            lbUnitPrice.SelectedIndex = lbCompanyID.SelectedIndex;
            lbQuantity.SelectedIndex = lbCompanyID.SelectedIndex;
            lbAmount.SelectedIndex = lbCompanyID.SelectedIndex;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i;
            i = lbCompanyID.SelectedIndex;

            if (i >= 0)
            {
                txtTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) - Convert.ToInt32(lbAmount.Items[lbAmount.SelectedIndex].ToString()));

                lbCompanyID.Items.RemoveAt(i);
                lbMedicineID.Items.RemoveAt(i);
                lbUnitPrice.Items.RemoveAt(i);
                lbQuantity.Items.RemoveAt(i);
                lbAmount.Items.RemoveAt(i);
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            int discount;
            int numericValue;
            bool isNumber = int.TryParse(txtDiscount.Text, out numericValue);

            if (txtDiscount.Text != "" && isNumber)
            {
                discount = Convert.ToInt32(txtTotalAmount.Text) * Convert.ToInt32(txtDiscount.Text) / 100;
                txtFinalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) - discount);
            }
        }

        private void lbMedicineID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCompanyID.SelectedIndex = lbMedicineID.SelectedIndex;
            lbUnitPrice.SelectedIndex = lbMedicineID.SelectedIndex;
            lbQuantity.SelectedIndex = lbMedicineID.SelectedIndex;
            lbAmount.SelectedIndex = lbMedicineID.SelectedIndex;
        }

        private void lbUnitPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCompanyID.SelectedIndex = lbUnitPrice.SelectedIndex;
            lbMedicineID.SelectedIndex = lbUnitPrice.SelectedIndex;
            lbQuantity.SelectedIndex = lbUnitPrice.SelectedIndex;
            lbAmount.SelectedIndex = lbUnitPrice.SelectedIndex;
        }

        private void lbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCompanyID.SelectedIndex = lbQuantity.SelectedIndex;
            lbMedicineID.SelectedIndex = lbQuantity.SelectedIndex;
            lbUnitPrice.SelectedIndex = lbQuantity.SelectedIndex;
            lbAmount.SelectedIndex = lbQuantity.SelectedIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            panel1.Visible = false;
            panel2.Visible = false;
            groupBox2.Enabled = true;
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            txtCustomerID.Enabled = false;
            txtCustomerName.Enabled = false;
            txtvoucherno.Visible = false;
            cmbVoucherNumber.Visible = true;
            txtCustomerID.Visible = true;
            cmbcustomerid.Visible = false;
            clear_form();

            txtCustomerID.BorderStyle = BorderStyle.None;
            txtCustomerName.BorderStyle = BorderStyle.None;
        }

        private void cmbVoucherNumber_Click(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select *from sale" );
 
            cmbVoucherNumber.Items.Clear();

            foreach(DataRow dr in objdt.Rows){
                cmbVoucherNumber.Items.Add(dr["voucher_number"].ToString());
            }
        }

        private void cmbVoucherNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDate.Text=objdt.Rows[cmbVoucherNumber.SelectedIndex]["voucher_date"].ToString();
            txtCustomerID.Text = objdt.Rows[cmbVoucherNumber.SelectedIndex]["customer_id"].ToString();
            txtTotalAmount.Text = objdt.Rows[cmbVoucherNumber.SelectedIndex]["total_amount"].ToString();
            txtDiscount.Text = objdt.Rows[cmbVoucherNumber.SelectedIndex]["discount"].ToString();
            txtFinalAmount.Text = objdt.Rows[cmbVoucherNumber.SelectedIndex]["final_amount"].ToString();

            objdbmanager = new DBManager();
            DataTable objdt2 = new DataTable();
            objdt2 = objdbmanager.GetData("select *from Tempsale where voucher_number='" + cmbVoucherNumber.Text + "'" );

            lbCompanyID.Items.Clear();
            lbQuantity.Items.Clear();
            lbAmount.Items.Clear();
            lbMedicineID.Items.Clear();
            lbUnitPrice.Items.Clear();

            foreach (DataRow dr in objdt2.Rows)
            {
               
                lbCompanyID.Items.Add(dr["companyid"].ToString());
                lbMedicineID.Items.Add(dr["medicineid"].ToString());
                lbQuantity.Items.Add(dr["quantity"].ToString());
                lbAmount.Items.Add(dr["amount"].ToString());

                string medicineid;
                medicineid = dr["medicineid"].ToString();

                objdbmanager = new DBManager();
                DataTable objdt3 = new DataTable();
                objdt3 = objdbmanager.GetData("select price from medicine where medicineid='"+medicineid+"' " );
                

                if (objdt3.Rows.Count > 0)
                {
                    lbUnitPrice.Items.Add(objdt3.Rows[0]["price"].ToString());
                }

                cmbcompanyid2.Text = "";
                cmbMedicineID.Text = "";
                txtUnitPrice.Text = "";
                txtQuantity.Text = "";
                txtAmount.Text = "0";
            }
            
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != "" && mode == "Update")
            {
                objdbmanager = new DBManager();
                DataTable objdt1 = new DataTable();
                objdt1 = objdbmanager.GetData("select name from customer where id='" + txtCustomerID.Text + "'" );
               
                txtCustomerName.Text = objdt1.Rows[0]["name"].ToString();
            }
        }

        private void cmbcompanyid2_Click(object sender, EventArgs e)
        {
            cmbcompanyid2.Items.Clear();
            objdbmanager = new DBManager();
            objdt = new DataTable();
            objdt = objdbmanager.GetData("select * from company" );
           
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcompanyid2.Items.Add(dr["companyid"].ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmbcompanyid2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMedicineID.Items.Clear();
            cmbMedicineID.Text = "";
            txtUnitPrice.Text = "";
            txtQuantity.Text = "";
            txtAmount.Text = "0";
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            int discount, numericValue;
            bool isNumber = int.TryParse(txtDiscount.Text, out numericValue);

            if (txtDiscount.Text != "" && isNumber)
            {
                discount = Convert.ToInt32(txtTotalAmount.Text) * Convert.ToInt32(txtDiscount.Text) / 100;
                txtFinalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) - discount);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
