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
    public partial class Inventory : DevExpress.XtraEditors.XtraForm
    {
        public Inventory()
        {
            InitializeComponent();
        }
        
        private void loadThongKeNhoNho()
        {
            try
            {
                tbMin.Text = InventoryControl.Instance.DataSource_getMaxStored().Rows[0]["TENHH"].ToString();
                tbMax.Text = InventoryControl.Instance.DataSource_getMinStored().Rows[0]["TENHH"].ToString();
                tbTotalStored.Text = InventoryControl.Instance.DataSource_getTotalPriceStored().Rows[0]["Total"].ToString();
                cbbListItemForBuy.DataSource = InventoryControl.Instance.DataSource_getItemForBuy().Rows[0]["TENHH"].ToString();
                cbbListItemForBuy.DisplayMember = "TENHH";
            }
            catch { }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            loadThongKeNhoNho();
        }
    }
}
