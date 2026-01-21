namespace MedicalShopManagement
{
    partial class Medicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicine));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtMedicineID = new System.Windows.Forms.TextBox();
            this.lblname1 = new System.Windows.Forms.Label();
            this.lblemployeeid = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.lbladdress = new System.Windows.Forms.Label();
            this.dtpMfgDate = new System.Windows.Forms.DateTimePicker();
            this.lblMfgDate = new System.Windows.Forms.Label();
            this.cmbCompanyId = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.cmbMedicineId = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btndelete);
            this.groupBox4.Controls.Add(this.btnupdate);
            this.groupBox4.Controls.Add(this.btnadd);
            this.groupBox4.Location = new System.Drawing.Point(16, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 84);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(380, 23);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(142, 43);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(194, 23);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(142, 43);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(12, 23);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(142, 43);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMedicineName.Location = new System.Drawing.Point(248, 57);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(274, 26);
            this.txtMedicineName.TabIndex = 11;
            // 
            // txtMedicineID
            // 
            this.txtMedicineID.Location = new System.Drawing.Point(248, 18);
            this.txtMedicineID.Name = "txtMedicineID";
            this.txtMedicineID.Size = new System.Drawing.Size(186, 26);
            this.txtMedicineID.TabIndex = 7;
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname1.Location = new System.Drawing.Point(6, 56);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(152, 22);
            this.lblname1.TabIndex = 6;
            this.lblname1.Text = "Medicine Name ";
            this.lblname1.Click += new System.EventHandler(this.lblname1_Click);
            // 
            // lblemployeeid
            // 
            this.lblemployeeid.AutoSize = true;
            this.lblemployeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployeeid.Location = new System.Drawing.Point(6, 19);
            this.lblemployeeid.Name = "lblemployeeid";
            this.lblemployeeid.Size = new System.Drawing.Size(120, 22);
            this.lblemployeeid.TabIndex = 0;
            this.lblemployeeid.Text = "Medicine ID ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtMedicineID);
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Controls.Add(this.txtMedicineName);
            this.groupBox6.Controls.Add(this.lblname1);
            this.groupBox6.Controls.Add(this.lblemployeeid);
            this.groupBox6.Controls.Add(this.cmbMedicineId);
            this.groupBox6.Location = new System.Drawing.Point(16, 87);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(537, 314);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpExpDate);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Controls.Add(this.dtpMfgDate);
            this.panel1.Controls.Add(this.lblMfgDate);
            this.panel1.Controls.Add(this.cmbCompanyId);
            this.panel1.Controls.Add(this.lblUnit);
            this.panel1.Controls.Add(this.lblExpDate);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtUnit);
            this.panel1.Location = new System.Drawing.Point(7, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 216);
            this.panel1.TabIndex = 45;
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpDate.Location = new System.Drawing.Point(240, 172);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(125, 26);
            this.dtpExpDate.TabIndex = 53;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(3, 13);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(124, 22);
            this.lbladdress.TabIndex = 44;
            this.lbladdress.Text = "Company ID \r\n";
            // 
            // dtpMfgDate
            // 
            this.dtpMfgDate.CustomFormat = "dd/MM/yyyy";
            this.dtpMfgDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMfgDate.Location = new System.Drawing.Point(240, 130);
            this.dtpMfgDate.MinDate = new System.DateTime(1753, 1, 27, 0, 0, 0, 0);
            this.dtpMfgDate.Name = "dtpMfgDate";
            this.dtpMfgDate.Size = new System.Drawing.Size(125, 26);
            this.dtpMfgDate.TabIndex = 52;
            // 
            // lblMfgDate
            // 
            this.lblMfgDate.AutoSize = true;
            this.lblMfgDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMfgDate.Location = new System.Drawing.Point(7, 134);
            this.lblMfgDate.Name = "lblMfgDate";
            this.lblMfgDate.Size = new System.Drawing.Size(102, 22);
            this.lblMfgDate.TabIndex = 45;
            this.lblMfgDate.Text = "Mfg. Date ";
            // 
            // cmbCompanyId
            // 
            this.cmbCompanyId.FormattingEnabled = true;
            this.cmbCompanyId.Location = new System.Drawing.Point(240, 8);
            this.cmbCompanyId.Name = "cmbCompanyId";
            this.cmbCompanyId.Size = new System.Drawing.Size(183, 28);
            this.cmbCompanyId.TabIndex = 51;
            this.cmbCompanyId.SelectedIndexChanged += new System.EventHandler(this.cmbCompanyId_SelectedIndexChanged);
            this.cmbCompanyId.Click += new System.EventHandler(this.cmbCompanyId_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(6, 93);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(52, 22);
            this.lblUnit.TabIndex = 46;
            this.lblUnit.Text = "Unit ";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.Location = new System.Drawing.Point(7, 176);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(104, 22);
            this.lblExpDate.TabIndex = 50;
            this.lblExpDate.Text = "Exp. Date ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(6, 51);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 22);
            this.lblPrice.TabIndex = 47;
            this.lblPrice.Text = "Price ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(240, 47);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(183, 26);
            this.txtPrice.TabIndex = 49;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(240, 89);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(183, 26);
            this.txtUnit.TabIndex = 48;
            // 
            // cmbMedicineId
            // 
            this.cmbMedicineId.FormattingEnabled = true;
            this.cmbMedicineId.Location = new System.Drawing.Point(248, 17);
            this.cmbMedicineId.Name = "cmbMedicineId";
            this.cmbMedicineId.Size = new System.Drawing.Size(186, 28);
            this.cmbMedicineId.TabIndex = 44;
            this.cmbMedicineId.SelectedIndexChanged += new System.EventHandler(this.cmbMedicineId_SelectedIndexChanged);
            this.cmbMedicineId.Click += new System.EventHandler(this.cmbMedicineId_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btncancel);
            this.groupBox5.Controls.Add(this.btnsave);
            this.groupBox5.Location = new System.Drawing.Point(16, 402);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(537, 75);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(274, 19);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(142, 43);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(109, 19);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(142, 43);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(567, 489);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine";
            this.Load += new System.EventHandler(this.Medicine_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtMedicineID;
        private System.Windows.Forms.Label lblname1;
        private System.Windows.Forms.Label lblemployeeid;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cmbMedicineId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.DateTimePicker dtpMfgDate;
        private System.Windows.Forms.Label lblMfgDate;
        private System.Windows.Forms.ComboBox cmbCompanyId;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUnit;
    }
}