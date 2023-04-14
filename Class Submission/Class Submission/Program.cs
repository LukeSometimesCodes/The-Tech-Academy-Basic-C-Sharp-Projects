using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission
{
    class  Program
    {
        static void Main()
        {
            Class number = new Class();

            Console.WriteLine("Input a number");
            int userNum = Int32.Parse(Console.ReadLine());

            number.Method(userNum);


            int a, b;
            number.Thing(userNum);

            number.overload(25);
            number.overload((decimal)12.5);


            // below is method with output parameters
            int i;
            Addition(out i); 
            {

            }
            Console.WriteLine();
            Console.ReadLine();

        }

        private static void Addition(out int i)
        {
            throw new NotImplementedException();
        }

        
    }
    
}
