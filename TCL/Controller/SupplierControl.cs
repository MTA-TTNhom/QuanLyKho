using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKVCGT.Controller
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
    }
}
