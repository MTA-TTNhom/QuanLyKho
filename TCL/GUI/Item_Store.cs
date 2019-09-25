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
    public partial class Item_Store : Form
    {
        public Item_Store()
        {
            InitializeComponent();
        }
		        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                if (e.KeyCode == Keys.Enter)
                    btnDangNhap.Focus();
            }
        }
        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtMatKhau.Focus();
        }
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.Focus();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.Focus();
		}
    }
}
