using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee() { ID = 1};
            Employee employee2 = new Employee() { ID = 2};

            Console.WriteLine(employee == employee2);
            Console.ReadLine();
            
        }
    }
}
