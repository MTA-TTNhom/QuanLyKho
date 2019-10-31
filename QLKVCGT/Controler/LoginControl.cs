using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKVCGT.Controler
{
    public class LoginControl
    {
        private static LoginControl instance;

        public static LoginControl Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new LoginControl();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private LoginControl()
        {
        }

        public DataTable DataSource_Login(string _userName, string _passWork)
        {
            string query = @"exec  SP_GETINFOBYUSERNAME @userName, @pass";
            return DataProvider.Instances.ExecuteQuery(query, new object[] { _userName, _passWork });
        }
    }
}
