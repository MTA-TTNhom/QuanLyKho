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
    public partial class Item_Store : DevExpress.XtraEditors.XtraForm
    {
        private int idEmployees;
        private int staff = 2;
        private int action = 1;
        public Item_Store()
        {
            InitializeComponent();
        }

        private void Item_Store_Load(object sender, EventArgs e)
        {
            readOnly(true);
            EnabledBtn(true);
            load();
            binding();
        }

        public void init(int _staff, int _idEmployees)
        {
            staff = _staff;
            idEmployees = _idEmployees;
            
        }
        private void clear()
        {
            tbItemID.Clear();
            tbItemName.Clear();
            tbOnce.Clear();
            tbPriceIn.Clear();
            nudStored.Value = 0;
        }
      
        private void readOnly(bool e)
        {
            tbItemID.ReadOnly = e;
            tbItemName.ReadOnly = e;
            tbOnce.ReadOnly = e;
            tbPriceIn.ReadOnly = e;
            nudStored.ReadOnly = e;
        }
        private void EnabledBtn(bool e)
        {
            btnAddNew.Enabled = e;
            btnAdd.Enabled = e;
            btnSave.Enabled = !e;
            btnCancel.Enabled = !e;
        }
        private void load()
        {
            if (staff == 1)//là nhân viên
            {
                try
                {
                    gctListItem.DataSource = ItemControl.Instance.DataSource_GetItem();
                }
                catch { }
                pnlBtn.Hide();
                //pnlPriceIn.Hide();
                readOnly(true);
            }
            if (staff == 0)//là boss
            {
                try
                {
                    gctListItem.DataSource = ItemControl.Instance.DataSource_GetItem();
                }
                catch { }
                readOnly(true);
            }
         
        }
        private void binding()
        {
            tbItemID.DataBindings.Clear();
            tbItemID.DataBindings.Add("Text", gctListItem.DataSource, "Mã");
            tbItemName.DataBindings.Clear();
            tbItemName.DataBindings.Add("Text", gctListItem.DataSource, "Tên");
            tbOnce.DataBindings.Clear();
            tbOnce.DataBindings.Add("Text", gctListItem.DataSource, "Đơn vị");
            nudStored.DataBindings.Clear();
            nudStored.DataBindings.Add("Text", gctListItem.DataSource, "Tồn kho");
            try
            {
                tbPriceIn.DataBindings.Clear();
                tbPriceIn.DataBindings.Add("Text", gctListItem.DataSource, "Giá hàng");
            }
            catch { }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            action = 0;
            lbNumber.Text = "Số lượng nhập";
            clear();
            readOnly(false);
            tbItemID.ReadOnly = true;
            tbItemName.Focus();
            EnabledBtn(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = 1;
            lbNumber.Text = "Số lượng nhập";
            EnabledBtn(false);
            readOnly(true);
            tbItemID.ReadOnly = false;
            nudStored.ReadOnly = false;
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            action = 2;
            EnabledBtn(false);
            readOnly(false);
            tbPriceIn.ReadOnly = true;
            tbItemID.ReadOnly = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            action = 3;
            EnabledBtn(false);
            readOnly(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thực sự muốn hủy?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Item_Store_Load(sender, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            string itemName="";
            string once = "";
            int priceIn = 0;
            int numOfStored = 0;

            try
            {
                itemName = tbItemName.Text.Trim(' ');
                once = tbOnce.Text.Trim(' ');
                priceIn = Convert.ToInt32(tbPriceIn.Text.Trim(' '));
                numOfStored = (int)nudStored.Value;
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin mặt hàng nhập vào!");
                
            }

            if (action == 0)//them moi thi can nhap Ma cua mat hang vao, tu no se update ma quay la quay hien tai
            {
               
                try
                {
                    ItemControl.Instance.InsertItem(itemName, numOfStored, once, priceIn);
                }
                catch { }
            }
            if (action == 1)
            {
                ItemControl.Instance.UpdateItem(itemName, numOfStored);
            }
            if (action == 2)
            {

            }
            if (action == 3)
            {

            }
            Item_Store_Load(sender, e);
        }
        private void tbItemID_TextChanged(object sender, EventArgs e)
        {
            tbItemName.Clear();
            tbPriceIn.Clear();
            tbOnce.Clear();
            try
            {
                DataTable dt = ItemControl.Instance.DataSource_GetItemByIdItem(Convert.ToInt32( tbItemID.Text.Trim(' ')));
                tbItemName.Text = dt.Rows[0]["Tên"].ToString();
                tbOnce.Text = dt.Rows[0]["Đơn vị"].ToString();
                tbPriceIn.Text = dt.Rows[0]["Giá hàng"].ToString();
            }
            catch { }
        }

        private void GetItemInfo()
        {  
            //string _id = tbItemID.Text.Trim(' ');
            try
            {
                DataTable dt = ItemControl.Instance.DataSource_GetItemByIdItem(Convert.ToInt32(tbItemID.Text.Trim(' ')));
                tbItemName.Text = dt.Rows[0]["Tên"].ToString();
                tbOnce.Text = dt.Rows[0]["Đơn vị"].ToString();
                tbPriceIn.Text = dt.Rows[0]["Giá hàng"].ToString();
                nudStored.Text = dt.Rows[0]["Tồn kho"].ToString();
            }
            catch
            {

            }
            
        }

       
    }
}