using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKVCGT.Controler
{
    class ChangePassControl
    {
        public int ChangePass(int id, string newPass)
        {
            string query = @"exec SP_CHANGEPASS @ID, @NEWPASS";
            try
            {
                return DataProvider.Instances.ExecuteNonQuery(query, new object[] { id, newPass });
            }
            catch
            {
                MessageBox.Show("LOL");
                return 0;
            }
        }
    }
}
