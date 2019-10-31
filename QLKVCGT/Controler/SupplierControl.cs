using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKVCGT.Controler
{
    class SupplierControl
    {
        private static SupplierControl instance;

        public static SupplierControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new SupplierControl();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private SupplierControl()
        {
        }

        public DataTable DataSource_getSupplier()
        {
            string query = @"exec SP_getSupplier";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { });
        }
        public DataTable DataSource_getSupplierByIdSup(int id)
        {
            string query = @"exec SP_getSupplierByIdSup @id";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { id });
        }
        public DataTable DataSource_GetSupplierByName(string name)
        {
            string query = @"exec SP_getSupplierByName @name";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { name });
        }
        public int InsertSupplier(string _Supplier,string _Address,string _Phone,string _Fax,string _Email,string _Tax_Ident_Num)
        {
            string query = @"exec SP_InsertSupplier @SupplierName, @Address, @Phone, @Fax, @Email, @Tax_Ident_Num";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] {  _Supplier,  _Address,  _Phone,  _Fax,  _Email,  _Tax_Ident_Num });
        }
        public int UpdateSupplier(string _Supplier, string _Address, string _Phone, string _Fax, string _Email, string _Tax_Ident_Num)
        {
            string query = @"exec SP_UpdateSupplier @SupplierName, @Address, @Phone, @Fax, @Email, @Tax_Ident_Num";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _Supplier, _Address, _Phone, _Fax, _Email, _Tax_Ident_Num });
        }
        public int DeleteSupplier(string _Supplier)
        {
            string query = @"exec SP_DeleteSupplier @SupplierName ";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _Supplier });
        }
    }
}
