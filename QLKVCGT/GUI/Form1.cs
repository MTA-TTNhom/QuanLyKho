using QLKVCGT.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace QLKVCGT
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        private int typeOfEmployees;
        private int idEmployees;
        private string passWord;
        private string nameEmployees;

        public int TypeOfEmployees
        {
            get
            {
                return typeOfEmployees;
            }

            set
            {
                typeOfEmployees = value;
            }
        }

        public int IdEmployees
        {
            get
            {
                return idEmployees;
            }

            set
            {
                idEmployees = value;
            }
        }

       public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }

        public string NameEmployees
        {
            get
            {
                return nameEmployees;
            }

            set
            {
                nameEmployees = value;
            }
        }

        public void  init(int _typeOfEmployees, int _idEmployees, string _passWord, string _name)
        {
            TypeOfEmployees = _typeOfEmployees;
            IdEmployees = _idEmployees;
            passWord = _passWord;
            nameEmployees = _name;
        }
        private void VisibleRpg(bool e)
        {
            rpgEmployees.Visible = e;
            rpgStock.Visible = e;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load(typeOfEmployees);
        }

        private void EnabledBtn(bool e)
        {
            btnAcountInfo.Enabled = e;
            btnLogout.Enabled = e;
            btnPrivilege.Enabled = e;
        }

        private void load(int _type)
        {
            

            VisibleRpg(false);
            
            if (_type == 0)
            {
                rpgStock.Visible = true;
               
            }
            if (_type == 1)
            {
                rpgEmployees.Visible = true;
            }
        }
        ///showfromChild
        ///
        private void showFormChild(Form f)
        {
            if (!isOpened(f))
            {
                f.MdiParent = this;
                f.Show();
            }
        }
        private bool isOpened(Form f)
        {
            bool isOpened = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (f.Name == item.Name)
                    {
                        xtmm.Pages[item].MdiChild.Activate();
                        isOpened = true;
                    }
                }
            }
            return isOpened;
        }


        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLogin.Enabled = false;
            LOGIN login = new LOGIN();
            login.ShowDialog();
            this.Hide();
        }
        private void btnAcountInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AcountInfo info = new AcountInfo();
            info.init(idEmployees, passWord);
            showFormChild(info);
        }

        private void btnReceipt_Vou_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Receipt_Vou info = new Receipt_Vou();
            info.InitData(NameEmployees, idEmployees);
            showFormChild(info);
        }

        private void btnIssue_Vou_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Issue_Vou info = new Issue_Vou();
            info.InitData(NameEmployees, idEmployees);
            showFormChild(info);
        }

        private void btnItem_Em_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Item_Store info = new Item_Store();
            info.init(typeOfEmployees, idEmployees);
            showFormChild(info);
        }

        private void btnEmployees_Store_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Employees_Store info = new Employees_Store();
            info.init(idEmployees);
            showFormChild(info);
        }

        private void btnItem_Store_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Item_Store info = new Item_Store();
            info.init(typeOfEmployees,idEmployees);
            showFormChild(info);
        }

        private void btnCustormer_Store_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Customer_Store info = new Customer_Store();
            showFormChild(info);
        }

        private void btnSupplier_Store_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Supplier_Store info = new Supplier_Store();
            showFormChild(info);
        }

        private void btnInventory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Inventory info = new Inventory();
            showFormChild(info);
        }

        private void btnStatistical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác minh", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnList_ReceiptVou_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListReceipt_Vou info = new ListReceipt_Vou();
            showFormChild(info);
        }

        private void btnList_IssueVou_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListIssue_Vou info = new ListIssue_Vou();
            showFormChild(info);
        }
    }
}
