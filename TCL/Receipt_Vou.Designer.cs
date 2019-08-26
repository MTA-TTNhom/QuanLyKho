﻿namespace TCL
{
    partial class Receipt_Vou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt_Vou));
            this.nudNumOfItem = new System.Windows.Forms.NumericUpDown();
            this.btnSaveItem = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelItem = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.btnEditItem = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.tbSupplierID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotalPriceItem = new System.Windows.Forms.TextBox();
            this.btnAddSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTotalPriceBill = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gctBill = new DevExpress.XtraGrid.GridControl();
            this.dgvBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumOfItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPriceOfItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCancelSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.tbPriceOnceItem = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfItem)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudNumOfItem
            // 
            this.nudNumOfItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumOfItem.Location = new System.Drawing.Point(120, 63);
            this.nudNumOfItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudNumOfItem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumOfItem.Name = "nudNumOfItem";
            this.nudNumOfItem.Size = new System.Drawing.Size(159, 23);
            this.nudNumOfItem.TabIndex = 66;
            this.nudNumOfItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumOfItem.ValueChanged += new System.EventHandler(this.nudNumOfItem_ValueChanged);
            this.nudNumOfItem.Enter += new System.EventHandler(this.nudNumOfItem_Enter);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveItem.Appearance.Options.UseFont = true;
            this.btnSaveItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSaveItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveItem.ImageOptions.Image")));
            this.btnSaveItem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSaveItem.Location = new System.Drawing.Point(359, 139);
            this.btnSaveItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(96, 37);
            this.btnSaveItem.TabIndex = 65;
            this.btnSaveItem.Text = "Đồny ý";
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Thông tin mặt hàng";
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelItem.Appearance.Options.UseFont = true;
            this.btnCancelItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnCancelItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelItem.ImageOptions.Image")));
            this.btnCancelItem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancelItem.Location = new System.Drawing.Point(466, 140);
            this.btnCancelItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(96, 36);
            this.btnCancelItem.TabIndex = 64;
            this.btnCancelItem.Text = "Hủy";
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(293, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Giá (vnd):";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Appearance.Options.UseFont = true;
            this.btnDeleteItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnDeleteItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.ImageOptions.Image")));
            this.btnDeleteItem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDeleteItem.Location = new System.Drawing.Point(250, 140);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(96, 36);
            this.btnDeleteItem.TabIndex = 61;
            this.btnDeleteItem.Text = "Xóa";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // tbItemID
            // 
            this.tbItemID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemID.Location = new System.Drawing.Point(120, 35);
            this.tbItemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(159, 23);
            this.tbItemID.TabIndex = 45;
            this.tbItemID.TextChanged += new System.EventHandler(this.tbItemID_TextChanged);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItem.Appearance.Options.UseFont = true;
            this.btnEditItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnEditItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditItem.ImageOptions.Image")));
            this.btnEditItem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnEditItem.Location = new System.Drawing.Point(141, 140);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(96, 36);
            this.btnEditItem.TabIndex = 62;
            this.btnEditItem.Text = "Sửa";
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Appearance.Options.UseFont = true;
            this.btnAddItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAddItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.ImageOptions.Image")));
            this.btnAddItem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddItem.Location = new System.Drawing.Point(30, 140);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(96, 36);
            this.btnAddItem.TabIndex = 60;
            this.btnAddItem.Text = "Thêm";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemName.Location = new System.Drawing.Point(407, 36);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(159, 23);
            this.tbItemName.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Mã mặt hàng: *";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(4, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "Số lượng: *";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(293, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tên mặt hàng:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(293, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 56;
            this.label9.Text = "Tổng giá (vnd):";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(180, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 23);
            this.label15.TabIndex = 57;
            this.label15.Text = "Thông tin nhà cung cấp";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(296, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSupplierName.Location = new System.Drawing.Point(426, 38);
            this.tbSupplierName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.Size = new System.Drawing.Size(159, 23);
            this.tbSupplierName.TabIndex = 43;
            this.tbSupplierName.TextChanged += new System.EventHandler(this.tbSupplierName_TextChanged);
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSupplierID.Location = new System.Drawing.Point(123, 38);
            this.tbSupplierID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.Size = new System.Drawing.Size(159, 23);
            this.tbSupplierID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã nhà cung cấp:*";
            // 
            // tbTotalPriceItem
            // 
            this.tbTotalPriceItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPriceItem.Location = new System.Drawing.Point(407, 89);
            this.tbTotalPriceItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotalPriceItem.Name = "tbTotalPriceItem";
            this.tbTotalPriceItem.Size = new System.Drawing.Size(159, 23);
            this.tbTotalPriceItem.TabIndex = 55;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Appearance.Options.UseFont = true;
            this.btnAddSupplier.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAddSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.ImageOptions.Image")));
            this.btnAddSupplier.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddSupplier.Location = new System.Drawing.Point(169, 72);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(96, 37);
            this.btnAddSupplier.TabIndex = 15;
            this.btnAddSupplier.Text = "Đồny ý";
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);

        }

        #endregion
    }
}