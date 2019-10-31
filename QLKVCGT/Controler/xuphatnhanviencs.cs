using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKVCGT.Controler
{
    class xuphatnhanviencs
    {
        private static xuphatnhanviencs instance;

        public static xuphatnhanviencs Instance
        {
            get
            {
                if (instance == null)
                    instance = new xuphatnhanviencs();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private xuphatnhanviencs() { }


        //// Insert Employees
        public int insertmucphat(string _ma, string _ten, string _mucphat)
        {
            string query = @"exec SP_insertxuphat @ma, @ten, @mucphat";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _ma,_ten,_mucphat });
        }

        // update Employees
        public int updatemucphat(string _ma, string _ten, string _mucphat)
        {
            string query = @"exec SP_updatexuphat  @ma, @ten, @mucphat";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _ma,_ten,_mucphat });
        }

        //delete Employees
        public int deletemucphat(string _ma)
        {
            string query = @"exec SP_delatexuphat @ma";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _ma });
        }

        public DataTable xuphatnhanvien()
        {
            string query = @"exec SP_xuphatnhanvien";
            return DataProvider.Instances.ExecuteQuery(query);
        }

    }
}
