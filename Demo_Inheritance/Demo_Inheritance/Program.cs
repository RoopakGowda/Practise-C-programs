using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts objAcc = new Accounts();
            objAcc.ShowSalesData();
            objAcc.ShowTaxAmount();

            Staff objStaff = new Staff();
            objStaff.ShowStaffData();

        }
    }
}
