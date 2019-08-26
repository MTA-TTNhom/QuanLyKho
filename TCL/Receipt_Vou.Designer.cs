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

        }

        #endregion
    }
}