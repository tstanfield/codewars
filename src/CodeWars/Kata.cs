using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            var split = str.Split('-', '_');

            var result = string.Empty;

            int wordCount = 0;

            foreach(var word in split)
            {
                for(int i = 0; i < word.Length; i++)
                {
                    if(wordCount == 0 && i == 0)
                    {
                        //for first word, first char stays as-is
                        result = word[i].ToString();
                    }
                    else if(i == 0)
                    {
                        //for all other words, the first letter gets cap
                        result += word[i].ToString().ToUpper();
                    }
                    else
                    {
                        //for all other letters, go lower case
                        result += word[i].ToString().ToLower();
                    }
                }

                wordCount += 1;                
            }

            return result;
        }
    }
}
