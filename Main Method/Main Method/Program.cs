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
            
            

            integer_intake numbers = new integer_intake();

            
            Console.WriteLine("Your number plus 25 is " + numbers.method(8));

            
            Console.WriteLine("Your decimal plus 20 is " + numbers.method(10.5m));

            
            
            Console.WriteLine("Your string converted to integer plus 45 is " + numbers.method("11"));

            Console.ReadLine();
        }
        
    }
}
