using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission
{
    public class Employee
    {
        string FirstName;
        string LastName;
        int ID = 5;

        public static Employee operator ==(Employee employee1, Employee employee2)
        {
            string employeeName = "Luke";
            string LastName = "Test";
            int ID = 5;
        }

        public static Employee operator !=(Employee employee1, Employee employee2)
        {
            string employeeName = "Luke";
            string LastName = "Test";
            int ID = 5;
        }
    }

    

}
