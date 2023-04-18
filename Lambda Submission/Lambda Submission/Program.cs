using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission
{
    class Program
    {
        public static void Main()
        {
            List<Employee> ListOne = new List<Employee>()
            {
                new Employee() { ID = 1, FirstName = "Luke", LastName = "Morreale" },
            new Employee() { ID = 2, FirstName = "Bob", LastName = "Bobson" },
            new Employee() { ID = 3, FirstName = "Steven", LastName = "Stevenson" },
            new Employee() { ID = 4, FirstName = "Bill", LastName = "Billson" },
            new Employee() { ID = 5, FirstName = "Joe", LastName = "Guyson" },
            new Employee() { ID = 6, FirstName = "Derek", LastName = "Derekson" },
            new Employee() { ID = 7, FirstName = "Joe", LastName = "Johnson" },
            new Employee() { ID = 8, FirstName = "Jeremy", LastName = "Jeremyson" },
            new Employee() { ID = 9, FirstName = "Ted", LastName = "Tedson" },
            new Employee() { ID = 10, FirstName = "Kevin", LastName = "Kevinson" }
        };
            List<Employee> joelist = new List<Employee>() { };


            foreach (Employee e in ListOne)
            {
                if (e.FirstName == "Joe") { ListOne.Add(e); }
            }

            List<Employee> Listtwo = ListOne.Where(i => i.FirstName == "Joe").ToList();

            //Lambda presssion greater then 5 list
            List<Employee> Listthree = ListOne.Where(j => j.ID > 5).ToList();

            Console.WriteLine(Listthree);
            Console.ReadLine();
        }

    }
}
