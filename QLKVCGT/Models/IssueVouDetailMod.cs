using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKVCGT.Models
{
   public class IssueVouDetailMod
        {
        private int idItem;
        private int idBill;
        private int numOfItem;
        private int totalPriceItem;
        private int priceItem;
        private string itemName;

        public int IdItem
        {
            get
            {
                return idItem;
            }

            set
            {
                idItem = value;
            }
        }

        public int IdBill
        {
            get
            {
                return idBill;
            }

            set
            {
                idBill = value;
            }
        }

        public int NumOfItem
        {
            get
            {
                return numOfItem;
            }

            set
            {
                numOfItem = value;
            }
        }

        public int TotalPriceItem
        {
            get
            {
                return totalPriceItem;
            }

            set
            {
                totalPriceItem = (int)(float)(priceItem * numOfItem) ;
            }
        }

        public int PriceItem
        {
            get
            {
                return priceItem;
            }

            set
            {
                priceItem = value;
            }
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public IssueVouDetailMod(int _idBill, int _idItem, int _price, int _numOfItem)
        {
            idBill = _idBill;
            idItem = _idItem;
            numOfItem = _numOfItem;
            priceItem = _price;
           
            totalPriceItem = (int)(float)(priceItem * numOfItem);
        }

        public IssueVouDetailMod(int _idBill, int _idItem, string _itemName, int _price, int _numOfItem)
        {
            IdItem = _idItem;
            IdBill = _idBill;
            itemName = _itemName;
            priceItem = _price;
            numOfItem = _numOfItem;
            totalPriceItem = (int)(float)(priceItem * numOfItem);
        }


        public IssueVouDetailMod(DataRow row)
        {
            idItem = Convert.ToInt32( row["Mã mặt hàng"].ToString());
            idBill = Convert.ToInt32( row["Số phiếu xuất"].ToString());
            numOfItem = (int)row["Số lượng"];
        }

    }
    }
