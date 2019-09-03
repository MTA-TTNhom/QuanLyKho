namespace TCL
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
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tbPriceOnceItem);
            this.panel10.Controls.Add(this.nudNumOfItem);
            this.panel10.Controls.Add(this.btnSaveItem);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.btnCancelItem);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.btnDeleteItem);
            this.panel10.Controls.Add(this.tbItemID);
            this.panel10.Controls.Add(this.btnEditItem);
            this.panel10.Controls.Add(this.btnAddItem);
            this.panel10.Controls.Add(this.tbItemName);
            this.panel10.Controls.Add(this.tbTotalPriceItem);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Location = new System.Drawing.Point(1, 167);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(587, 214);
            this.panel10.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 602);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(4, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1342, 597);
            this.panel2.TabIndex = 57;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.tbTotalPriceBill);
            this.panel5.Location = new System.Drawing.Point(8, 389);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(590, 101);
            this.panel5.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(134, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 21);
            this.label13.TabIndex = 67;
            this.label13.Text = "Tổng tiền thanh toán:";
            // 
            // tbTotalPriceBill
            // 
            this.tbTotalPriceBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPriceBill.Location = new System.Drawing.Point(289, 17);
            this.tbTotalPriceBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotalPriceBill.Name = "tbTotalPriceBill";
            this.tbTotalPriceBill.Size = new System.Drawing.Size(159, 23);
            this.tbTotalPriceBill.TabIndex = 66;
            this.tbTotalPriceBill.Text = "0";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Location = new System.Drawing.Point(605, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(706, 572);
            this.panel4.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "Thông tin phiếu nhập kho";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.gctBill);
            this.panel8.Location = new System.Drawing.Point(26, 123);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(669, 436);
            this.panel8.TabIndex = 0;
            // 
            // gctBill
            // 
            this.gctBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctBill.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gctBill.Location = new System.Drawing.Point(0, 0);
            this.gctBill.MainView = this.dgvBill;
            this.gctBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gctBill.Name = "gctBill";
            this.gctBill.Size = new System.Drawing.Size(669, 436);
            this.gctBill.TabIndex = 0;
            this.gctBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBill});
            // 
            // dgvBill
            // 
            this.dgvBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ItemName,
            this.Price,
            this.NumOfItem,
            this.TotalPriceOfItem,
            this.itemId});
            this.dgvBill.GridControl = this.gctBill;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.OptionsBehavior.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.Caption = "Tên mặt hàng";
            this.ItemName.FieldName = "itemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.Visible = true;
            this.ItemName.VisibleIndex = 1;
            this.ItemName.Width = 163;
            // 
            // Price
            // 
            this.Price.Caption = "Giá (vnd)";
            this.Price.FieldName = "price";
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 2;
            this.Price.Width = 92;
            // 
            // NumOfItem
            // 
            this.NumOfItem.Caption = "Số lượng (gói)";
            this.NumOfItem.FieldName = "numOfItem";
            this.NumOfItem.Name = "NumOfItem";
            this.NumOfItem.Visible = true;
            this.NumOfItem.VisibleIndex = 3;
            this.NumOfItem.Width = 94;
            // 
            // TotalPriceOfItem
            // 
            this.TotalPriceOfItem.Caption = "Tổng giá (vnd)";
            this.TotalPriceOfItem.FieldName = "totalPriceOfItem";
            this.TotalPriceOfItem.Name = "TotalPriceOfItem";
            this.TotalPriceOfItem.Visible = true;
            this.TotalPriceOfItem.VisibleIndex = 4;
            this.TotalPriceOfItem.Width = 165;
            // 
            // itemId
            // 
            this.itemId.Caption = "Mã mặt hàng";
            this.itemId.FieldName = "itemId";
            this.itemId.Name = "itemId";
            this.itemId.Visible = true;
            this.itemId.VisibleIndex = 0;
            this.itemId.Width = 97;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Location = new System.Drawing.Point(8, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 383);
            this.panel3.TabIndex = 57;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.tbSupplierName);
            this.panel9.Controls.Add(this.tbSupplierID);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.btnCancelSupplier);
            this.panel9.Controls.Add(this.btnAddSupplier);
            this.panel9.Location = new System.Drawing.Point(0, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(587, 161);
            this.panel9.TabIndex = 65;
            // 
            // btnCancelSupplier
            // 
            this.btnCancelSupplier.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSupplier.Appearance.Options.UseFont = true;
            this.btnCancelSupplier.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnCancelSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelSupplier.ImageOptions.Image")));
            this.btnCancelSupplier.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancelSupplier.Location = new System.Drawing.Point(309, 71);
            this.btnCancelSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelSupplier.Name = "btnCancelSupplier";
            this.btnCancelSupplier.Size = new System.Drawing.Size(96, 37);
            this.btnCancelSupplier.TabIndex = 59;
            this.btnCancelSupplier.Text = "Hủy";
            this.btnCancelSupplier.Click += new System.EventHandler(this.btnCancelSupplier_Click);
            // 
            // tbPriceOnceItem
            // 
            this.tbPriceOnceItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceOnceItem.Location = new System.Drawing.Point(407, 62);
            this.tbPriceOnceItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPriceOnceItem.Name = "tbPriceOnceItem";
            this.tbPriceOnceItem.Size = new System.Drawing.Size(159, 23);
            this.tbPriceOnceItem.TabIndex = 67;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(247, 49);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 36);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Receipt_Vou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 739);
            this.Controls.Add(this.panel1);
            this.Name = "Receipt_Vou";
            this.Text = "Phiếu nhập kho";
            this.Load += new System.EventHandler(this.Reciept_Vou_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfItem)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudNumOfItem;
        private DevExpress.XtraEditors.SimpleButton btnSaveItem;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnCancelItem;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnDeleteItem;
        private System.Windows.Forms.TextBox tbItemID;
        private DevExpress.XtraEditors.SimpleButton btnEditItem;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.TextBox tbSupplierID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotalPriceItem;
        private DevExpress.XtraEditors.SimpleButton btnAddSupplier;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTotalPriceBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraGrid.GridControl gctBill;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBill;
        private DevExpress.XtraGrid.Columns.GridColumn ItemName;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn NumOfItem;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPriceOfItem;
        private DevExpress.XtraGrid.Columns.GridColumn itemId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.SimpleButton btnCancelSupplier;
        private System.Windows.Forms.TextBox tbPriceOnceItem;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}