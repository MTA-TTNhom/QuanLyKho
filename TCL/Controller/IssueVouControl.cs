using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKVCGT.Controller
{
    class IssueVouControl
    {
        private static IssueVouControl instance;

        public static IssueVouControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new IssueVouControl();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
    }
}
