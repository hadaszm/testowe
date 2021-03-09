using System;
using System.Collections.Generic;
using System.Text;

namespace IO2
{
    public class Calculator
    {
        public int Calculate(string values, string sep = " ")
        {
            string[] arguments = values.Split(sep);
            
            int res = 0;
            foreach (var arg in arguments)
            {
                res += int.Parse(arg);
            }

            return res;
        }
    }
}
