using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
           // Using_FOR_Loop();
           // Using_WHILE_Loop();
            Say_Prime_or_not();
        }
        /// <summary>
        /// Display all even numbers between 2 to 20
        /// </summary>
        static void Using_FOR_Loop()
        {
            for(int i=2;i<=20;i=i+2)
            {
                Console.Write(i + "\t");
            }
        }

        static void Using_WHILE_Loop()
        {
            int i = 2;
            while ( i <= 20)
            {
                Console.Write(i + "\t");
                i = i + 2;
            }
        }

        static void Using_DOWHILE_Loop()
        {
            int i = 2;
            do
            {
                Console.Write(i + "\t");
                i = i + 2;
            } while (i <= 20) ;
        }

        /// <summary>
        /// Accept a number and say whether prime or not
        /// </summary>
        static void Say_Prime_or_not()
        {
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            int flag =0;
            for(int i=2;i<(num/2);i++)
            {
                if(num%i==0)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not a prime");
        }
    }
}
