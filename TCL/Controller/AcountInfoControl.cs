using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCL.Controller
{
    class AcountInfoControl
    {

        private static AcountInfoControl instance;


        public static AcountInfoControl Instance
        {

            get

            {

                if (instance == null)

                    instance = new AcountInfoControl();

                return instance;
            }


            private set
            {

                instance = value;
            }

        }

        private static AcountInfoControl()
        {

        }


        public DataTable DataSource_GetEmployeesByID(int id)
        {

            DataTable dt = new DataTable();

            string query = @"exec SP_getEmployeesByID @id";

            dt = DataProvider.Instances.ExecuteQuery(query, new object[] { id });

            return dt;
        }

        //string _id, DateTime _dateOfBirth, string _name=null, string _userName = null, string _pass = null,  bool _sex = true, float _salary = 0, string _telephoneNumber = null, string _type= null

        public int ChangeAcount(int _id, string _name, DateTime _dateOfBirth, int _sex, string _userName, string _country, string _telephoneNumber)
        {

            string query = @"exec SP_ChangeAcountInfo @id, @dateOfBirth , @sex, @userName, @country, @telephonNunber";
            try

            {
                return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _id, _dateOfBirth, _sex, _userName, _country, _telephoneNumber });
            }

            catch
            {

                MessageBox.Show("sai");
                return 0;
            }

        }





    }



}
