using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLKVCGT.Controler;

namespace QLKVCGT.GUI
{
    public partial class xuphatnhanvien : Form
    {
        private int action;
        private int type;
        public xuphatnhanvien()
        {
            InitializeComponent();
        }
        private void ReadOnly(bool e)
        {
           
            tbma.ReadOnly = e;
            tbten.Enabled = !e;
            tbmucphat.Enabled = !e;
           

        }
        private void EnabledBtn(bool e)
        {
            btnAdd.Enabled = e;
            btnEdit.Enabled = e;
            btnDelete.Enabled = e;
            btnCancel.Enabled = !e;
            btnSave.Enabled = !e;
        }
        private void clear()
        {
            
            tbma.Clear();
            tbten.Clear();
            tbmucphat.Clear();
           
        }
        private void loadEmployeesToDgv()
        {
            gctListEmployees.DataSource = xuphatnhanviencs.Instance.xuphatnhanvien();
        }
         private void binding()
        {
            tbma.DataBindings.Clear();
            tbma.DataBindings.Add("Text", gctListEmployees.DataSource, "Mã xử phạt");
            tbten.DataBindings.Clear();
            tbten.DataBindings.Add("Text", gctListEmployees.DataSource, "Tên xử phạt");
            tbmucphat.DataBindings.Clear();
            tbmucphat.DataBindings.Add("Text", gctListEmployees.DataSource, "Mức phạt");
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void xuphatnhanvien_Load(object sender, EventArgs e)
        {
            EnabledBtn(true);
            ReadOnly(true);
            loadEmployeesToDgv();
            binding();
            //pnlHide.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = 1;
            EnabledBtn(false);
            ReadOnly(false);
            tbten.ReadOnly = true;
            clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            action = 2;
            EnabledBtn(false);
            ReadOnly(true);
            tbten.ReadOnly = false;
            //pnlHide.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            action = 3;
            ReadOnly(true);
            tbten.ReadOnly = false;
            EnabledBtn(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            xuphatnhanvien_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _ma = tbma.Text.Trim(' ');
            string _ten = tbten.Text.ToString().Trim(' ');
            string _mucphat = tbmucphat.Text.ToString().Trim(' ');
            
            if (action == 1)
            {
                if (_ten == "" || _ma == "" || _mucphat == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
                    return;
                }
                try
                {
                    xuphatnhanviencs.Instance.insertmucphat(_ma, _ten, _mucphat);
                }
                catch { MessageBox.Show("Trùng tên"); }


            }
            if (action == 2)
            {
                xuphatnhanviencs.Instance.updatemucphat(_ma,_ten, _mucphat);

            }
            if (action == 3)
            {
                xuphatnhanviencs.Instance.deletemucphat(_ma);
            }
            xuphatnhanvien_Load(sender, e);
        }

       

    }
}
