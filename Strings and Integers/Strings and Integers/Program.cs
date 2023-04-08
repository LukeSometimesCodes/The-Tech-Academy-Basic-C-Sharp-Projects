using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> numbers = new List<int>();
                numbers.Add(10);
                numbers.Add(11);
                numbers.Add(12);
                numbers.Add(13);
                numbers.Add(14);
                numbers.Add(15);
                numbers.Add(16);
                numbers.Add(17);
                numbers.Add(18);
                numbers.Add(18);
                numbers.Add(20);

                Console.WriteLine("I have a list from 10-20, choose a number to divide each number by");
                int userNum = Int32.Parse(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int finalAnswer = number / userNum;
                    Console.WriteLine(number + " divided by " + userNum + " is " + finalAnswer);
                }
                Console.ReadLine();
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero, try another number");
                //Console.ReadLine();
                return;
                
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please input a number");
                //Console.ReadLine();
                return;
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
