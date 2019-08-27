using System.Windows.Forms;

namespace QLKVCGT.GUI
{
    partial class ListReceipt_Vou
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel panel1;

        public Label label16 { get; private set; }

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
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpkDayOfReceipt_Vou = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvListBill = new DevExpress.XtraGrid.GridControl();
            this.dgvBillView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.tbNgGiao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDateOfBill = new System.Windows.Forms.TextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbNumOfBill = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEmployeesID = new System.Windows.Forms.TextBox();
            this.tbEmployeesName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvBillDetail = new DevExpress.XtraGrid.GridControl();
            this.dgvBillDetailView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetailView)).BeginInit();
            this.SuspendLayout();

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 578);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(644, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 576);
            this.panel3.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpkDayOfReceipt_Vou);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(1, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(753, 571);
            this.panel6.TabIndex = 0;
            // 
            // dtpkDayOfReceipt_Vou
            // 
            this.dtpkDayOfReceipt_Vou.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDayOfReceipt_Vou.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDayOfReceipt_Vou.Location = new System.Drawing.Point(499, 54);
            this.dtpkDayOfReceipt_Vou.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkDayOfReceipt_Vou.Name = "dtpkDayOfReceipt_Vou";
            this.dtpkDayOfReceipt_Vou.Size = new System.Drawing.Size(127, 23);
            this.dtpkDayOfReceipt_Vou.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(339, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 21);
            this.label16.TabIndex = 56;
            this.label16.Text = "Tìm kiếm theo ngày:";

            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(236, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 23);
            this.label15.TabIndex = 18;
            this.label15.Text = "Danh sách phiếu nhập";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvListBill);
            this.panel8.Location = new System.Drawing.Point(5, 128);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(746, 441);
            this.panel8.TabIndex = 0;
            // 
            // dgvListBill
            // 
            this.dgvListBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListBill.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListBill.Location = new System.Drawing.Point(0, 0);
            this.dgvListBill.MainView = this.dgvBillView;
            this.dgvListBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListBill.Name = "dgvListBill";
            this.dgvListBill.Size = new System.Drawing.Size(746, 441);
            this.dgvListBill.TabIndex = 0;
            this.dgvListBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBillView});

        }
        #endregion
    }
}