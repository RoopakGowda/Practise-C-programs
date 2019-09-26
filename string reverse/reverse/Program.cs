using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Program test = new Program();
            test.reverse();
            
        }
        private void reverse()
        {
            Console.WriteLine("Enter words with space");
            string input = Console.ReadLine();

            if(input.Length > 0)
            {
                string[] words = input.Split(new char[0]);
                string output = string.Empty;
                for(int i = 0; i < words.Length; i++)
                {
                    string temp = words[i];
                    temp = Reverse(temp);
                    output = output + " " +temp;
                }
                Console.WriteLine(output);
                Console.ReadKey();
            }
        }
        public static string Reverse(string s)
        {
            string reversed = string.Empty;
            for(int i = s.Count()-1 ; i >= 0; i--)
            {
                reversed = reversed + s.ElementAt(i);
            }
            return reversed;
        }
    }
}
