using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKVCGT.Controller
{
    class ItemControl
    {
        private static ItemControl instance;

        public static ItemControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new ItemControl();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private ItemControl() { }

        public DataTable DataSource_GetItem()
        {
            string query = @"exec  SP_getItem ";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { });
        }
    }
}
