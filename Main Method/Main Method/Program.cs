using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number");
            float userNum = float.Parse(Console.ReadLine());

            integer_intake numbers = new integer_intake();

            numbers.method(userNum);
            Console.WriteLine("Your number plus 25 is " + numbers.method(userNum));

            numbers.method(userNum);
            Console.WriteLine("Your float plus 20 is " + numbers.method(userNum));

            numbers.method(userNum);
            Console.WriteLine("Your string converted to integer plus 45 is " + numbers.method(userNum));

            Console.ReadLine();
        }
        
    }
}
