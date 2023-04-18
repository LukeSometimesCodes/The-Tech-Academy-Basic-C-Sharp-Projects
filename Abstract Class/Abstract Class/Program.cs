using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.SayName("Sample", "Student");

            IQuittable test = new Employee();

            test.Quit();

            Console.ReadLine();
        }
    }
}
