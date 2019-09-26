using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCL
{
    public partial class Supplier_Store : Form
    {
        public Supplier_Store()
        {
            InitializeComponent();
        }
		
        private void label1_Click(object sender, EventArgs e)
        {
            /*indexdsa
             * cho nay de check login 
             * dsdsa*/
        }
		            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gctEmployees = new DevExpress.XtraGrid.GridControl();
            this.dgvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbEmployeesName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmployeesID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.dtpkDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
        private int ChangeInfo()
        {
            int _id = Convert.ToInt32(tbID.Text.Trim(' '));
            DateTime _dateOfBirth = dtpkDateOfBirth.Value;
            string _name = tbName.Text.Trim(' ');
            string _userName = tbUserName.Text.Trim(' ');
            int _sex;
            if (cbbSex.Text == "Nam") _sex = 1;
            else _sex = 0;
            float _salary = (float)Convert.ToDouble(tbSalary.Text);
            string _telephoneNumber = tbTelephoneNumber.Text.Trim(' ');
            string _country = tbCountry.Text.Trim(' ');
            return AcountInfoControl.Instance.ChangeAcount(_id, _name, _dateOfBirth, _sex, _userName, _country, _telephoneNumber);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChangeInfo() == 1)
            {
                MessageBox.Show("Thành công!");
            }
            load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new LOGIN());
            //Application.Run(new Form1());
        }
		
        private void label1_Click(object sender, EventArgs e)
        {
            /*indexdsa
             * cho nay de check login 
             * dsdsa*/
        }
		            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gctEmployees = new DevExpress.XtraGrid.GridControl();
            this.dgvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbEmployeesName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmployeesID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.dtpkDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
        private int ChangeInfo()
        {
            int _id = Convert.ToInt32(tbID.Text.Trim(' '));
            DateTime _dateOfBirth = dtpkDateOfBirth.Value;
            string _name = tbName.Text.Trim(' ');
            string _userName = tbUserName.Text.Trim(' ');
            int _sex;
            if (cbbSex.Text == "Nam") _sex = 1;
            else _sex = 0;
            float _salary = (float)Convert.ToDouble(tbSalary.Text);
            string _telephoneNumber = tbTelephoneNumber.Text.Trim(' ');
            string _country = tbCountry.Text.Trim(' ');
            return AcountInfoControl.Instance.ChangeAcount(_id, _name, _dateOfBirth, _sex, _userName, _country, _telephoneNumber);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChangeInfo() == 1)
            {
                MessageBox.Show("Thành công!");
            }
            load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new LOGIN());
            //Application.Run(new Form1());
        }
		
        private void label1_Click(object sender, EventArgs e)
        {
            /*indexdsa
             * cho nay de check login 
             * dsdsa*/
        }
		            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gctEmployees = new DevExpress.XtraGrid.GridControl();
            this.dgvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbEmployeesName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmployeesID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.dtpkDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
        private int ChangeInfo()
        {
            int _id = Convert.ToInt32(tbID.Text.Trim(' '));
            DateTime _dateOfBirth = dtpkDateOfBirth.Value;
            string _name = tbName.Text.Trim(' ');
            string _userName = tbUserName.Text.Trim(' ');
            int _sex;
            if (cbbSex.Text == "Nam") _sex = 1;
            else _sex = 0;
            float _salary = (float)Convert.ToDouble(tbSalary.Text);
            string _telephoneNumber = tbTelephoneNumber.Text.Trim(' ');
            string _country = tbCountry.Text.Trim(' ');
            return AcountInfoControl.Instance.ChangeAcount(_id, _name, _dateOfBirth, _sex, _userName, _country, _telephoneNumber);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChangeInfo() == 1)
            {
                MessageBox.Show("Thành công!");
            }
            load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new LOGIN());
            //Application.Run(new Form1());
        }
    }
}
