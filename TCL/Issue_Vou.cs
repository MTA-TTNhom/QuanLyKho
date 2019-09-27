using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCL
{
    public partial class Issue_Vou : Form
    {
        private int action = 0;
        private string employeesName;
        private int employeesId;
        private List<IssueVouDetailMod> listBillDetail = new List<IssueVouDetailMod>();
        public string EmployeesName
        {
            get
            {
                return employeesName;
            }

            set
            {
                employeesName = value;
            }
        }

        public int EmployeesId
        {
            get
            {
                return employeesId;
            }

            set
            {
                employeesId = value;
            }
        }
        public Issue_Vou()
        {
            InitializeComponent();
        }
    }
}
