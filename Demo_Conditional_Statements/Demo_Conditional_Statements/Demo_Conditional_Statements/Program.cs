using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // MultipleIF_Example();
            //Switch_Case_Example();
            NestedIF_Example();
        }

        /// <summary>
        /// Accept marks and display GRADE as per below conditions
        /// </summary>
        static void MultipleIF_Example()
        {
            int marks = 0;
            Console.WriteLine("Enter marks");
            marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 90)
                 Console.WriteLine("A Grade");
            else if (marks >= 60)
                Console.WriteLine("B Grade");
            else
                Console.WriteLine("Failed");

        }

        /// <summary>
        /// Accept Qualification and Experience and display selection status of the candidate
        /// assuming JD as BTECH with 5 years
        /// </summary>
        static void NestedIF_Example()
        {
            string Qual = string.Empty;
            int Exp = 0;

            Console.WriteLine("Please enter the Qualification: (eg:BTECH,BSC,etc.,)");
            Qual = Console.ReadLine();
           
            if (Qual.Trim().ToUpper()=="BTECH")
            {
                Console.WriteLine("Please enter the years of Experience");
                Exp = Convert.ToInt32(Console.ReadLine());

                if (Exp >= 5)
                          Console.WriteLine("Congrats you are qualified");

                     else
                          Console.WriteLine("Sorry your Experience do not match with the requirement");
            }
            else
                    Console.WriteLine("Sorry you do not meet the required qualification");
            
        }
        /// <summary>
        /// Another way of implementing the same Assignment
        /// </summary>
        //static void NestedIF_Example()
        //{
        //    string Qual = string.Empty;
        //    int Exp = 0;

        //    Console.WriteLine("Please enter the Qualification: (eg:BTECH,BSC,etc.,)");
        //    Qual = Console.ReadLine();

        //    Console.WriteLine("Please enter the years of Experience");
        //    Exp = Convert.ToInt32(Console.ReadLine());


        //    if (Qual.Trim().ToUpper() == "BTECH")
        //    {
        //        if (Exp >= 5)
        //            Console.WriteLine("Congrats you are qualified");

        //        else
        //            Console.WriteLine("Sorry your Experience do not match with the requirement");
        //    }
        //    else
        //        Console.WriteLine("Sorry you do not meet the required qualification");

        //}

        //-----------------------Assignment completed------------------------------- 

       /// <summary>
       /// Accept an alphabet and say whetherv its a vowels character
       /// </summary>
        static void Switch_Case_Example()
        {
            string alpha = string.Empty;
            Console.WriteLine("Enter the alphabet");
            alpha = Console.ReadLine();

            switch (alpha.Trim().ToLower())
            {
                case "a":
                    Console.WriteLine("Vowels");
                    break;
                case "e":
                    Console.WriteLine("Vowels");
                    break;
                case "i":
                    Console.WriteLine("Vowels");
                    break;
                case "o":
                    Console.WriteLine("Vowels");
                    break;
                case "u":
                    Console.WriteLine("Vowels");
                    break;
                default:
                    Console.WriteLine("Invalid character or Consonant");
                    break;
            }

    // The above code can be written as below

            //switch (alpha.Trim().ToLower())
            //{
            //    case "a":
            //    case "e":
            //    case "i":
            //    case "o":
            //    case "u":
            //        Console.WriteLine("Vowels");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid character or Consonant");
            //        break;
            //}

        }
    }
}
