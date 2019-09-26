using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum_Of_Array();
        }

        /// <summary>
        /// Accept an array of 3x3 matrix and find sum of diaognal elements
        /// </summary>
        static void Sum_Of_Array()
        {
            int[,] arrNums = new int[3,3];
            int sum=0;
            Console.WriteLine("Enter 9 numeric values");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    arrNums[i, j] = Convert.ToInt32(Console.ReadLine());
                    if((i==j) || (i+j)==2)
                    {
                        sum = sum + arrNums[i, j];
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrNums[i, j] + "\t");
                }

                Console.WriteLine();
            }



            Console.WriteLine("Sum of all diaognal elements are : " + sum);


        }
    }
}
