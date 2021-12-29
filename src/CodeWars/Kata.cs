using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class Kata
    {
        public static long FindNextSquare(long num)
        {
            double sqrt = Math.Sqrt(num);

            if (sqrt % 1 > 0)
            {
                return -1;
            }

            return (long)Math.Pow(sqrt + 1, 2);
        }
    }
}
