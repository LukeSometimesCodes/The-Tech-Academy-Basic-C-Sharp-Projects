using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Demonstration
{
    class Program
    {
        static void Main()
        {
           
            Console.WriteLine("Pick number to do math operations on");
            int userNum = Int32.Parse(Console.ReadLine());

            Number numbers = new Number();

            numbers.method1(userNum);
            Console.WriteLine(userNum + " plus 5 is " + numbers.method1(userNum));

            numbers.method2(userNum);
            Console.WriteLine(userNum + " minus one is " + numbers.method2(userNum));

            numbers.method3(userNum);
            Console.WriteLine(userNum + " times itself is " + numbers.method3(userNum));

            Console.ReadLine();
            



            
        }
    }
}
