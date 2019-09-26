using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Nested_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
           // NestedLoop();
            AcceptAndDisplayARRAY();
        }
        static void NestedLoop()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 2; i <= 8; i = i + 2)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }
        }

        static void AcceptAndDisplayARRAY()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 elements");
            for(int i=0;i<5;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("The elements of the array are :");

            for(int i=0;i<5;i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
