using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKVCGT.Controller
{
    class IssueVouControl
    {
        private static IssueVouControl instance;

        public static IssueVouControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new IssueVouControl();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private IssueVouControl() { }


        public DataTable DataSource_GetListBill()
        {
            string query = @"exec SP_getListBill ";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { });
        }
        public int InsertBill(int _employessId, string _customerId, int _totalPrice)
        {
            string query = @"exec SP_insertBill @employeesId, @customerId, @totalPrice";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _employessId, _customerId, _totalPrice });
        }
    }
}
