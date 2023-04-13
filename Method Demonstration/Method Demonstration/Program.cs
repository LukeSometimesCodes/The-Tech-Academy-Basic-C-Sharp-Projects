using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Demonstration
{
    class Program
    {
        static void Main()
        {
            Class1 number = new Class1();
            Console.WriteLine("Please pick a number");

            int userNum = Int32.Parse(Console.ReadLine());
            
            try
            {
                Console.WriteLine("Please select another number, or don't enter one at all");
                int userNum1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine(number.method(userNum, userNum1));


                
            }
            catch
            {
                Console.WriteLine(number.method(userNum));
            }
            Console.ReadLine();
           
        }
    }
}
