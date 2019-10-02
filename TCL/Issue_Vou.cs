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
    public partial class Issue_Vou : Form
    {
        private int action = 0;
        private string employeesName;
        private int employeesId;
        private List<IssueVouDetailMod> listBillDetail = new List<IssueVouDetailMod>();
        public string EmployeesName
        {
            get
            {
                return employeesName;
            }

            set
            {
                employeesName = value;
            }
        }

        public int EmployeesId
        {
            get
            {
                return employeesId;
            }

            set
            {
                employeesId = value;
            }
        }
        public Issue_Vou()
        {
            InitializeComponent();
        }
        public void InitData(string _empName, int _empId)
        {
            employeesId = _empId;
            employeesName = _empName;
        }
        private void EnabledBtn(bool e)
        {
            btnAddCustomer.Enabled = e;
            btnCancelCustomer.Enabled = e;

            btnAddItem.Enabled = e;
            btnDeleteItem.Enabled = e;
            btnEditItem.Enabled = e;
            btnCancelItem.Enabled = e;
            btnSaveItem.Enabled = e;

            btnPrintBill.Enabled = e;
            btnCancelBill.Enabled = e;
        }
        private void EnableBtnItem(bool e)
        {
            btnAddItem.Enabled = e;
            btnEditItem.Enabled = e;
            btnDeleteItem.Enabled = e;
            btnSaveItem.Enabled = !e;
            btnCancelItem.Enabled = !e;

        }
        private void ReadOnly(bool e)
        {
            tbCustomerID.ReadOnly = e;
            tbCustomerName.ReadOnly = e;

            tbItemID.ReadOnly = e;
            tbItemName.ReadOnly = e;
            nudNumOfItem.ReadOnly = e;
            tbPriceOnceItem.ReadOnly = e;
            tbTotalPriceItem.ReadOnly = e;

            tbTotalPriceBill.ReadOnly = e;
            tbCustomerGive.ReadOnly = e;
            tbEmployeesGive.ReadOnly = e;
        }
        private void clear()
        {
            tbItemID.Clear();
            nudNumOfItem.Value = 1;
            tbItemName.Clear();
            tbPriceOnceItem.Clear();
            tbTotalPriceItem.Clear();
        }
        private void binding()
        {
            try
            {
                tbItemID.DataBindings.Clear();
                tbItemID.DataBindings.Add("Text", gctBill.DataSource, "itemId");
                tbItemName.DataBindings.Clear();
                tbItemName.DataBindings.Add("Text", gctBill.DataSource, "itemName");
                nudNumOfItem.DataBindings.Clear();
                nudNumOfItem.DataBindings.Add("Text", gctBill.DataSource, "numOfItem");
                tbPriceOnceItem.DataBindings.Clear();
                tbPriceOnceItem.DataBindings.Add("Text", gctBill.DataSource, "price");
                tbTotalPriceItem.DataBindings.Clear();
                tbTotalPriceItem.DataBindings.Add("Text", gctBill.DataSource, "totalPrice");
            }
            catch { }
        }
    }
}
