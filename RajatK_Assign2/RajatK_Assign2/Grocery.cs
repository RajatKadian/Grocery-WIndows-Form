using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Rajat kadian
// 300351928
//CSIS1175-004

namespace RajatK_Assign2
{
    class Grocery
    {
        public string ItemName { get; set; }

        public string ItemCode { get; set; }

        public double UnitPrice { get; set; }
        public int StartingQty { get; set; }

        public int QtyMiniForRestock { get; set; }

        public int QtySold { get; set; }

        public int QtyRestocked { get; set; }

        public int QuantityOnHand
        {
            get
            {
                return StartingQty - QtySold + QtyRestocked;
                
            }
           
        }

        public double TotalSales
        {
            get
            {
                return QtySold * UnitPrice;
            }
        }

        public Grocery(string name, string code, double price, int sQty, int QtyMini, int sold, int QtyRes)
        {
            ItemName = name;
            ItemCode = code;
            UnitPrice = price;
            StartingQty = sQty;
            QtyMiniForRestock = QtyMini;
            QtySold = sold;
            QtyRestocked = QtyRes;


        }

        public override string ToString()
        {
            return ItemName + "\t" + ItemCode +   UnitPrice.ToString("C") + "\t" + StartingQty + "\t" + QtyMiniForRestock + "\t" +
                QtySold + "\t" + QtyRestocked + "\t" + QuantityOnHand + "\t" + TotalSales.ToString("C");

        }
    }
}
