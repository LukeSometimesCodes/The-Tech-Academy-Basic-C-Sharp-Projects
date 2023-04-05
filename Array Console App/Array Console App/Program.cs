using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Console_App
{
    class Program
    {
        static void Main()
        {

            //string[] Cars = { "Ford", "Chevrolet", "BMW", "Honda", "Lexus", "Subaru", "Jeep", "Toyota",};

            //Console.WriteLine("Welcome! Pick a Number from 0-7 and you'll receive a car brand");
            //string carAnswer = Console.ReadLine();
            //int carNumber = Int32.Parse(carAnswer);
            //Console.WriteLine("You selected " + carNumber + ", meaning you got " + Cars[carNumber]);
            //Console.ReadLine();

            //same thing but for numbers
            //int[] Numbers = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //Console.WriteLine("Pick a number from 0-10");
            //string numberAnswer = Console.ReadLine();
            //int numAnswer = Int32.Parse(numberAnswer);
            //string result = numAnswer < 11 ? "You chose " + Numbers[numAnswer] : "This number is not between 0-10";
            //Console.WriteLine(result);
            //Console.ReadLine();

            //same thing but with list
            List<string> carList= new List<string>();
            carList.Add("Ford");
            carList.Add("Chevy");
            carList.Add("Honda");
            carList.Add("Subaru");
            carList.Add("Toyota");
            carList.Add("Jeep");

            Console.WriteLine("Pick a number between 0-5");
            string listAnswer = Console.ReadLine();
            int listAnswer1 = Int32.Parse(listAnswer);
            Console.WriteLine("Good job you selected " + carList[listAnswer1]);
            Console.ReadLine();
        }
    }
}
