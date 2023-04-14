using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission
{
    class Class
    {
        public void Method(int userNum) //method that outputs a integer
        {
            int equation = userNum / 2;
            Console.WriteLine(equation);
        }

        public void Thing(int userNum) //method with output parameter
        {

            int.TryParse("5", out userNum);

        }

        //overload methods below 
        public int overload(int method)
        {
            int numbertest = 10;
            return numbertest * 5;
        }

        public int overload(decimal numbertest)
        {
            int method = (int)Convert.ToDecimal(numbertest);
            return method + 5;
        }

    }

   
       


}
