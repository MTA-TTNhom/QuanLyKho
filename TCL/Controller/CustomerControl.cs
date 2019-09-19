using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace QLKVCGT.Controller
{
    class CustomerControl
    {


        private static CustomerControl instance;

        public static CustomerControl Instance
        {
            get
            {

                if (instance == null)

                    instance = new CustomerControl();

                return instance;
            }



            private set
            {
                instance = value;
            }

        }

        private CustomerControl()
        {


        }


        public DataTable DataSource_getCustomer()
        {

            string query = @"exec SP_getCustomer";
            string query = @"exec SP_getCustomeer";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { });

        }

        public DataTable DataSource_getCustomerByIdCus(int id)
        {

            string query = @"exec SP_getCustomerByIdCus @id";
            string query = @"exec SP_getCustomerByIdCuser @id";


            return DataProvider.Instances.ExecuteQuery(query, new object[] { id });


        }


    }

}
