using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE_B3
{
    public class Ohce
    {

        public string palyndrome(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var reversed = new string(str.Reverse().ToArray());

            stringBuilder.Append(reversed);

            if (str == reversed)
            {
                stringBuilder.Append(" Bien dit !");
            }

            return stringBuilder.ToString();
        }

    }
}