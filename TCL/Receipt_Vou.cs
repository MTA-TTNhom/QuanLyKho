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
    public partial class Receipt_Vou : DevExpress.XtraEditors.XtraForm
    {
        private int action = 0;
        private string employeesName;
        private int employeesId;
        private List<ReceiptVouDetailMod> listBillDetail = new List<ReceiptVouDetailMod>();
        public Receipt_Vou()
        {
            InitializeComponent();
        }
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
        public void InitData(string _empName, int _empId)
        {
            employeesId = _empId;
            employeesName = _empName;
        }
        private void EnabledBtn(bool e)
        {
            btnAddSupplier.Enabled = e;
            btnCancelSupplier.Enabled = e;

            btnAddItem.Enabled = e;
            btnDeleteItem.Enabled = e;
            btnEditItem.Enabled = e;
            btnCancelItem.Enabled = e;
            btnSaveItem.Enabled = e;
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
            tbSupplierID.ReadOnly = e;
            tbSupplierName.ReadOnly = e;

            tbItemID.ReadOnly = e;
            tbItemName.ReadOnly = e;
            nudNumOfItem.ReadOnly = e;
            tbPriceOnceItem.ReadOnly = e;
            tbTotalPriceItem.ReadOnly = e;

            tbTotalPriceBill.ReadOnly = e;

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
        private void Reciept_Vou_Load(object sender, EventArgs e)
        {
            clear();
            // binding();
            ReadOnly(true);
            EnabledBtn(false);
            btnAddSupplier.Enabled = true;
            btnCancelSupplier.Enabled = true;
            tbSupplierID.ReadOnly = true;
            tbSupplierName.ReadOnly = false;
            tbSupplierName.Focus();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            action = 1;
            clear();
            tbItemID.ReadOnly = false;
            nudNumOfItem.ReadOnly = false;
            EnableBtnItem(false);

        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            action = 2;
            binding();
            EnableBtnItem(false);
            tbItemID.ReadOnly = true;

            //tbPriceOnceItem.ReadOnly = true;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            action = 3;
            binding();
            EnableBtnItem(false);
            tbItemID.ReadOnly = true;
        }

    }
}
