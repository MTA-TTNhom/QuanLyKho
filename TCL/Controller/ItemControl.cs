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
        public DataTable DataSource_GetItemByIdItem(int id)
        {
            string query = @"exec  SP_getItemByIdItem @id";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { id });
        }
        public DataTable DataSource_GetItemByName(string name)
        {
            string query = @"exec  SP_getItemByName @name";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { name });
        }
        public int InsertItem(string _itemName, int _numberOfStored, string _once, int _price)
        {
            string query = @"exec SP_insertItem @itemName, @numberOfStored, @once, @price";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _itemName, _numberOfStored, _once, _price });
        }
        public int UpdateItem(string _itemName, int _numberOfStored)
        {
            string query = @"exec SP_updateItem @itemName, @numberOfStored";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _itemName, _numberOfStored });
        }

    }
}
