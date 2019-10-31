using QLKVCGT.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKVCGT.GUI
{
    public partial class ListIssue_Vou : DevExpress.XtraEditors.XtraForm
    {
        
        
        public ListIssue_Vou()
        {
            InitializeComponent();
        }

        

        private void ListIssue_Vou_Load(object sender, EventArgs e)
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
                dgvListBill.DataSource = IssueVouControl.Instance.DataSource_GetListBill();
            }
            catch { }
        }
        private void binding()
        {
            try
            {
                tbCustomerID.DataBindings.Clear();
                tbCustomerID.DataBindings.Add("Text", dgvListBill.DataSource, "Mã khách hàng");
                tbCustomerName.DataBindings.Clear();
                tbCustomerName.DataBindings.Add("Text", dgvListBill.DataSource, "Tên Khách hàng");
                tbEmployeesID.DataBindings.Clear();
                tbEmployeesID.DataBindings.Add("Text", dgvListBill.DataSource, "Mã nhân viên");
                tbEmployeesID.DataBindings.Clear();
                tbEmployeesName.DataBindings.Add("Text", dgvListBill.DataSource, "Tên nhân viên");
                tbNumOfBill.DataBindings.Clear();
                tbNumOfBill.DataBindings.Add("Text", dgvListBill.DataSource, "số phiếu xuất");
                tbDateOfBill.DataBindings.Clear();
                tbDateOfBill.DataBindings.Add("Text", dgvListBill.DataSource, "Ngày xuất");
                tbTotalPrice.DataBindings.Clear();
                tbTotalPrice.DataBindings.Add("Text", dgvListBill.DataSource, "Tổng tiền");
                tbNumOfBill.DataBindings.Clear();
                tbNgNhan.DataBindings.Add("Text", dgvListBill.DataSource, "Người nhận");
                
            }
            catch { }
        }

        private void dgvBillView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int numOfBill = int.Parse( dgvBillView.GetFocusedRowCellValue("Số phiếu xuất").ToString());
            dgvBillDetail.DataSource = IssueVouControl.Instance.DataSource_GetDetailBillByID(numOfBill);
        }

    }
}
