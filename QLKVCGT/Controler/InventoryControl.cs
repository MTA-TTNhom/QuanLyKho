using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKVCGT.Controler
{
    class InventoryControl
    {
        private static InventoryControl instance;

        
        private InventoryControl() { }

        ///vai thống kê nho nhỏ
        
        
        
        public DataTable DataSource_getItemForBuy()
        {
            string query = @"exec SP_getItemForBuy ";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { });
        }
    }
}
