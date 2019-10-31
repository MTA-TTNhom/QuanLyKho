namespace QLKVCGT.GUI
{
    partial class AddEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctListEmployees = new DevExpress.XtraGrid.GridControl();
            this.dgvListEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpkDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbbSex = new System.Windows.Forms.ComboBox();
            this.pnlHide = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdStore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPrivilege = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbTelephoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctListEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).BeginInit();
            this.panel7.SuspendLayout();
            this.pnlHide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(3, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 591);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(265, 457);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 39);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(187, 383);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 39);
            this.btnEdit.TabIndex = 80;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(341, 383);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 39);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(102, 457);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 39);
            this.btnCancel.TabIndex = 78;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(26, 383);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 39);
            this.btnAdd.TabIndex = 77;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctListEmployees);
            this.panel2.Location = new System.Drawing.Point(478, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 480);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gctListEmployees
            // 
            this.gctListEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gctListEmployees.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gctListEmployees.Location = new System.Drawing.Point(0, 0);
            this.gctListEmployees.MainView = this.dgvListEmployees;
            this.gctListEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gctListEmployees.Name = "gctListEmployees";
            this.gctListEmployees.Size = new System.Drawing.Size(872, 480);
            this.gctListEmployees.TabIndex = 0;
            this.gctListEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvListEmployees});
            // 
            // dgvListEmployees
            // 
            this.dgvListEmployees.GridControl = this.gctListEmployees;
            this.dgvListEmployees.Name = "dgvListEmployees";
            this.dgvListEmployees.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpkDateOfBirth);
            this.panel7.Controls.Add(this.cbbSex);
            this.panel7.Controls.Add(this.pnlHide);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.tbID);
            this.panel7.Controls.Add(this.tbTelephoneNumber);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.tbUserName);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.tbCountry);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.tbName);
            this.panel7.Location = new System.Drawing.Point(19, 52);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(443, 326);
            this.panel7.TabIndex = 2;
            // 
            // dtpkDateOfBirth
            // 
            this.dtpkDateOfBirth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateOfBirth.Location = new System.Drawing.Point(138, 132);
            this.dtpkDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkDateOfBirth.Name = "dtpkDateOfBirth";
            this.dtpkDateOfBirth.Size = new System.Drawing.Size(203, 23);
            this.dtpkDateOfBirth.TabIndex = 72;
            // 
            // cbbSex
            // 
            this.cbbSex.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbSex.Location = new System.Drawing.Point(138, 100);
            this.cbbSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(203, 25);
            this.cbbSex.TabIndex = 71;
            // 
            // pnlHide
            // 
            this.pnlHide.Controls.Add(this.label5);
            this.pnlHide.Controls.Add(this.tbIdStore);
            this.pnlHide.Controls.Add(this.label2);
            this.pnlHide.Controls.Add(this.cbbArea);
            this.pnlHide.Controls.Add(this.label1);
            this.pnlHide.Controls.Add(this.cbbPrivilege);
            this.pnlHide.Location = new System.Drawing.Point(15, 224);
            this.pnlHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHide.Name = "pnlHide";
            this.pnlHide.Size = new System.Drawing.Size(330, 90);
            this.pnlHide.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 73;
            this.label5.Text = "Quầy:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbIdStore
            // 
            this.tbIdStore.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdStore.Location = new System.Drawing.Point(123, 60);
            this.tbIdStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdStore.Name = "tbIdStore";
            this.tbIdStore.Size = new System.Drawing.Size(203, 23);
            this.tbIdStore.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 71;
            this.label2.Text = "Khu Vực:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbArea
            // 
            this.cbbArea.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbArea.FormattingEnabled = true;
            this.cbbArea.Items.AddRange(new object[] {
            "Khu A",
            "Khu B",
            "Khu C",
            "Khu D"});
            this.cbbArea.Location = new System.Drawing.Point(123, 31);
            this.cbbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbArea.Name = "cbbArea";
            this.cbbArea.Size = new System.Drawing.Size(203, 25);
            this.cbbArea.TabIndex = 70;
            this.cbbArea.SelectedIndexChanged += new System.EventHandler(this.cbbArea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 69;
            this.label1.Text = "Phân quyền:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbPrivilege
            // 
            this.cbbPrivilege.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPrivilege.FormattingEnabled = true;
            this.cbbPrivilege.Items.AddRange(new object[] {
            "Nhân viên",
            "Trưởng quầy",
            "Trưởng khu"});
            this.cbbPrivilege.Location = new System.Drawing.Point(123, 2);
            this.cbbPrivilege.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPrivilege.Name = "cbbPrivilege";
            this.cbbPrivilege.Size = new System.Drawing.Size(203, 25);
            this.cbbPrivilege.TabIndex = 0;
            this.cbbPrivilege.SelectedIndexChanged += new System.EventHandler(this.cbbPrivilege_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 68;
            this.label3.Text = "Số điện thoại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 66;
            this.label4.Text = "Mã số:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(138, 8);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(203, 23);
            this.tbID.TabIndex = 65;
            // 
            // tbTelephoneNumber
            // 
            this.tbTelephoneNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelephoneNumber.Location = new System.Drawing.Point(138, 191);
            this.tbTelephoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelephoneNumber.Name = "tbTelephoneNumber";
            this.tbTelephoneNumber.Size = new System.Drawing.Size(203, 23);
            this.tbTelephoneNumber.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(15, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 54;
            this.label9.Text = "UserName:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(138, 38);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(203, 23);
            this.tbUserName.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(15, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 21);
            this.label16.TabIndex = 56;
            this.label16.Text = "Tên nhân viên:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(15, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 21);
            this.label17.TabIndex = 60;
            this.label17.Text = "Ngày sinh:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(15, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 21);
            this.label10.TabIndex = 62;
            this.label10.Text = "Quê quán:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountry.Location = new System.Drawing.Point(138, 162);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(203, 23);
            this.tbCountry.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(15, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 21);
            this.label18.TabIndex = 58;
            this.label18.Text = "Giới tính:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(138, 68);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(203, 23);
            this.tbName.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(636, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 22);
            this.label6.TabIndex = 82;
            this.label6.Text = "THAY ĐỔI THÔNG TIN NHÂN VIÊN";
            // 
            // AddEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 609);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddEmployees";
            this.Text = "AddEmployees";
            this.Load += new System.EventHandler(this.AddEmployees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctListEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlHide.ResumeLayout(false);
            this.pnlHide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctListEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvListEmployees;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbTelephoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbName;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Panel pnlHide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSex;
        private System.Windows.Forms.ComboBox cbbPrivilege;
        private System.Windows.Forms.DateTimePicker dtpkDateOfBirth;
        private System.Windows.Forms.Label label6;
    }
}