namespace MedicalShopManagement
{
    partial class ViewByMedicineName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewByMedicineName));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnViewByID = new System.Windows.Forms.RadioButton();
            this.rbtnViewAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMedicineByName = new System.Windows.Forms.DataGridView();
            this.cmbMedicineName = new System.Windows.Forms.ComboBox();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineByName)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnViewByID);
            this.groupBox1.Controls.Add(this.rbtnViewAll);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rbtnViewByID
            // 
            this.rbtnViewByID.AutoSize = true;
            this.rbtnViewByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnViewByID.Location = new System.Drawing.Point(417, 25);
            this.rbtnViewByID.Name = "rbtnViewByID";
            this.rbtnViewByID.Size = new System.Drawing.Size(164, 26);
            this.rbtnViewByID.TabIndex = 1;
            this.rbtnViewByID.TabStop = true;
            this.rbtnViewByID.Text = "View By Name";
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
            this.groupBox2.Controls.Add(this.dgvMedicineByName);
            this.groupBox2.Controls.Add(this.cmbMedicineName);
            this.groupBox2.Controls.Add(this.lblMedicineName);
            this.groupBox2.Location = new System.Drawing.Point(18, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 352);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dgvMedicineByName
            // 
            this.dgvMedicineByName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicineByName.Location = new System.Drawing.Point(10, 69);
            this.dgvMedicineByName.Name = "dgvMedicineByName";
            this.dgvMedicineByName.RowTemplate.Height = 28;
            this.dgvMedicineByName.Size = new System.Drawing.Size(615, 262);
            this.dgvMedicineByName.TabIndex = 2;
            // 
            // cmbMedicineName
            // 
            this.cmbMedicineName.Location = new System.Drawing.Point(331, 25);
            this.cmbMedicineName.Name = "cmbMedicineName";
            this.cmbMedicineName.Size = new System.Drawing.Size(199, 28);
            this.cmbMedicineName.TabIndex = 1;
            this.cmbMedicineName.Click += new System.EventHandler(this.cmbMedicineName_Click);
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineName.Location = new System.Drawing.Point(150, 26);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(146, 22);
            this.lblMedicineName.TabIndex = 0;
            this.lblMedicineName.Text = "Medicine Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btncancel);
            this.groupBox3.Controls.Add(this.btnShow);
            this.groupBox3.Location = new System.Drawing.Point(18, 448);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 69);
            this.groupBox3.TabIndex = 12;
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
            // ViewByMedicineName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewByMedicineName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Medicine";
            this.Load += new System.EventHandler(this.ViewByMedicineName_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineByName)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnViewByID;
        private System.Windows.Forms.RadioButton rbtnViewAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMedicineByName;
        private System.Windows.Forms.ComboBox cmbMedicineName;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnShow;
    }
}