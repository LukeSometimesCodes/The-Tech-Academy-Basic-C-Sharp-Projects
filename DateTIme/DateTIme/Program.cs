using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTIme
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2023, 4, 17);

            Console.WriteLine(dateTime);

            Console.WriteLine("Please input a number");
            int answer = Int32.Parse(Console.ReadLine());

            DateTime newTime = dateTime.AddHours(answer);
            

            Console.WriteLine(newTime);
            Console.ReadLine();
        }
    }
}
