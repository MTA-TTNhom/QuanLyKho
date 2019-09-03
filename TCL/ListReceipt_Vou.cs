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
    public partial class ListReceipt_Vou : Form
    {
        public ListReceipt_Vou()
        {
            InitializeComponent();
        }

        private void ListReceipt_Vou_Load(object sender, EventArgs e)
        {
            load();
            binding();
        }
        private void load()
        {
            ReadOnlyTb(true);

            loadDgvBill();

        }
        private void ReadOnlyTb(bool e)
        {
            tbCustomerID.ReadOnly = e;
            tbCustomerName.ReadOnly = e;
            tbDateOfBill.ReadOnly = e;
            tbEmployeesID.ReadOnly = e;
            tbEmployeesName.ReadOnly = e;
            tbNumOfBill.ReadOnly = e;
            tbTotalPrice.ReadOnly = e;
            //tbCustomerID.ReadOnly = e;
        }
        private void loadDgvBill()
        {
            try
            {
                dgvListBill.DataSource = ReceiptVouControl.Instance.DataSource_GetListBill();
            }
            catch { }
        }
    }
}
