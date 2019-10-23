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

        public static InventoryControl Instance
        {

            get

            {

                if (instance == null)
                    instance = new InventoryControl();

                return instance;

            }


            private set
            {

                instance = value;

            }
        }
        private InventoryControl()
        {



        }

        ///vai thống kê nho nhỏ
        public DataTable DataSource_getMaxStored()
        {

            string query = @"exec SP_getMaxStored ";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { });

        }


        public DataTable DataSource_getMinStored()
        {

            string query = @"exec SP_getMinStored ";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { });


        }



        public DataTable DataSource_getTotalPriceStored()

        {

            string query = @"exec SP_getTotalPriceStored";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { });

        }


        public DataTable DataSource_getItemForBuy()
        {

            string query = @"exec SP_getItemForBuy ";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { });

        }




    }



}
