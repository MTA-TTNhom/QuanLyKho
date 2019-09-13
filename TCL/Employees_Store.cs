using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCL.GUI
{
    public partial class Employees_Store : Form
    {
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
    }
}
