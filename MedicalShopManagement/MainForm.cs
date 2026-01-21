using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace MedicalShopManagement
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public MainForm()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRegister objUsrReg = new UserRegister();
            objUsrReg.Show();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicine objmed = new Medicine();
            objmed.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company objCompany = new Company();
            objCompany.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier objSupplier = new Supplier();
            objSupplier.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer objCustomer = new Customer();
            objCustomer.Show();

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales objSales = new Sales();
            objSales.Show();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary objSalary = new Salary();
            objSalary.Show();
        }

        private void byIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEmployeeByID objViewEmployee = new ViewEmployeeByID();
            objViewEmployee.Show();
        }

        private void medicineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewMedicineByID objViewMedicine = new ViewMedicineByID();
            objViewMedicine.Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewCustomerByID objViewCustomerById = new ViewCustomerByID();
            objViewCustomerById.Show();
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewSupplierByID objViewSupplire = new ViewSupplierByID();
            objViewSupplire.Show();
        }

        private void companyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewCompanyByID objViewCompany = new ViewCompanyByID();
            objViewCompany.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSaleByDate objViewSale = new ViewSaleByDate();
            objViewSale.Show();
        }

        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewPurchaseByDate objViewPurchase = new ViewPurchaseByDate();
            objViewPurchase.Show();
        }

        private void customerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewByCustomerName objViewCustomerByName = new ViewByCustomerName();
            objViewCustomerByName.Show();
        }

        private void supplierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewBySupplierName objViewBySupplierName = new ViewBySupplierName();
            objViewBySupplierName.Show();
        }

        private void companyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewByCompanyName objViewByCompanyName = new ViewByCompanyName();
            objViewByCompanyName.Show();
        }

        private void medicineToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewByMedicineName objViewByMedicineName = new ViewByMedicineName();
            objViewByMedicineName.Show();
        }

        private void saleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewSaleByVoucher objViewSale = new ViewSaleByVoucher();
            objViewSale.Show();
        }

        private void purchaseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewPurchaseByVoucher objpurchase = new ViewPurchaseByVoucher();
            objpurchase.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword objChangePassword = new ChangePassword();
            objChangePassword.Show();
        }

        private void salaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewSalaryByDate objsalary = new ViewSalaryByDate();
            objsalary.Show();
        }

        private void byVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPurchaseByVoucher objViewPurchase = new ViewPurchaseByVoucher();
            objViewPurchase.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase objPurchase = new Purchase();
            objPurchase.Show();
        }

        private void expiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewExpiry objmedicineexpiry = new ViewExpiry();
            objmedicineexpiry.Show();

        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.medical_desktop;
        }   

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "calc.exe";
            p.Start();
        }

        private void onScreenKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void calanderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar objcal = new calendar();
            objcal.Show();
        }
    }
}
