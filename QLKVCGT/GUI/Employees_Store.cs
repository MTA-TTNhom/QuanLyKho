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
    public partial class Employees_Store : DevExpress.XtraEditors.XtraForm
    {
        private int action = 1;
        int idEmployees ;
        public Employees_Store()
        {
            InitializeComponent();
        }

        public void init(int _idEmployees)
        {
            idEmployees = _idEmployees;
        }
        private void Employees_Store_Load(object sender, EventArgs e)
        {
            EnabledBtn(true);
            loadData();
            ReadOnly(true);
            binding();
        }

        private void EnabledBtn(bool e)
        {
            btnAdd.Enabled = e;
            btnCancel.Enabled = !e;
            btnSave.Enabled = !e;
        }
        private void ReadOnly(bool e)
        {
            tbCountry.ReadOnly = e;
            dtpkDateOfBirth.Enabled = !e;
            tbEmployeesID.ReadOnly = e;
            tbEmployeesName.ReadOnly = e;
            tbSalary.ReadOnly = e;
            //tbSex.ReadOnly = e;
            tbPhone.ReadOnly = e;
            tbUserName.ReadOnly = e;
       
        }
        private void Clear()
        {
            tbEmployeesID.Clear();
            tbEmployeesName.Clear();
            tbUserName.Clear();
            //tbSex.Clear();
            tbPhone.Clear();
            tbCountry.Clear();
            dtpkDateOfBirth.Value = DateTime.Now; 
            tbSalary.Clear();
        }
        private void binding()
        {
            tbEmployeesID.DataBindings.Clear();
            tbEmployeesID.DataBindings.Add("Text", gctEmployees.DataSource, "Mã");
            tbUserName.DataBindings.Clear();
            tbUserName.DataBindings.Add("Text", gctEmployees.DataSource, "UserName");
            tbEmployeesName.DataBindings.Clear();
            tbEmployeesName.DataBindings.Add("Text", gctEmployees.DataSource, "Tên");
            //tbSex.DataBindings.Clear();
            //tbSex.DataBindings.Add("Text", gctEmployees.DataSource, "Giới tính");
            tbSalary.DataBindings.Clear();
            tbSalary.DataBindings.Add("Text", gctEmployees.DataSource, "HS lương");
            tbPhone.DataBindings.Clear();
            tbPhone.DataBindings.Add("Text", gctEmployees.DataSource, "Số điện thoại");
            tbCountry.DataBindings.Clear();
            tbCountry.DataBindings.Add("Text", gctEmployees.DataSource, "Quê quán");
            dtpkDateOfBirth.DataBindings.Clear();
            dtpkDateOfBirth.DataBindings.Add("Text", gctEmployees.DataSource, "Ngày sinh");
        }
      
        private void loadData()
        {
            try
            {
                gctEmployees.DataSource = EmployeesControl.Instance.DataSource_GetEmployees();
            }
            catch { }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = 1;
            ReadOnly(false);
            EnabledBtn(false);
            tbEmployeesID.ReadOnly = true;
            tbEmployeesName.Focus();
            Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            int EmployeesID = 0 ;
            string EmployeesName = "";
            string UserName = "";
            //int Sex = Convert.ToInt32(tbSex.Text.Trim(' '));
            string Phone = "";
            string Country = "";
            DateTime DateOfBirth = DateTime.Now;
            float Salary = 0;
            //try
            //{
                
                EmployeesName = tbEmployeesName.Text.Trim(' ');
                UserName = tbUserName.Text.Trim(' ');
                //Sex = Convert.ToInt32(tbSex.Text.Trim(' '));
                Phone = tbPhone.Text.Trim(' ');
                Country = tbCountry.Text.Trim(' ');
                DateOfBirth = dtpkDateOfBirth.Value;
                Salary = (float)Convert.ToDouble(tbSalary.Text.Trim(' '));
            //}
           // catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin mặt hàng nhập vào!");

            }

            if (action == 1)//add
            {
                EmployeesControl.Instance.InsertEmployees(EmployeesName,UserName,Phone,Country,DateOfBirth,Salary);
            }
            if (action == 2)//update
            {
                EmployeesID = Convert.ToInt32(tbEmployeesID.Text.Trim(' '));
                EmployeesControl.Instance.UpdateEmployees(EmployeesID, Salary);
            }
            if (action == 3)//delete
            {
                EmployeesID = Convert.ToInt32(tbEmployeesID.Text.Trim(' '));
                EmployeesControl.Instance.DeleteEmployees(EmployeesID);
            }
            EnabledBtn(true);
            Employees_Store_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thực sự muốn hủy?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Employees_Store_Load(sender, e);
            }
            EnabledBtn(true);
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            action = 2;
            binding();
            EnabledBtn(false);
            ReadOnly(true);
            tbSalary.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            action = 3;
            EnabledBtn(false);
            ReadOnly(false);
            EnabledBtn(false);
        }
    }
}