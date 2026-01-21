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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        SqlConnection objconn;
        DataTable objdt;
        DBManager objdbmanager;
        string mode;

        private void clear_form()
        {
            cmbCompanyID.Text = "";
            txtVoucherNumber.Text = "";
            cmbMedicineID.Text = "";
            txtQuantity.Text = "";
            txtAmount.Text = "0";
            txtUnitPrice.Text = "";
            cmbSupplierId.Text = "";
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            cmbVoucherNumber.Text = "";

            lbCompanyID.Items.Clear();
            lbMedicineID.Items.Clear();
            lbUnitPrice.Items.Clear();
            lbQuantity.Items.Clear();
            lbAmount.Items.Clear();

            cmbSupplierId.Text = "";
            txtTotalAmount.Text = "0";
            txtDiscount.Text = "";
            txtFinalAmount.Text = "0";
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            DBConnection dbconn = new DBConnection();
            objconn = dbconn.GetConnection();

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox6.Enabled = false;
            txtSupplierID.Enabled = false;
            txtSupplierName.Visible = true;
            txtUnitPrice.Enabled = false;
            txtTotalAmount.Enabled = false;
            txtFinalAmount.Enabled = false;
            txtSupplierID.Visible = false;
            cmbSupplierId.Visible = true;
            txtAmount.Enabled = false;
            txtSupplierName.Enabled = false;
            txtSupplierName.Enabled = false;
            clear_form();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox2.Enabled = true;
            groupBox1.Enabled = true;
            groupBox4.Enabled = true;
            groupBox6.Enabled = true;
            txtSupplierID.Visible = true;
            cmbSupplierId.Visible = false;
            cmbVoucherNumber.Visible = true;
            txtVoucherNumber.Visible = false;
            panel1.Visible = true;
            clear_form();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox6.Enabled = true;
            txtSupplierID.Visible = false;
            cmbSupplierId.Visible = true;
            cmbVoucherNumber.Visible = false;
            txtVoucherNumber.Visible = true;
            panel1.Visible = true;
            clear_form();
        }

       

        private void cmbSupplierId_Click(object sender, EventArgs e)
        {
            cmbSupplierId.Items.Clear();
            objdt = new DataTable();
            objdbmanager = new DBManager();
            objdt = objdbmanager.GetData("select * from supplier" );
            
            foreach (DataRow dr in objdt.Rows)
            {
                cmbSupplierId.Items.Add(dr["supplierid"].ToString());
            }
        }

        private void lbCompanyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMedicineID.SelectedIndex = lbCompanyID.SelectedIndex;
            lbUnitPrice.SelectedIndex = lbCompanyID.SelectedIndex;
            lbQuantity.SelectedIndex = lbCompanyID.SelectedIndex;
            lbAmount.SelectedIndex = lbCompanyID.SelectedIndex;
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

        private void lbAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCompanyID.SelectedIndex = lbAmount.SelectedIndex;
            lbMedicineID.SelectedIndex = lbAmount.SelectedIndex;
            lbUnitPrice.SelectedIndex = lbAmount.SelectedIndex;
            lbQuantity.SelectedIndex = lbAmount.SelectedIndex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objdt = new DataTable();
            objdbmanager = new DBManager(); 

            if (mode == "Add")
            {
                if (txtVoucherNumber.Text == "")
                {
                    MessageBox.Show("Please enter voucher number !");
                }
                else if (cmbSupplierId.Text == "")
                {
                    MessageBox.Show("Please select supplier id !");
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
                   
                    objdt = objdbmanager.GetData("select * from purchase where voucher_number='" + txtVoucherNumber.Text + "'" );

                    if (objdt.Rows.Count > 0)
                    {
                        MessageBox.Show("Voucher number already exist !");
                        txtVoucherNumber.Text = "";
                        txtVoucherNumber.Focus();
                    }
                    else
                    {

                        objdt = new DataTable();
                        
                        objdbmanager.EXESQL("insert into purchase(voucher_number,voucher_date,supplier_id,total_amount,discount,final_amount)values('" + txtVoucherNumber.Text + "','" + dtpDate.Value.ToString() + "','" + cmbSupplierId.Text + "','" + txtTotalAmount.Text + "','" + txtDiscount.Text + "','" + txtFinalAmount.Text + "')" );
                        

                        int i;

                        for (i = 0; i < lbCompanyID.Items.Count; i++)
                        {
                            objdbmanager.EXESQL("insert into temp_purchase(voucher_number,company_id,medicine_id,quantity,amount) values('" + txtVoucherNumber.Text + "','" + lbCompanyID.Items[i].ToString() + "','" + lbMedicineID.Items[i].ToString() + "','" + lbQuantity.Items[i].ToString() + "','" + lbAmount.Items[i].ToString() + "')" );
                            
                        }
                        
                        MessageBox.Show("Record inserted successfully !");
                        clear_form();
                    }
                }
            }
            else if (mode == "Update")
            {
                objdbmanager.EXESQL("update purchase set voucher_date='" + dtpDate.Value.ToShortDateString().ToString() + "', total_amount='" + txtTotalAmount.Text + "', discount='" + txtDiscount.Text + "',final_amount='" + txtFinalAmount.Text + "' where voucher_number ='" + cmbVoucherNumber.Text + "'" );
                objdbmanager.EXESQL("delete temp_purchase where voucher_number ='" + cmbVoucherNumber.Text + "'" );
           
                int i;

                for (i = 0; i < lbCompanyID.Items.Count; i++)
                {
                    objdbmanager.EXESQL("insert into temp_purchase(voucher_number,company_id,medicine_id,quantity,amount) values('" + cmbVoucherNumber.Text + "','" + lbCompanyID.Items[i].ToString() + "','" + lbMedicineID.Items[i].ToString() + "','" + lbQuantity.Items[i].ToString() + "','" + lbAmount.Items[i].ToString() + "')" );
                    
                }

                MessageBox.Show("Record Updated successfully !");
                clear_form();
            }
        }

        private void cmbCompanyID_Click(object sender, EventArgs e)
        {
            objdt = new DataTable();
            objdbmanager = new DBManager();
            objdt = objdbmanager.GetData("select * from company" );

            cmbCompanyID.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbCompanyID.Items.Add(dr["companyid"].ToString());
            }
        }

        private void cmbMedicineID_Click(object sender, EventArgs e)
        {
            objdt = new DataTable();
            objdbmanager = new DBManager();

            objdt = objdbmanager.GetData("select * from medicine where companyid='"+cmbCompanyID.Text+"' " );

            cmbMedicineID.Items.Clear();
            foreach (DataRow dr in objdt.Rows)
            {
                cmbMedicineID.Items.Add(dr["medicineid"].ToString());
            }
        }

        private void cmbMedicineID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnitPrice.Text=objdt.Rows[cmbMedicineID.SelectedIndex]["price"].ToString();
            txtQuantity.Text = "";
            txtAmount.Text = "0";
            txtQuantity.Focus();
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
            if (cmbCompanyID.Text == "")
            {
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
                totalamounttxt = txtTotalAmount.Text;
                lbCompanyID.Items.Add(cmbCompanyID.Text);
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

        string totalamounttxt;
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            int discount, numericValue;
            bool isNumber = int.TryParse(txtDiscount.Text, out numericValue);

            if (txtDiscount.Text != "" && isNumber)
            {
                discount = Convert.ToInt32(txtTotalAmount.Text) * Convert.ToInt32(txtDiscount.Text) / 100;
                txtFinalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) - discount);
            }
        }

        private void cmbVoucherNumber_Click(object sender, EventArgs e)
        {
            objdt = new DataTable();
            objdbmanager = new DBManager();
            objdt = objdbmanager.GetData("select * from purchase" );

            cmbVoucherNumber.Items.Clear();

            foreach (DataRow dr in objdt.Rows)
            {
                cmbVoucherNumber.Items.Add(dr["voucher_number"].ToString());
            }
        }

        private void cmbVoucherNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable objdt1 = new DataTable();
            objdbmanager = new DBManager();
            txtSupplierID.Text=objdt.Rows[cmbVoucherNumber.SelectedIndex]["supplier_id"].ToString();

            objdbmanager = new DBManager();
            objdt1 = objdbmanager.GetData("select * from supplier where supplierid='"+txtSupplierID.Text+"'" );
             
            txtSupplierName.Text = objdt1.Rows[0]["suppliername"].ToString();

            dtpDate.Text = objdt.Rows[cmbVoucherNumber.SelectedIndex]["voucher_date"].ToString();
            txtSupplierID.Text = objdt.Rows[cmbVoucherNumber.SelectedIndex]["supplier_id"].ToString();
            txtTotalAmount.Text = objdt.Rows[cmbVoucherNumber.SelectedIndex]["total_amount"].ToString();
            txtDiscount.Text = objdt.Rows[cmbVoucherNumber.SelectedIndex]["discount"].ToString();
            txtFinalAmount.Text = objdt.Rows[cmbVoucherNumber.SelectedIndex]["final_amount"].ToString();

            objdbmanager = new DBManager();
            DataTable objdt2 = new DataTable();
            objdt2 = objdbmanager.GetData("select *from temp_purchase where voucher_number='" + cmbVoucherNumber.Text + "'" );
           
            lbCompanyID.Items.Clear();
            lbQuantity.Items.Clear();
            lbAmount.Items.Clear();
            lbMedicineID.Items.Clear();
            lbUnitPrice.Items.Clear();

            foreach (DataRow dr in objdt2.Rows)
            {

                lbCompanyID.Items.Add(dr["company_id"].ToString());
                lbMedicineID.Items.Add(dr["medicine_id"].ToString());
                lbQuantity.Items.Add(dr["quantity"].ToString());
                lbAmount.Items.Add(dr["amount"].ToString());

                string medicineid;
                medicineid = dr["medicine_id"].ToString();
                objdbmanager = new DBManager();
                DataTable objdt3 = new DataTable();
                objdt3 = objdbmanager.GetData("select price from medicine where medicineid='" + medicineid + "' " );

                if (objdt3.Rows.Count > 0)
                {
                    lbUnitPrice.Items.Add(objdt3.Rows[0]["price"].ToString());
                }

                cmbCompanyID.Text = "";
                cmbMedicineID.Text = "";
                txtUnitPrice.Text = "";
                txtQuantity.Text = "";
                txtAmount.Text = "0";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCompanyID_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmbSupplierId_SelectedIndexChanged(object sender, EventArgs e)
        {
            objdbmanager = new DBManager();
            DataTable objdt = new DataTable();

            objdt = objdbmanager.GetData("select suppliername from supplier where supplierid='"+cmbSupplierId.Text+"' " );

            if (objdt.Rows.Count > 0)
            {
                txtSupplierName.Text = objdt.Rows[0]["suppliername"].ToString();
            }
        }
    }
}
