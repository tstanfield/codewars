using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class Kata
    {
        public static string PigIt(string str)
        {
            var result = str
                .Split(" ")
                .Select(_ => ToPigLatin(_));

            return string.Join(' ', result);
        }

        private static string ToPigLatin(string s)
        {
            if(!s.All(_ => char.IsLetter(_)))
            {
                return s;
            }

            var firstLetter = s.First();

            var secondPart = string.Concat(s.Skip(1).Take(s.Length - 1));

            return string.Concat(secondPart, firstLetter, "ay");
        }
    }
}
