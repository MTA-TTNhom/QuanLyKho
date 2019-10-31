using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLKVCGT.Controler;

namespace QLKVCGT.GUI
{
    public partial class AddEmployees : DevExpress.XtraEditors.XtraForm
    {
        private int action;
        private int type;
        public AddEmployees()
        {
            InitializeComponent();
        }

        public void init()
        {

        }
        private void ReadOnly(bool e)
        {
            tbCountry.ReadOnly = e;
            dtpkDateOfBirth.Enabled = !e;
            tbID.ReadOnly = e;
            tbIdStore.ReadOnly = e;
            tbName.ReadOnly = e;
            cbbSex.Enabled = !e;
            tbTelephoneNumber.ReadOnly = e; 
            tbUserName.ReadOnly=e;

        }
        private void EnabledBtn(bool e)
        {
            btnAdd.Enabled = e;
            btnEdit.Enabled = e;
            btnDelete.Enabled = e;
            btnCancel.Enabled = !e;
            btnSave.Enabled = !e;
        }

        private void clear()
        {
            tbCountry.Clear();
            dtpkDateOfBirth.Value=DateTime.Now;
            tbID.Clear();
            tbIdStore.Clear();
            tbName.Clear();
            cbbSex.Text = null;
            tbTelephoneNumber.Clear();
            tbUserName.Clear();
        }
        private void loadEmployeesToDgv()
        {
            gctListEmployees.DataSource = EmployeesControl.Instance.DataSource_GetAllEmployees();
        }

        private void binding()
        {
            tbID.DataBindings.Clear();
            tbID.DataBindings.Add("Text", gctListEmployees.DataSource, "Mã");
            tbUserName.DataBindings.Clear();
            tbUserName.DataBindings.Add("Text", gctListEmployees.DataSource, "UserName");
            tbName.DataBindings.Clear();
            tbName.DataBindings.Add("Text", gctListEmployees.DataSource, "Tên");
            cbbSex.DataBindings.Clear();
            cbbSex.DataBindings.Add("Text", gctListEmployees.DataSource, "Giới tính");
            //tbSalary.DataBindings.Clear();
            //tbSalary.DataBindings.Add("Text", gctEmployees.DataSource, "HS lương");
            tbTelephoneNumber.DataBindings.Clear();
            tbTelephoneNumber.DataBindings.Add("Text", gctListEmployees.DataSource, "Số điện thoại");
            tbCountry.DataBindings.Clear();
            tbCountry.DataBindings.Add("Text", gctListEmployees.DataSource, "Quê quán");
            dtpkDateOfBirth.DataBindings.Clear();
            dtpkDateOfBirth.DataBindings.Add("Text", gctListEmployees.DataSource, "Ngày sinh");
        }

        private void AddEmployees_Load(object sender, EventArgs e)
        {
            EnabledBtn(true);
            ReadOnly(true);
            loadEmployeesToDgv();
            binding();
            pnlHide.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = 1;
            EnabledBtn(false);
            ReadOnly(false);
            tbID.ReadOnly = true;
            clear();       
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            action = 2;
            EnabledBtn(false);
            ReadOnly(true);
            tbID.ReadOnly = false;
            pnlHide.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            action = 3;
            ReadOnly(true);
            tbID.ReadOnly = false;
            EnabledBtn(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AddEmployees_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _idEmployees = tbID.Text.Trim(' ');
            string _name = tbName.Text.ToString().Trim(' ');
            string _userName = tbUserName.Text.ToString().Trim(' ');
            string _country = tbCountry.Text.ToString().Trim(' ');
            int _sex = 0;
            if (cbbSex.Text == "Nam") _sex = 1;
            DateTime _dateOfBirth = dtpkDateOfBirth.Value;
            string _telephoneNumber = tbTelephoneNumber.Text.Trim(' ');

            if (cbbPrivilege.Text == "Nhân viên") type = 4;
            else if (cbbPrivilege.Text == "Trưởng quầy") type = 3;
            else type = 2;
            string _idStore = tbIdStore.Text.Trim(' ');
            string _idArea = "";
            if (cbbArea.Text == "Khu A") _idArea = "KV0001";
            else if (cbbArea.Text == "Khu B") _idArea = "KV0002";
            else if (cbbArea.Text == "Khu C") _idArea = "KV0003";
            else _idArea = "KV0004";

            if (action==1)
            {
                if(_name=="" || _userName=="" || _country=="")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên!");
                    return;
                }
                try
                {
                    EmployeesControl.Instance.InsertEmployees(_name, _userName, _country, _dateOfBirth, _sex, _telephoneNumber);
                }
                catch { MessageBox.Show("Trùng Username"); }
  

            }
            if(action==2)
            {
                EmployeesControl.Instance.UpdateEmployees(_idEmployees, type, _idStore, _idArea);

            }
            if(action==3)
            {
                EmployeesControl.Instance.DeleteEmployees(_idEmployees);
            }
            AddEmployees_Load(sender, e);
        }

        private void cbbPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbPrivilege.Text=="Trưởng khu")
            {
                tbIdStore.ReadOnly = true;
                cbbArea.Enabled = true;
            }
            else if(cbbPrivilege.Text=="Trưởng quầy")
            {
                cbbArea.Enabled = false;
                tbIdStore.ReadOnly = false;
            }
            else
            {
                cbbArea.Enabled = false;
                tbIdStore.ReadOnly = false;
            }
            
        }

        private void cbbArea_SelectedIndexChanged(object sender, EventArgs e)
        {            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}