namespace QLKVCGT.GUI
{
    partial class ListIssue_Vou
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpkDayOfIssue_Vou = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvListBill = new DevExpress.XtraGrid.GridControl();
            this.dgvBillView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.tbNgNhan = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(4, 3);
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
            this.panel6.Controls.Add(this.dtpkDayOfIssue_Vou);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(753, 571);
            this.panel6.TabIndex = 0;
            // 
            // dtpkDayOfIssue_Vou
            // 
            this.dtpkDayOfIssue_Vou.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDayOfIssue_Vou.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDayOfIssue_Vou.Location = new System.Drawing.Point(499, 54);
            this.dtpkDayOfIssue_Vou.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkDayOfIssue_Vou.Name = "dtpkDayOfIssue_Vou";
            this.dtpkDayOfIssue_Vou.Size = new System.Drawing.Size(127, 23);
            this.dtpkDayOfIssue_Vou.TabIndex = 57;
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
            this.label15.Text = "Danh sách phiếu xuất";
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
            // 
            // dgvBillView
            // 
            this.dgvBillView.GridControl = this.dgvListBill;
            this.dgvBillView.Name = "dgvBillView";
            this.dgvBillView.OptionsBehavior.ReadOnly = true;
            this.dgvBillView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvBillView_FocusedRowChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 574);
            this.panel2.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.tbTotalPrice);
            this.panel7.Controls.Add(this.tbNgNhan);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.tbDateOfBill);
            this.panel7.Controls.Add(this.tbCustomerID);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.tbCustomerName);
            this.panel7.Controls.Add(this.tbNumOfBill);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.tbEmployeesID);
            this.panel7.Controls.Add(this.tbEmployeesName);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(3, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(630, 184);
            this.panel7.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Tổng tiền:";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPrice.Location = new System.Drawing.Point(125, 147);
            this.tbTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(186, 23);
            this.tbTotalPrice.TabIndex = 59;
            // 
            // tbNgNhan
            // 
            this.tbNgNhan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgNhan.Location = new System.Drawing.Point(442, 147);
            this.tbNgNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNgNhan.Name = "tbNgNhan";
            this.tbNgNhan.Size = new System.Drawing.Size(186, 23);
            this.tbNgNhan.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(323, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 62;
            this.label5.Text = "Người nhận :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "Chi tiết phiếu xuất";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(323, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ngày xuất:";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(3, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 21);
            this.label14.TabIndex = 42;
            this.label14.Text = "Mã khách hàng:";
            // 
            // tbDateOfBill
            // 
            this.tbDateOfBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateOfBill.Location = new System.Drawing.Point(442, 117);
            this.tbDateOfBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDateOfBill.Name = "tbDateOfBill";
            this.tbDateOfBill.Size = new System.Drawing.Size(186, 23);
            this.tbDateOfBill.TabIndex = 51;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerID.Location = new System.Drawing.Point(125, 59);
            this.tbCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(186, 23);
            this.tbCustomerID.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Số phiếu xuất:";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(442, 59);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(186, 23);
            this.tbCustomerName.TabIndex = 43;
            // 
            // tbNumOfBill
            // 
            this.tbNumOfBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumOfBill.Location = new System.Drawing.Point(125, 117);
            this.tbNumOfBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumOfBill.Name = "tbNumOfBill";
            this.tbNumOfBill.Size = new System.Drawing.Size(186, 23);
            this.tbNumOfBill.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(323, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 21);
            this.label13.TabIndex = 44;
            this.label13.Text = "Tên khách hàng:";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(323, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 21);
            this.label11.TabIndex = 48;
            this.label11.Text = "Tên nhân viên:";
            // 
            // tbEmployeesID
            // 
            this.tbEmployeesID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeesID.Location = new System.Drawing.Point(125, 89);
            this.tbEmployeesID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeesID.Name = "tbEmployeesID";
            this.tbEmployeesID.Size = new System.Drawing.Size(186, 23);
            this.tbEmployeesID.TabIndex = 45;
            // 
            // tbEmployeesName
            // 
            this.tbEmployeesName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeesName.Location = new System.Drawing.Point(442, 89);
            this.tbEmployeesName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeesName.Name = "tbEmployeesName";
            this.tbEmployeesName.Size = new System.Drawing.Size(186, 23);
            this.tbEmployeesName.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(3, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 21);
            this.label12.TabIndex = 46;
            this.label12.Text = "Mã nhân viên:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvBillDetail);
            this.panel4.Location = new System.Drawing.Point(3, 201);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(631, 370);
            this.panel4.TabIndex = 0;
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBillDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvBillDetail.MainView = this.dgvBillDetailView;
            this.dgvBillDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.Size = new System.Drawing.Size(631, 370);
            this.dgvBillDetail.TabIndex = 0;
            this.dgvBillDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBillDetailView});
            // 
            // dgvBillDetailView
            // 
            this.dgvBillDetailView.GridControl = this.dgvBillDetail;
            this.dgvBillDetailView.Name = "dgvBillDetailView";
            this.dgvBillDetailView.OptionsBehavior.ReadOnly = true;
            // 
            // ListIssue_Vou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Name = "ListIssue_Vou";
            this.Text = "ListIssue_Vou";
            this.Load += new System.EventHandler(this.ListIssue_Vou_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetailView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dtpkDayOfIssue_Vou;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraGrid.GridControl dgvListBill;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBillView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.TextBox tbNgNhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDateOfBill;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbNumOfBill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEmployeesID;
        private System.Windows.Forms.TextBox tbEmployeesName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl dgvBillDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBillDetailView;
    }
}