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
    public partial class Receipt_Vou : Form
    {
        public Receipt_Vou()
        {
            InitializeComponent();
        }
				        private void btnSave_Click(object sender, EventArgs e)
        {
            string _oldPass = tbOldPass.Text.Trim(' ');
            string newPass = tbNewPass.Text.Trim(' ');
            string rePass = tbRePass.Text.Trim(' ');
            if (rePass != newPass || rePass == "" || newPass == "")
            {
                MessageBox.Show("Mật khẩu mới không trùng nhau hoặc không hợp lệ!");
                return;
            }
            if (_oldPass != oldPass)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
                return;
            }

            Controler.ChangePassControl change = new Controler.ChangePassControl();
            int i = change.ChangePass(id, newPass);
            if (i > 0)
            {
                MessageBox.Show("Thành công!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		
		        public void init(int _id, string _oldPass)
        {
            id = _id;
            oldPass = _oldPass;
        }
    }
}
