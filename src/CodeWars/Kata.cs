using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class Mixing
    {
        public static string Mix(string s1, string s2)
        {
            var result = string.Empty;

            var q = GetChars(s1, 1)
                .Concat(GetChars(s2, 2))
                .GroupBy(
                    freq => freq,
                    (key, values) =>
                        new Tuple<char, int, int>(key.Item1, key.Item2, values.Count())
                    )
                .Where(_ => _.Item3 > 1);

            var qq = q.GroupBy(
                s => s.Item1,
                (key, values) => new
                    {
                        Key = key,
                        Values = values,
                        Prefix = GetPrefix(values)
                    }
                )
                .OrderByDescending(_ => _.Values.Max(__ => __.Item3))
                .ThenBy(_ => _.Prefix == "=" ? "999" : _.Prefix)
                .ThenBy(_ => _.Key)
                ;

            foreach(var x in qq)
            {
                if (result != string.Empty)
                {
                    result += "/";
                }

                result += x.Prefix + ":" + new string(x.Key, x.Values.Max(_ => _.Item3));
            }

            return result;
        }

        private static string GetPrefix(IEnumerable<Tuple<char, int, int>> items)
        {
            var g = items.OrderByDescending(_ => _.Item3);

            var first = g.First();
            var last = g.Last();
            
            if(items.Count() == 2 && first.Item3 == last.Item3)
            {
                return "=";
            }
            else
            {
                return first.Item2.ToString();
            }
        }

        public static List<Tuple<char, int>> GetChars(string str, int order)
        {
            var result = str
                .ToList()
                .Where(c => char.IsLetter(c) && char.IsLower(c))
                .Select(c => new Tuple<char, int>(c, order))
                .ToList();

            return result;
        }
    }
}
