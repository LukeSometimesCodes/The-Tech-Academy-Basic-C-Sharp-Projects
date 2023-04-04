using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express_Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follwo the instructions below");
            Console.WriteLine("How many pounds is your package?");
            string packageWeight = Console.ReadLine();
            int packageWeight1 = Int32.Parse(packageWeight);
            if (packageWeight1 > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
            }
            else if (packageWeight1 < 50)
            {
                Console.WriteLine("What is the package width?");
                string packWidth = Console.ReadLine();
                Console.WriteLine("What is the package height?");
                string packHeight = Console.ReadLine();
                Console.WriteLine("What is the package length?");
                string packLength = Console.ReadLine();

                //convert to int
                int packWidth1 = Int32.Parse(packWidth);
                int packHeight1 = Int32.Parse(packHeight);
                int packLength1 = Int32.Parse(packLength);

                //second if statement
                if (packWidth1 + packHeight1 + packLength1 > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else if (packWidth1 + packHeight1 + packLength1 < 50)
                {
                    int finalCalculation = (packWidth1 * packHeight1 * packLength1);
                    int finalCalculation2 = (finalCalculation * packageWeight1);
                    int finalCalculation3 = (finalCalculation2 / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + finalCalculation3 + ", Thank you!");
                    Console.ReadLine();
                }
            }
            
        }
    }
}
