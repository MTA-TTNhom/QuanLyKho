using QLKVCGT.Controler;
using QLKVCGT.Models;
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

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            if (action == 1) //add
            {
                string ItemID =  tbItemID.Text.Trim(' ');
                if (ItemID == "")
                {
                    MessageBox.Show(" mặt hàng không tồn tại! \n Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                addItemToList();
            }

            if (action == 2)//update
            {
                foreach (var item in listBillDetail)
                {
                    if (item.IdItem == Convert.ToInt32(tbItemID.Text))
                    {
                        item.NumOfItem = (int)nudNumOfItem.Value;

                        item.TotalPriceItem = Convert.ToInt32(tbTotalPriceItem.Text);
                    }
                }
            }
            if (action == 3)//delete
            {
                int i = 0;
                foreach (var item in listBillDetail)
                {

                    if (item.IdItem == Convert.ToInt32(tbItemID.Text))
                    {
                        listBillDetail.RemoveAt(i);
                        break;
                    }
                    i++;
                }
            }
            addItemToDgv();
            EnableBtnItem(true);
            
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            clear();
            EnableBtnItem(true);
        }

        private void tbItemID_TextChanged(object sender, EventArgs e)
        {
            if(tbItemID.Text.Trim(' ')!="")
            {
                tbItemName.Clear();
                int _idItem = Convert.ToInt32(tbItemID.Text.Trim(' '));
                getItemInfo(_idItem);
            }
           
        }

        private void nudNumOfItem_Enter(object sender, EventArgs e)
        {
            //string ItemName = tbItemName.Text.Trim(' ');
            //if (ItemName == "")
            //{
            //    MessageBox.Show("Mã mặt hàng không tồn tại! \n Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void nudNumOfItem_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = ItemControl.Instance.DataSource_GetItem();
            foreach (DataRow item in dt.Rows)
            {
                if (item["Mã"].ToString() == tbItemID.Text) MessageBox.Show("LOL");
                if ((int)nudNumOfItem.Value > Convert.ToInt32(item["Tồn kho"].ToString()) && item["Mã"].ToString() == tbItemID.Text.Trim(' '))
                {
                    MessageBox.Show("Không đủ hàng!");
                    return;
                }
            }
            getTotalPriceOnceItem();
        }

        ////////////
        //private void getNameSupplier(int _idSupplier)
        //{
        //    try
        //    {
        //        DataTable dt = SupplierControl.Instance.DataSource_getSupplierByIdSup(_idSupplier);
        //        tbSupplierName.Text = dt.Rows[0]["Tên khách hàng"].ToString();
        //    }
        //    catch { }
        //}

        private void getItemInfo(int _idItem)
        {
            try
            {
                DataTable dt = ItemControl.Instance.DataSource_GetItemByIdItem(_idItem);
                tbItemName.Text = dt.Rows[0]["Tên"].ToString();
                tbPriceOnceItem.Text = dt.Rows[0]["Giá hàng"].ToString();
                tbTotalPriceItem.Text = dt.Rows[0]["Giá hàng"].ToString();
                
            }
            catch { }
        }


        private void getTotalPriceOnceItem()
        {

            int price = Convert.ToInt32(tbPriceOnceItem.Text);
            int number = (int)nudNumOfItem.Value;
            int totalPrice = (int)(float)(price * number);
            tbTotalPriceItem.Text = totalPrice.ToString();
        }

        private void addItemToList()
        {
            int flag = 0;
            int idBill = getMaxBill();
            int idItem = Convert.ToInt32(tbItemID.Text.Trim(' '));
            string name = tbItemName.Text.Trim(' ');
            int price = Convert.ToInt32(tbPriceOnceItem.Text.Trim(' '));
            int number = (int)nudNumOfItem.Value;

            int totalPriceItem = Convert.ToInt32(tbTotalPriceItem.Text.Trim(' '));
            ReceiptVouDetailMod bill = new ReceiptVouDetailMod(idBill, idItem, name, price, number);
            foreach (var item in listBillDetail)
            {
                if (idItem == item.IdItem)
                {
                    item.NumOfItem += number;
                    item.TotalPriceItem += totalPriceItem;
                    flag = 1;
                    break;
                }
            }
            if (flag == 0) listBillDetail.Add(bill);
        }

        private void addItemToDgv()
        {
            int totalPriceOfBill = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("itemId");
            dt.Columns.Add("itemName");
            dt.Columns.Add("price");
            dt.Columns.Add("numOfItem");
            dt.Columns.Add("totalPriceOfItem");

            foreach (ReceiptVouDetailMod item in listBillDetail)
            {
                totalPriceOfBill += item.TotalPriceItem;
                DataRow row = dt.NewRow();
                row["itemId"] = item.IdItem;
                row["itemName"] = item.ItemName;
                row["price"] = item.PriceItem;
                row["numOfItem"] = item.NumOfItem;
                row["totalPriceOfItem"] = item.TotalPriceItem;
                dt.Rows.Add(row);
            }
            tbTotalPriceBill.Text = totalPriceOfBill.ToString();
            gctBill.DataSource = dt;
            //  MessageBox.Show(dt.Rows[0]["itemId"].ToString());
        }


        private void InsertBill()
        {
            try
            {
                ReceiptVouControl.Instance.InsertBill(employeesId,Convert.ToInt32( tbSupplierID.Text.Trim(' ')), 0);
            }
            catch
            {
                MessageBox.Show("Lỗi rồi em ơi!");
            }
        }

        private void InsertBillDetail()
        {
            try
            {

                foreach (var item in listBillDetail)
                {
                    ReceiptVouControl.Instance.InsertBillDetail(item.IdItem, item.IdBill, item.NumOfItem);
                }
            }
            catch
            {
                //MessageBox.Show("Bạn");
            }
        }
        private int getMaxBill()
        {
            try
            {
                return Convert.ToInt32(ReceiptVouControl.Instance.DataSoure_GetMaxBillByEmpId(employeesId).Rows[0]["Số hóa đơn MAX"].ToString());
            }
            catch
            {
                MessageBox.Show("Lỗi rồi thưa Boss!");
                return 0;
            }
        }

        private void UpdateBill()
        {
            try
            {
                ReceiptVouControl.Instance.UpdateBill(getMaxBill(), Convert.ToInt32(tbTotalPriceBill.Text));
            }
            catch
            {
                MessageBox.Show("Lỗi rồi thưa đại ca!");
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (tbSupplierName.Text.Trim(' ') == "")
            {
                string text = "Mã nhà cung cấp không tồn tại! \n Vui lòng kiểm tra lại!";
                MessageBox.Show(text, "Thông báo");
                Reciept_Vou_Load(sender, e);
            }
            else
            {
                btnAddSupplier.Enabled = false;
                btnCancelSupplier.Enabled = false;
                btnAddItem.Enabled = true;
                InsertBill();
                
            }
        }

        private void btnCancelSupplier_Click(object sender, EventArgs e)
        {
            Reciept_Vou_Load(sender, e);
            tbSupplierName.Clear();
            tbSupplierID.Clear();
        }

        private void tbSupplierName_TextChanged(object sender, EventArgs e)
        {
            tbSupplierID.Clear();
            try
            {
                DataTable dt = SupplierControl.Instance.DataSource_GetSupplierByName(tbSupplierName.Text.Trim(' '));
                tbSupplierID.Text = dt.Rows[0]["Mã"].ToString();
                
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertBillDetail();
            UpdateBill();
        }
    }
}
