using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLKVCGT.Controler;

namespace QLKVCGT.GUI
{
    public partial class Supplier_Store : DevExpress.XtraEditors.XtraForm
    {
        private int action = 1;
        public Supplier_Store()
        {
            InitializeComponent();
        }
        private void Supplier_Store_Load(object sender, EventArgs e)
        {
            load();
        }
        private void clear()
        {
            tbSupplierID.Clear();
            tbSupplierName.Clear();
            tbAddress.Clear();
            tbEmail.Clear();
            tbFax.Clear();
            tbPhone.Clear();
            tbTax_Ident_Num.Clear();
        }
        private void readOnly(bool e)
        {
            tbSupplierID.ReadOnly = e;
            tbSupplierName.ReadOnly = e;
            tbAddress.ReadOnly = e;
            tbPhone.ReadOnly = e;
            tbEmail.ReadOnly = e;
            tbTax_Ident_Num.ReadOnly = e;
        }
        private void EnabledBtn(bool e)
        {
            btnUpdate.Enabled = e;
            btnDelete.Enabled = e;
            btnAdd.Enabled = e;
            btnSave.Enabled = !e;
            btnCancel.Enabled = !e;
        }
        private void load()
        {
            loadData();
            binding();
        }

        private void binding()
        {

            tbSupplierID.DataBindings.Clear();
            tbSupplierID.DataBindings.Add("Text", gctSupplier.DataSource, "Mã");
            tbSupplierName.DataBindings.Clear();
            tbSupplierName.DataBindings.Add("Text", gctSupplier.DataSource, "Tên");
            tbAddress.DataBindings.Clear();
            tbAddress.DataBindings.Add("Text", gctSupplier.DataSource, "Địa chỉ");
            tbPhone.DataBindings.Clear();
            tbPhone.DataBindings.Add("Text", gctSupplier.DataSource, "Số điện thoại");
            tbTax_Ident_Num.DataBindings.Clear();
            tbTax_Ident_Num.DataBindings.Add("Text", gctSupplier.DataSource, "Mã số thuế");
            tbFax.DataBindings.Clear();
            tbFax.DataBindings.Add("Text", gctSupplier.DataSource, "Fax");
            tbEmail.DataBindings.Clear();
            tbEmail.DataBindings.Add("Text", gctSupplier.DataSource, "Email");
        }
        private void loadData()
        {
            try
            {
                gctSupplier.DataSource = SupplierControl.Instance.DataSource_getSupplier();
            }
            catch { }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = 1;
            readOnly(false);
            EnabledBtn(false);
            tbSupplierID.ReadOnly = true;
            tbSupplierName.Focus();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            action = 2;
            binding();
            EnabledBtn(false);
            readOnly(false);
            tbSupplierID.ReadOnly = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            action = 3;
            EnabledBtn(false);
            readOnly(false);
            EnabledBtn(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Bạn thực sự muốn hủy?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Supplier_Store_Load(sender, e);
            }
            EnabledBtn(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            string SupplierName = "";
            string Address = "";
            string Phone = "";
            string Email = "";
            string Fax = "";
            string Tax_Ident_Num = "";
            try
            {
                SupplierName = tbSupplierName.Text.Trim(' ');
                Address = tbAddress.Text.Trim(' ');
                Phone = tbPhone.Text.Trim(' ');
                Email = tbEmail.Text.Trim(' ');
                Fax = tbFax.Text.Trim(' ');
                Tax_Ident_Num = tbTax_Ident_Num.Text.Trim(' ');
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin mặt hàng nhập vào!");

            }

            if (action == 1)//add
            {
                SupplierControl.Instance.InsertSupplier(SupplierName, Address, Phone, Fax, Email, Tax_Ident_Num);
            }
            if (action == 2)//update
            {
                SupplierControl.Instance.UpdateSupplier(SupplierName, Address, Phone, Fax, Email, Tax_Ident_Num);
            }
            if (action == 3)//delete
            {
                SupplierControl.Instance.DeleteSupplier(SupplierName );
            }
            EnabledBtn(true);
            Supplier_Store_Load(sender, e);
        }
    }
}
