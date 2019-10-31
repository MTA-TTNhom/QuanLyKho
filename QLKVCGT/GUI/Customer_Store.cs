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
    public partial class Customer_Store : DevExpress.XtraEditors.XtraForm
    {      
        public Customer_Store()
        {
            InitializeComponent();
        }

        private void Customer_Store_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            loadData();
            binding();
        }

        private void binding()
        {

            tbCustomerID.DataBindings.Clear();
            tbCustomerID.DataBindings.Add("Text", gctCustomer.DataSource, "Mã khách hàng");
            tbCustomerName.DataBindings.Clear();
            tbCustomerName.DataBindings.Add("Text", gctCustomer.DataSource, "Tên khách hàng");
            tbAddress.DataBindings.Clear();
            tbAddress.DataBindings.Add("Text", gctCustomer.DataSource, "Địa chỉ");
            tbPhone.DataBindings.Clear();
            tbPhone.DataBindings.Add("Text", gctCustomer.DataSource, "Số điện thoại");
            tbTax_Ident_Num.DataBindings.Clear();
            tbTax_Ident_Num.DataBindings.Add("Text", gctCustomer.DataSource, "Mã số thuế");
            tbFax.DataBindings.Clear();
            tbFax.DataBindings.Add("Text", gctCustomer.DataSource, "Fax");
            tbEmail.DataBindings.Clear();
            tbEmail.DataBindings.Add("Text", gctCustomer.DataSource, "Email");
        }
        private void loadData()
        {
            try
            {
                gctCustomer.DataSource = CustomerControl.Instance.DataSource_getCustomer();
            }
            catch { }
            
        }
    }
}