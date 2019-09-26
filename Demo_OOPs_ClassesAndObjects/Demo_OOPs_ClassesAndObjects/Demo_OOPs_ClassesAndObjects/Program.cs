using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOPs_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization objOrg1 = new Organization();  // Automatically calls Default Constructor
            objOrg1.ShowOrgName();


            Console.WriteLine("ENter number of attnd.");
            int num = Convert.ToInt32(Console.ReadLine());
            Organization objOrg2 = new Organization(num); // Automatically calls parametrized Constructor
            objOrg2.ShowOrgName();

          //  Organization.ShowOrgName();     // In case constructor is pvt & function is static


        // Using Copy Constructor
            Organization objOrg3 = new Organization(objOrg1);
            objOrg3.ShowOrgName();

            Console.WriteLine("Organization name at present is :" + objOrg3.OrgName);
            objOrg3.OrgName = "jhgscjGscg";
        }
    }
}
