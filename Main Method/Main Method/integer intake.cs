using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class integer_intake
    {

        public int method(int addition25)
        {
            return addition25 + 25;
        }

        public int method(decimal addition20)
        {
            int userNum = Convert.ToInt32(addition20);
            return userNum + 20;
        }

        public int method(string addition45)
        {
            
            return Convert.ToInt32(addition45) + 45;
        }
    }
}
