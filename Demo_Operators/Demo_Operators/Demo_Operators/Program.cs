using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
           IncrementOperator();
            //TernaryOperator();
        }

        static void IncrementOperator()
        {
            int x = 100;
            int y;
            int a = 100;
            int b;


            y = x++;
            Console.WriteLine("Afer post increment the value of y is :" + y);

            b = ++a;
            Console.WriteLine("Afer pre increment the value of b is :" + b);
        }

        /// <summary>
        /// Accept 2 integer variables and display the max using Ternary Operator
        /// </summary>
        static void TernaryOperator()
        {
            int x, y, z;
            Console.WriteLine("Enter 2 value for 2 variables");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            z = (x > y) ? x : y;
            Console.WriteLine("Max value is : " + z);

        }

    }
}
