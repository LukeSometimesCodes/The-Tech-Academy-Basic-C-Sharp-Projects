using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class Program
    {
        static void Main()
        {
            Class number = new Class();

            Console.WriteLine("Choose a number");
            int numOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Choose a second number");
            int numTwo = Int32.Parse(Console.ReadLine());

            number.testMethod(numOne, numTwo);
            number.testMethod(numOne: 5, numTwo:8) ;



            Console.ReadLine();
        }
    }
}
