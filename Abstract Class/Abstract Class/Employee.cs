using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            string FirstName = "Sample";
            string LastName = " Student";
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public void IQuittable() // for Polymorphism assignment
        {
            Quit();
        }
        
    }
}
