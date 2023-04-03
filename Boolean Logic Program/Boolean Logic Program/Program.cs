using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Program
{
    class Program
    {
        static void Main()
        {
            //form for getting answers
            Console.WriteLine("Let's check to see if you can be approved for car insurance");
            Console.WriteLine("What is your age?");
            string personAge = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? Please answer true or false");
            string personDUI = Console.ReadLine();
            Console.WriteLine("Last Question! How many speeding tickets do you have? Pleaes input a number");
            string personTicket = Console.ReadLine();

            //Converting to correct data types (if needed)
            int personAge1 = Int32.Parse(personAge);
            bool DUIcheck1 = bool.Parse(personDUI);
            int ticketCheck1 = Int32.Parse(personTicket);



            //making computer compute
            bool ageCheck = personAge1 > 15;
            bool DUIcheck = DUIcheck1 == false;
            bool ticketCheck = ticketCheck1 < 3;
            Console.WriteLine("Are you qualified?");  
            Console.WriteLine(ageCheck == true && DUIcheck == false && ticketCheck == true);

            Console.ReadLine();
        }
    }
}
