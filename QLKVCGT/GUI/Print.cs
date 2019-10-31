using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLKVCGT.Models;

namespace QLKVCGT.GUI
{
    public partial class Print : DevExpress.XtraEditors.XtraForm
    {
        public Print()
        {
            InitializeComponent();
        }
        public void load(string _customerName, string _employeesName,
                            int _totalPriceBill, DateTime _dateOfBill, int _customerGive, int _employeesGive, List<IssueVouDetailMod> list)
        {
            Bill bill = new Bill();
            foreach(DevExpress.XtraReports.Parameters.Parameter p in bill.Parameters)
            {
                p.Visible = false;
            }
            bill.InitData(_customerName, _employeesName, _totalPriceBill, _dateOfBill, _customerGive, _employeesGive, list);
            documentView.DocumentSource = bill;
            bill.CreateDocument();
        }
        
    }
}