using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_while_do_Statements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How old am I?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool ageGuessed = number == 22;

            do
            {
                switch (number)
                {
                    case 45:
                        Console.WriteLine("This is wrong, guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 34:
                        Console.WriteLine("This is wrong, guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 60:
                        Console.WriteLine("This is wrong, guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 22:
                        Console.WriteLine("Correct, good job!");
                        ageGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You are wrong, guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!ageGuessed);
            { 
            }
            Console.ReadLine();
        }
    }
}
