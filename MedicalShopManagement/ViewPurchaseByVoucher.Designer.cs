namespace MedicalShopManagement
{
    partial class ViewPurchaseByVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPurchaseByVoucher));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnViewByVoucherNumber = new System.Windows.Forms.RadioButton();
            this.rbtnViewAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPurchaseByVoucherNo = new System.Windows.Forms.DataGridView();
            this.cmbVoucherNumber = new System.Windows.Forms.ComboBox();
            this.lblVoucherNumber = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseByVoucherNo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnViewByVoucherNumber);
            this.groupBox1.Controls.Add(this.rbtnViewAll);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 72);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rbtnViewByVoucherNumber
            // 
            this.rbtnViewByVoucherNumber.AutoSize = true;
            this.rbtnViewByVoucherNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnViewByVoucherNumber.Location = new System.Drawing.Point(363, 25);
            this.rbtnViewByVoucherNumber.Name = "rbtnViewByVoucherNumber";
            this.rbtnViewByVoucherNumber.Size = new System.Drawing.Size(262, 26);
            this.rbtnViewByVoucherNumber.TabIndex = 1;
            this.rbtnViewByVoucherNumber.TabStop = true;
            this.rbtnViewByVoucherNumber.Text = "View By Voucher Number";
            this.rbtnViewByVoucherNumber.UseVisualStyleBackColor = true;
            this.rbtnViewByVoucherNumber.CheckedChanged += new System.EventHandler(this.rbtnViewByVoucherNumber_CheckedChanged);
            // 
            // rbtnViewAll
            // 
            this.rbtnViewAll.AutoSize = true;
            this.rbtnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnViewAll.Location = new System.Drawing.Point(61, 25);
            this.rbtnViewAll.Name = "rbtnViewAll";
            this.rbtnViewAll.Size = new System.Drawing.Size(107, 26);
            this.rbtnViewAll.TabIndex = 0;
            this.rbtnViewAll.TabStop = true;
            this.rbtnViewAll.Text = "View All";
            this.rbtnViewAll.UseVisualStyleBackColor = true;
            this.rbtnViewAll.CheckedChanged += new System.EventHandler(this.rbtnViewAll_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPurchaseByVoucherNo);
            this.groupBox2.Controls.Add(this.cmbVoucherNumber);
            this.groupBox2.Controls.Add(this.lblVoucherNumber);
            this.groupBox2.Location = new System.Drawing.Point(18, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 352);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // dgvPurchaseByVoucherNo
            // 
            this.dgvPurchaseByVoucherNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseByVoucherNo.Location = new System.Drawing.Point(10, 69);
            this.dgvPurchaseByVoucherNo.Name = "dgvPurchaseByVoucherNo";
            this.dgvPurchaseByVoucherNo.RowTemplate.Height = 28;
            this.dgvPurchaseByVoucherNo.Size = new System.Drawing.Size(615, 262);
            this.dgvPurchaseByVoucherNo.TabIndex = 2;
            // 
            // cmbVoucherNumber
            // 
            this.cmbVoucherNumber.Location = new System.Drawing.Point(331, 25);
            this.cmbVoucherNumber.Name = "cmbVoucherNumber";
            this.cmbVoucherNumber.Size = new System.Drawing.Size(147, 28);
            this.cmbVoucherNumber.TabIndex = 1;
            this.cmbVoucherNumber.Click += new System.EventHandler(this.cmbVoucherNumber_Click);
            // 
            // lblVoucherNumber
            // 
            this.lblVoucherNumber.AutoSize = true;
            this.lblVoucherNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucherNumber.Location = new System.Drawing.Point(136, 28);
            this.lblVoucherNumber.Name = "lblVoucherNumber";
            this.lblVoucherNumber.Size = new System.Drawing.Size(159, 22);
            this.lblVoucherNumber.TabIndex = 0;
            this.lblVoucherNumber.Text = "Voucher Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnShow);
            this.groupBox3.Location = new System.Drawing.Point(18, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 69);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(407, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 43);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnShow
            // 
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(182, 20);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(142, 43);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ViewPurchaseByVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewPurchaseByVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Purchase";
            this.Load += new System.EventHandler(this.ViewPurchaseByVoucher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseByVoucherNo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnViewByVoucherNumber;
        private System.Windows.Forms.RadioButton rbtnViewAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPurchaseByVoucherNo;
        private System.Windows.Forms.ComboBox cmbVoucherNumber;
        private System.Windows.Forms.Label lblVoucherNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnShow;
    }
}