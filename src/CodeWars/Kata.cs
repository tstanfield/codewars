using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class Kata
    {
        public static string Likes(string[] name)
        {
            if(name.Count() == 0)
            {
                return $"no one likes this";
            }
            else if(name.Count() == 1)
            {
                return $"{ name[0] } likes this";
            }
            else if(name.Count() == 2)
            {
                return $"{ name[0] } and { name[1] } like this";
            }
            else if(name.Count() == 3)
            {
                return $"{ name[0] }, { name[1] } and { name[2] } like this";
            }
            else
            {
                return $"{ name[0] }, { name[1] } and { name.Count() - 2 } others like this";
            }
        }
    }
}
