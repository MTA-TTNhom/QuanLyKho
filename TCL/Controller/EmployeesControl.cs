
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace QLKVCGT.Controler
{

    class EmployeesControl
    {

        private static EmployeesControl instance;


        public static EmployeesControl Instance

        {

            get
            {

                if (instance == null)

                    instance = new EmployeesControl();

                return instance;
            }

            set
            {

                instance = value;

            }



        }
        private EmployeesControl()
        {


        }
        //// Insert Employees

        public int InsertEmployees(string _EmployeesName, string _UserName, string _Phone, string _Country, DateTime _DateOfBirth, float _Salary)
        {

            string query = @"exec SP_InsertEmployees @EmployeesName, @UserName, @Phone, @Country, @DateOfBirth, @Salary";

            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _EmployeesName, _UserName, _Phone, _Country, _DateOfBirth, _Salary });


        }


        // update Employees
        public int UpdateEmployees(int _EmployeesID, float _Salary)
        {

            string query = @"exec SP_UpdateEmployees @EmployeesID, @Salary";

            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _EmployeesID, _Salary });

        }



        //delete Employees
        public int DeleteEmployees(int _EmployeesID)
        {
            string query = @"exec SP_DeleteEmployees @EmployeesID";
            return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _EmployeesID });
        }



        public DataTable DataSource_GetEmployees()
        {

            DataTable dt = new DataTable();
            string query = @"exec SP_getEmployees ";
            dt = DataProvider.Instances.ExecuteQuery(query, new object[] { });
            return dt;

        }


    }



}
