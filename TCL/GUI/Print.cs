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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
		
        private int ChangeInfo()
        {
            int _id = Convert.ToInt32(tbID.Text.Trim(' '));
            DateTime _dateOfBirth = dtpkDateOfBirth.Value;
            string _name = tbName.Text.Trim(' ');
            string _userName = tbUserName.Text.Trim(' ');
            int _sex;
            if (cbbSex.Text == "Nam") _sex = 1;
            else _sex = 0;
            float _salary = (float)Convert.ToDouble(tbSalary.Text);
            string _telephoneNumber = tbTelephoneNumber.Text.Trim(' ');
            string _country = tbCountry.Text.Trim(' ');
            return AcountInfoControl.Instance.ChangeAcount(_id, _name, _dateOfBirth, _sex, _userName, _country, _telephoneNumber);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChangeInfo() == 1)
            {
                MessageBox.Show("Thành công!");
            }
            load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
