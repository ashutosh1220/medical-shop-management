namespace MedicalShopManagement
{
    partial class ViewCustomerByID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomerByID));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnViewByID = new System.Windows.Forms.RadioButton();
            this.rbtnViewAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCustomerByID = new System.Windows.Forms.DataGridView();
            this.cmbCustomerId = new System.Windows.Forms.ComboBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerByID)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnViewByID);
            this.groupBox1.Controls.Add(this.rbtnViewAll);
            this.groupBox1.Location = new System.Drawing.Point(28, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 72);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // rbtnViewByID
            // 
            this.rbtnViewByID.AutoSize = true;
            this.rbtnViewByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnViewByID.Location = new System.Drawing.Point(417, 25);
            this.rbtnViewByID.Name = "rbtnViewByID";
            this.rbtnViewByID.Size = new System.Drawing.Size(132, 26);
            this.rbtnViewByID.TabIndex = 1;
            this.rbtnViewByID.TabStop = true;
            this.rbtnViewByID.Text = "View By ID";
            this.rbtnViewByID.UseVisualStyleBackColor = true;
            this.rbtnViewByID.CheckedChanged += new System.EventHandler(this.rbtnViewByID_CheckedChanged);
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
            this.groupBox2.Controls.Add(this.dgvCustomerByID);
            this.groupBox2.Controls.Add(this.cmbCustomerId);
            this.groupBox2.Controls.Add(this.lblCustomerID);
            this.groupBox2.Location = new System.Drawing.Point(28, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 352);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // dgvCustomerByID
            // 
            this.dgvCustomerByID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerByID.Location = new System.Drawing.Point(10, 69);
            this.dgvCustomerByID.Name = "dgvCustomerByID";
            this.dgvCustomerByID.RowTemplate.Height = 28;
            this.dgvCustomerByID.Size = new System.Drawing.Size(615, 262);
            this.dgvCustomerByID.TabIndex = 2;
            // 
            // cmbCustomerId
            // 
            this.cmbCustomerId.Location = new System.Drawing.Point(331, 25);
            this.cmbCustomerId.Name = "cmbCustomerId";
            this.cmbCustomerId.Size = new System.Drawing.Size(147, 28);
            this.cmbCustomerId.TabIndex = 1;
            this.cmbCustomerId.Click += new System.EventHandler(this.cmbCustomerId_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(150, 26);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(120, 22);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btncancel);
            this.groupBox3.Controls.Add(this.btnShow);
            this.groupBox3.Location = new System.Drawing.Point(28, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 69);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(407, 20);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(142, 43);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
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
            // ViewCustomerByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewCustomerByID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.ViewCustomerByID_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerByID)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnViewByID;
        private System.Windows.Forms.RadioButton rbtnViewAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCustomerByID;
        private System.Windows.Forms.ComboBox cmbCustomerId;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnShow;

    }
}