using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Luke";

            var otherName = "notLuke";
        }

        class Test
        {
            private int id;
            private string name;

            public Test() : this(0, "Sample")
            {
            }

            public Test(int id, string name)
            {
                this.id = 5;
                this.name = "Luke";
            }
        }




        }
}
