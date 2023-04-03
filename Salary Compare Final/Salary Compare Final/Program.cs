using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Compare_Final
{
    class Program
    {
        static void Main()
        {
            
            {
                //Person 1 inputs
                Console.WriteLine("Anonymous Income Comparison Program");
                Console.WriteLine("Person 1");
                Console.WriteLine("What is your hourly rate?");
                string person1Hourly = Console.ReadLine();
                Console.WriteLine("Next, what are your hours worked per week?");
                string person1Weekly = Console.ReadLine();

                //Person 2 inputs
                Console.WriteLine("Person 2, what is your hourly rate?");
                string person2Hourly = Console.ReadLine();
                Console.WriteLine("What is your hours worked this week?");
                string person2Weekly = Console.ReadLine();

                //Annual salary person 1
                int person1Hourly1 = Int32.Parse(person1Hourly);
                int person1Weekly2 = Int32.Parse(person1Weekly);
                int person1Year = person1Weekly2 * 52;
                int person1Total = person1Hourly1 * person1Year;
                Console.WriteLine("Annual salary of Person 1 is " + person1Total);

                //Annual salary person 2
                int person2Hourly1 = Int32.Parse(person2Hourly);
                int person2Weekly2 = Int32.Parse(person2Weekly);
                int person2Year = person2Weekly2 * 52;
                int person2Total = person2Hourly1 * person2Year;
                Console.WriteLine("Annual salary of Person 2 is " + person2Total);

                //Actual Comparison
                bool personCheck = person1Total > person2Total;
                Console.WriteLine("Does person 1 make more than person 2? " + personCheck);
                Console.ReadLine();
    

            }
        }
    }

}
    

