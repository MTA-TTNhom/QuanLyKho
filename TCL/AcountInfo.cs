using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCL.GUI
{
    public partial class AcountInfo : Form
    {
        public AcountInfo()
        {
            InitializeComponent();
        }

        private int id;
        private string pass;
        public AcountInfo()
        {
            InitializeComponent();
            //load();
        }

        public void init(int _idEmployees, string _pass)
        {
            id = _idEmployees;
            pass = _pass;
        }

        private void AcountInfo_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            Enable(true);
            DataTable dt = AcountInfoControl.Instance.DataSource_GetEmployeesByID(id);
            tbUserName.Text = dt.Rows[0]["UserName"].ToString();
            tbID.Text = dt.Rows[0]["Mã"].ToString();
            tbName.Text = dt.Rows[0]["Tên"].ToString();
            tbSalary.Text = dt.Rows[0]["HS lương"].ToString();
            tbTelephoneNumber.Text = dt.Rows[0]["Số điện thoại"].ToString();
            tbCountry.Text = dt.Rows[0]["Quê quán"].ToString();

            dtpkDateOfBirth.Value = Convert.ToDateTime(dt.Rows[0]["Ngày sinh"].ToString());
            cbbSex.Text = dt.Rows[0]["Giới tính"].ToString();
        }
        private void Enable(bool e)
        {
            tbID.ReadOnly = e;
            tbName.ReadOnly = e;
            tbUserName.ReadOnly = e;
            tbSalary.ReadOnly = e;
            tbCountry.ReadOnly = e;
            dtpkDateOfBirth.Enabled = !e;
            tbTelephoneNumber.ReadOnly = e;
            cbbSex.Enabled = !e;

            btnChangeInfo.Enabled = e;
            btnChangePass.Enabled = e;
            btnSave.Enabled = !e;
            btnCancel.Enabled = !e;

        }
    }
}
