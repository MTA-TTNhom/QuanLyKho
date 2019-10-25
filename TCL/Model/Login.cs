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
using QLKVCGT.Controler;

namespace QLKVCGT
{
    public partial class LOGIN : DevExpress.XtraEditors.XtraForm
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        //private string userName;
        private int typeOfEmployees;
        private string name;
        private string passWord;
        private int idEmployees;

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string userName = tbUserName.Text.Trim(' ');
            string passWord = tbPassWord.Text.Trim(' ');
            getInfomationByUserName(userName, passWord);
        }

        private void getInfomationByUserName(string _userName, string _passWork)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = LoginControl.Instance.DataSource_Login(_userName, _passWork);
            }
            catch
            {
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
            else
            {
                idEmployees = Convert.ToInt32(dt.Rows[0]["Mã"].ToString());
                typeOfEmployees = Convert.ToInt32(dt.Rows[0]["Loại nhân viên"].ToString());
                passWord = dt.Rows[0]["Pass"].ToString().Trim(' ');
                name = dt.Rows[0]["Tên"].ToString().Trim(' ');
                this.Hide();
                Form1 fmain = new Form1();
                fmain.init(typeOfEmployees, idEmployees, passWord, name);
                fmain.Show();

            }
        }

        private void LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Xác minh", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}