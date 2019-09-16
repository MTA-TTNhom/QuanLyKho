using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCL.Controller
{
    class ReceiptVouControl
    {
        public static ReceiptVouControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReceiptVouControl();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private ReceiptVouControl() { }


        public DataTable DataSource_GetListBill()
        {
            string query = @"exec SP_getListBillIn ";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { });
        }
        public int InsertBill(int _employessId, int _supplierID, int _totalPrice)
        {
            string query = @"exec SP_insertBillIn @employeesId, @supplierID, @totalPrice";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _employessId, _supplierID, _totalPrice });
        }


        public int InsertBillDetail(int _itemId, int _billId, int _numOfItem)
        {
            string query = @"exec SP_insertBillInDetail @itemId, @billId, @numOfItem";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _itemId, _billId, _numOfItem });
        }
    }
}
