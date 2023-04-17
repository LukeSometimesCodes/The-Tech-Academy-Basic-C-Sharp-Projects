using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is the current day of the week?");
                string userAnswer = Console.ReadLine();

                Week week1;

                if (Enum.TryParse<Week>(userAnswer, out week1))
                    Console.WriteLine("{0} converted to {1}", userAnswer, week1);

                else
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();
        }

            
        public enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }

        

}   

