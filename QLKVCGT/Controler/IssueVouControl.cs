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


        public int InsertBillDetail(int _itemId, int _billId, int _numOfItem)
        {
            string query = @"exec SP_insertBillDetail @itemId, @billId, @numOfItem";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _itemId, _billId, _numOfItem});
        }

        public DataTable DataSoure_GetMaxBillByEmpId(int _employeesId)//lay ra cai hoa don moi nhat cau nhan vien
        {
            string query = @"exec SP_getMaxBillForEmp @employeesId";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { _employeesId });

        }

        public DataTable DataSource_GetDetailBillByID(int id)
        {
            DataTable dt = new DataTable();
            string query = @"exec SP_getBillDetail @id";
            dt = DataProvider.Instances.ExecuteQuery(query, new object[] { id });
            return dt;
        }

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
