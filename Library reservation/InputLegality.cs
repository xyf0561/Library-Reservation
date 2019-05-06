using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library_reservation
{
    class InputLegality
    {
        public bool legality(string s,int n)
        {
            bool right1;
            bool right2;

            string pattern = "^[0-9]*$";
            Regex rx = new Regex(pattern);
            right1 = rx.IsMatch(s);

            if (n <= 0)
                right2 = true;
            else
            {
                right2 = (s.Length == n);
            }

            return (right1 && right2);
                
        }
    }
}
