using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission
{
    class Program
    {
        public static void Main(string[] args)
        {
           foreach (string name in Names)
            {
                if (name == "Joe")
                {
                    newName.Add(name);
                }
            }

           int count Names.Names.Count(x => x.Names == "Joe");
            Console.WriteLine(count);
        }


        public List<string> Names = new List<string>() { "Luke", "John", "Joe", "Steven", "Ronald", "TechAcademy", "Bob", "Wendy", "ErikGross", "Jeremy" };
        public List<string> newName = new List<string>() { };

    }
}
