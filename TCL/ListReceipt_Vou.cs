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

        private void binding()
        {
            try
            {
                tbCustomerID.DataBindings.Clear();
                tbCustomerID.DataBindings.Add("Text", dgvListBill.DataSource, "Mã nhà cung cấp");
                tbCustomerName.DataBindings.Clear();
                tbCustomerName.DataBindings.Add("Text", dgvListBill.DataSource, "Tên nhà cung cấp");
                tbEmployeesID.DataBindings.Clear();
                tbEmployeesID.DataBindings.Add("Text", dgvListBill.DataSource, "Mã nhân viên");
                tbEmployeesID.DataBindings.Clear();
                tbEmployeesName.DataBindings.Add("Text", dgvListBill.DataSource, "Tên nhân viên");
                tbNumOfBill.DataBindings.Clear();
                tbNumOfBill.DataBindings.Add("Text", dgvListBill.DataSource, "số phiếu nhập");
                tbDateOfBill.DataBindings.Clear();
                tbDateOfBill.DataBindings.Add("Text", dgvListBill.DataSource, "Ngày nhập");
                tbTotalPrice.DataBindings.Clear();
                tbTotalPrice.DataBindings.Add("Text", dgvListBill.DataSource, "Tổng tiền");
                tbNumOfBill.DataBindings.Clear();
                tbNgGiao.DataBindings.Add("Text", dgvListBill.DataSource, "Người giao");

            }
            catch { }
        }

        private void dgvBillView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int numOfBill = int.Parse(dgvBillView.GetFocusedRowCellValue("Số phiếu nhập").ToString());
            dgvBillDetail.DataSource = ReceiptVouControl.Instance.DataSource_GetDetailBillByID(numOfBill);
        }
    }
}
