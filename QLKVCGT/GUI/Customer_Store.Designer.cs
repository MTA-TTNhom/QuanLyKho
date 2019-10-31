namespace QLKVCGT.GUI
{
    partial class Customer_Store
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctCustomer = new DevExpress.XtraGrid.GridControl();
            this.dgvCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbTax_Ident_Num = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 585);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(254, 177);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 403);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctCustomer);
            this.panel2.Location = new System.Drawing.Point(3, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 366);
            this.panel2.TabIndex = 60;
            // 
            // gctCustomer
            // 
            this.gctCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctCustomer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gctCustomer.Location = new System.Drawing.Point(0, 0);
            this.gctCustomer.MainView = this.dgvCustomer;
            this.gctCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gctCustomer.Name = "gctCustomer";
            this.gctCustomer.Size = new System.Drawing.Size(664, 366);
            this.gctCustomer.TabIndex = 0;
            this.gctCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvCustomer});
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.GridControl = this.gctCustomer;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.OptionsBehavior.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "Danh sách khách hàng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.tbFax);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.tbEmail);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.tbCustomerID);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tbCustomerName);
            this.panel4.Controls.Add(this.tbTax_Ident_Num);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.tbAddress);
            this.panel4.Controls.Add(this.tbPhone);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(254, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(669, 170);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(349, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 79;
            this.label6.Text = "Fax:";
            // 
            // tbFax
            // 
            this.tbFax.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFax.Location = new System.Drawing.Point(473, 95);
            this.tbFax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(159, 23);
            this.tbFax.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(45, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 77;
            this.label5.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(168, 129);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(159, 23);
            this.tbEmail.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Thông tin chi tiết khách hàng";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(46, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 21);
            this.label14.TabIndex = 64;
            this.label14.Text = "Mã khách hàng:";
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerID.Location = new System.Drawing.Point(169, 38);
            this.tbCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(159, 23);
            this.tbCustomerID.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(46, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 72;
            this.label4.Text = "Mã số thuế:";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(472, 38);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(159, 23);
            this.tbCustomerName.TabIndex = 65;
            // 
            // tbTax_Ident_Num
            // 
            this.tbTax_Ident_Num.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTax_Ident_Num.Location = new System.Drawing.Point(169, 96);
            this.tbTax_Ident_Num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTax_Ident_Num.Name = "tbTax_Ident_Num";
            this.tbTax_Ident_Num.Size = new System.Drawing.Size(159, 23);
            this.tbTax_Ident_Num.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(350, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 21);
            this.label13.TabIndex = 66;
            this.label13.Text = "Tên khách hàng:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(350, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 21);
            this.label11.TabIndex = 70;
            this.label11.Text = "Điện thoại:";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(169, 67);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(159, 23);
            this.tbAddress.TabIndex = 67;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(472, 67);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(159, 23);
            this.tbPhone.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(46, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 21);
            this.label12.TabIndex = 68;
            this.label12.Text = "Địa chỉ:";
            // 
            // Customer_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 591);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customer_Store";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.Customer_Store_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbTax_Ident_Num;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
    }
}