using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class Kata
    {
        public static int DuplicateCount(string str)
        {
            var duplicateCharacters = new Dictionary<char, int>();

            str = str.ToLowerInvariant();

            foreach(char c in str)
            {                
                if(duplicateCharacters.ContainsKey(c))
                {
                    duplicateCharacters[c] += 1;
                }
                else
                {
                    duplicateCharacters.Add(c, 0);
                }
            }

            if(duplicateCharacters.Count == 0)
            {
                return 0;
            }

            return duplicateCharacters.Count(_ => _.Value > 0);
        }
    }
}
