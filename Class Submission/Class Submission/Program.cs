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

            number.Thing(userNum);

            number.overload(25);
            number.overload((decimal)12.5);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
