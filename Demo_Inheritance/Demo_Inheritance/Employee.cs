using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Inheritance
{
    class Sales
    {
        int salesQty;
        public Sales()
        {
            salesQty = 100;
        }
        public void ShowSalesData()
        {
            Console.WriteLine("Total sales qty is : "+salesQty);
        }
    }

    class Accounts : Sales
    {
          int taxAmt;
          public Accounts()
        {
            taxAmt = 500;
        }
        public void ShowTaxAmount()
        {
            Console.WriteLine("Total tax amt is : " + taxAmt);
        }
    }

    class Staff
    {
        public void ShowStaffData()
        {
            Console.WriteLine("Number of staff are 30");
        }
    }
}
