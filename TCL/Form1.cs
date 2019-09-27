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
    public partial class Form1 : Form
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

        public void init(int _typeOfEmployees, int _idEmployees, string _passWord, string _name)
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

    }
}
