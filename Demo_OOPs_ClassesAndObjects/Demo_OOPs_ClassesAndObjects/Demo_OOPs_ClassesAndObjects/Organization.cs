using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOPs_ClassesAndObjects
{
    class Organization
    {
        string orgName;   // This is a DataMember
        int numAttendance;

        public string OrgName { get { return orgName; } set { orgName = value; } }
        public Organization()   // Default Constructor
        {
            orgName = "XYZ Ltd.";
            numAttendance = 10;
        }

        public Organization(int numAttendance)  // Parametrised constructor
        {
            orgName = "XYZ Ltd.";
            this.numAttendance = numAttendance;
        }

        public Organization(Organization objOrg)  // Copy constructor
        {
            orgName = objOrg.orgName;
            numAttendance = objOrg.numAttendance;
        }

        ~Organization()
        {
            orgName = string.Empty;
            numAttendance = 0;
        }


        /// <summary>
        /// Displaying the current value of orgName
        /// </summary>
        public void ShowOrgName()       // Member Function
        {
            Console.WriteLine("The organization name is {0} and number of attendance is {1} ",orgName, numAttendance);
        }
    }
}
