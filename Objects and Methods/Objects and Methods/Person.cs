using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_Methods
{
    public class Person
    {
        string FirstName = "Luke";
        string LastName = " Chevrolet";

        public void SayName()
        { 
            Console.WriteLine("Name: " + FirstName + "" + LastName);
        }

        public void Sample()
        {
            string FirstName = "Sample";
            string LastName = "Student";
            Console.WriteLine(FirstName + " " + LastName);
             
        }
    }
}
