namespace MedicalShopManagement
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeduction = new System.Windows.Forms.TextBox();
            this.txtNetSalary = new System.Windows.Forms.TextBox();
            this.txtNumberOfLeaves = new System.Windows.Forms.TextBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.dtpDateOfSalary = new System.Windows.Forms.DateTimePicker();
            this.lblNetSalary = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.lblNumberOfLeaves = new System.Windows.Forms.Label();
            this.lblDeduction = new System.Windows.Forms.Label();
            this.lblDateOfSalary = new System.Windows.Forms.Label();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAllowence = new System.Windows.Forms.TextBox();
            this.lblAllowence = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDeduction);
            this.groupBox1.Controls.Add(this.txtNetSalary);
            this.groupBox1.Controls.Add(this.txtNumberOfLeaves);
            this.groupBox1.Controls.Add(this.txtBasicSalary);
            this.groupBox1.Controls.Add(this.txtEmployeeName);
            this.groupBox1.Controls.Add(this.dtpDateOfSalary);
            this.groupBox1.Controls.Add(this.lblNetSalary);
            this.groupBox1.Controls.Add(this.lblEmployeeID);
            this.groupBox1.Controls.Add(this.lblEmployeeName);
            this.groupBox1.Controls.Add(this.lblBasicSalary);
            this.groupBox1.Controls.Add(this.lblNumberOfLeaves);
            this.groupBox1.Controls.Add(this.lblDeduction);
            this.groupBox1.Controls.Add(this.lblDateOfSalary);
            this.groupBox1.Controls.Add(this.cmbEmployeeID);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtDeduction
            // 
            this.txtDeduction.Location = new System.Drawing.Point(289, 281);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(128, 26);
            this.txtDeduction.TabIndex = 33;
            this.txtDeduction.TextChanged += new System.EventHandler(this.txtDeduction_TextChanged);
            // 
            // txtNetSalary
            // 
            this.txtNetSalary.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNetSalary.Enabled = false;
            this.txtNetSalary.Location = new System.Drawing.Point(289, 321);
            this.txtNetSalary.Name = "txtNetSalary";
            this.txtNetSalary.Size = new System.Drawing.Size(128, 26);
            this.txtNetSalary.TabIndex = 32;
            // 
            // txtNumberOfLeaves
            // 
            this.txtNumberOfLeaves.Location = new System.Drawing.Point(289, 194);
            this.txtNumberOfLeaves.Name = "txtNumberOfLeaves";
            this.txtNumberOfLeaves.Size = new System.Drawing.Size(128, 26);
            this.txtNumberOfLeaves.TabIndex = 30;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBasicSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasicSalary.Location = new System.Drawing.Point(289, 154);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(128, 26);
            this.txtBasicSalary.TabIndex = 28;
            this.txtBasicSalary.TextChanged += new System.EventHandler(this.txtBasicSalary_TextChanged);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeName.Location = new System.Drawing.Point(287, 112);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(197, 26);
            this.txtEmployeeName.TabIndex = 27;
            // 
            // dtpDateOfSalary
            // 
            this.dtpDateOfSalary.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfSalary.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfSalary.Location = new System.Drawing.Point(289, 22);
            this.dtpDateOfSalary.Name = "dtpDateOfSalary";
            this.dtpDateOfSalary.Size = new System.Drawing.Size(128, 26);
            this.dtpDateOfSalary.TabIndex = 26;
            // 
            // lblNetSalary
            // 
            this.lblNetSalary.AutoSize = true;
            this.lblNetSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetSalary.Location = new System.Drawing.Point(20, 320);
            this.lblNetSalary.Name = "lblNetSalary";
            this.lblNetSalary.Size = new System.Drawing.Size(104, 22);
            this.lblNetSalary.TabIndex = 24;
            this.lblNetSalary.Text = "Net Salary";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(20, 65);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(122, 22);
            this.lblEmployeeID.TabIndex = 23;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(20, 108);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(154, 22);
            this.lblEmployeeName.TabIndex = 22;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicSalary.Location = new System.Drawing.Point(20, 152);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(122, 22);
            this.lblBasicSalary.TabIndex = 21;
            this.lblBasicSalary.Text = "Basic Salary";
            // 
            // lblNumberOfLeaves
            // 
            this.lblNumberOfLeaves.AutoSize = true;
            this.lblNumberOfLeaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfLeaves.Location = new System.Drawing.Point(20, 194);
            this.lblNumberOfLeaves.Name = "lblNumberOfLeaves";
            this.lblNumberOfLeaves.Size = new System.Drawing.Size(172, 22);
            this.lblNumberOfLeaves.TabIndex = 20;
            this.lblNumberOfLeaves.Text = "Number of Leaves";
            // 
            // lblDeduction
            // 
            this.lblDeduction.AutoSize = true;
            this.lblDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeduction.Location = new System.Drawing.Point(20, 279);
            this.lblDeduction.Name = "lblDeduction";
            this.lblDeduction.Size = new System.Drawing.Size(100, 22);
            this.lblDeduction.TabIndex = 19;
            this.lblDeduction.Text = "Deduction";
            // 
            // lblDateOfSalary
            // 
            this.lblDateOfSalary.AutoSize = true;
            this.lblDateOfSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfSalary.Location = new System.Drawing.Point(20, 24);
            this.lblDateOfSalary.Name = "lblDateOfSalary";
            this.lblDateOfSalary.Size = new System.Drawing.Size(138, 22);
            this.lblDateOfSalary.TabIndex = 17;
            this.lblDateOfSalary.Text = "Date of Salary";
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Location = new System.Drawing.Point(289, 65);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(128, 28);
            this.cmbEmployeeID.TabIndex = 25;
            this.cmbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeID_SelectedIndexChanged);
            this.cmbEmployeeID.Click += new System.EventHandler(this.cmbEmployeeID_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(13, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(292, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(98, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAllowence
            // 
            this.txtAllowence.Location = new System.Drawing.Point(303, 252);
            this.txtAllowence.Name = "txtAllowence";
            this.txtAllowence.Size = new System.Drawing.Size(128, 26);
            this.txtAllowence.TabIndex = 31;
            // 
            // lblAllowence
            // 
            this.lblAllowence.AutoSize = true;
            this.lblAllowence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowence.Location = new System.Drawing.Point(33, 250);
            this.lblAllowence.Name = "lblAllowence";
            this.lblAllowence.Size = new System.Drawing.Size(101, 22);
            this.lblAllowence.TabIndex = 30;
            this.lblAllowence.Text = "Allowence";
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(530, 463);
            this.Controls.Add(this.txtAllowence);
            this.Controls.Add(this.lblAllowence);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNetSalary;
        private System.Windows.Forms.TextBox txtNumberOfLeaves;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.DateTimePicker dtpDateOfSalary;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private System.Windows.Forms.Label lblNetSalary;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Label lblNumberOfLeaves;
        private System.Windows.Forms.Label lblDeduction;
        private System.Windows.Forms.Label lblDateOfSalary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDeduction;
        private System.Windows.Forms.TextBox txtAllowence;
        private System.Windows.Forms.Label lblAllowence;

    }
}