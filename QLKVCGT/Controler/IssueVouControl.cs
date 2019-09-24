using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKVCGT.Controler
{
    class IssueVouControl
    {
        private static IssueVouControl instance;

        
       
        
        

        

        

        

        public void UpdateBill(int _billId, int _totalPrice)
        {
            string query = @"exec SP_updateBill @billId, @totalPrice";
            DataProvider.Instances.ExecuteQuery(query, new object[] { _billId, _totalPrice });
        }

        public int DeleteBill(int _billId)
        {
            string query = @"exec SP_deleteBill @billId";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _billId });
        }
    }
}
