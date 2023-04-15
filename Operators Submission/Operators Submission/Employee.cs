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
        int ID;

        public static Employee operator ==(string FirstName, string LastName)
        {
            FirstName = "Luke";
            LastName = "Computer";
        }

        public static Employee operator !=(string FirstName, string LastName)
        {

        }
    }

    

}
