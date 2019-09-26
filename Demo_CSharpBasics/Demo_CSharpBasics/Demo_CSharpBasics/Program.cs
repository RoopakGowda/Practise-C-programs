using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharpBasics
{
    class Program
    {
        /// <summary>
        /// Accept 2 integer variables and display the sum
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
          //  SumOf2Nums();
           // ImplicitExample();
           // ExplicitExample();
           // BoxingExample();
            UnboxingExample();

            Console.ReadKey();
        }

        static void SumOf2Nums()
        {
            int x, y, z;
            Console.WriteLine("Enter 2 numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
            Console.WriteLine("The sum is : " + z);
        }

        /// <summary>
        /// This function uses implicit type casting form integer to decimal
        /// </summary>
        static void ImplicitExample()
        {
            int x = 20;
            decimal y;
            y = x;
            Console.WriteLine("The value after implicit conversion is : " + y);

        }

        static void ExplicitExample()
        {
            int x = 20;
            decimal y = 45.76m; ;
            x = Convert.ToInt32(y);
            Console.WriteLine("The value after explicit conversion is : " + x);

        }

        static void BoxingExample()
        {
            decimal d = 67.98m;
            string s;
            object o;
            s = Convert.ToString(d);    // This is explicit Boxing
            o = d;                      // This is Implicit Boxing
            Console.WriteLine("After Boxing to string tyupe the result is : " + s);
            Console.WriteLine("After Boxing to object tyupe the result is : " + o);
        }

        static void UnboxingExample()
        {
            string s = "46.78";
            decimal y;
            y = Convert.ToDecimal(s);
            Console.WriteLine("After unboxing the result is :" + y);
        }
    }
}
