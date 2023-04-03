using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy" + "\r\n" + "Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Welcome " + yourName + ", What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("Good job Getting to " + courseName + ", what page number is that?");
            string pageNum = Console.ReadLine();
            Console.WriteLine(pageNum + "? Maybe pick up the page a little. Anyways need help with anything? Please answer \"True\" or \"False\".");
            string needHelp = Console.ReadLine();
            Console.WriteLine("Noted, thank you. Any positive experiences or other feedback you'd like to be known?");
            string feedBack = Console.ReadLine();
            Console.WriteLine("Thank you, how many hours did you study for?");

            //Trying to convert answer into int type//
            string hoursStudied1 = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hoursStudied1);
            Console.WriteLine("Excellent work getting " + hoursStudied + " hours in! Thanks for everything, a instructor will contact you if needed.");

            Console.ReadLine();
            

        }
    }
}
