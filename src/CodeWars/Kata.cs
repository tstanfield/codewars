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
            var result = GetChars(s1, 1)
                .Concat(GetChars(s2, 2))
                .GroupBy(
                    freq => freq,
                    (key, values) =>
                        new Tuple<char, int, int>(key.Item1, key.Item2, values.Count())
                    )
                .Where(_ => _.Item3 > 1)
                .GroupBy(
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
                .Select(_ => _.Prefix + ":" + new string(_.Key, _.Values.Max(__ => __.Item3)))
                ;

            return string.Join('/', result);            
        }

        private static string GetPrefix(IEnumerable<Tuple<char, int, int>> items)
        {
            var sortedItems = items.OrderByDescending(_ => _.Item3);

            var first = sortedItems.First();
            var last = sortedItems.Last();
            
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
