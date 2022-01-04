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

            var duplicateChars = new Dictionary<char, Dictionary<string, int>> { };

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
                        Rank = GetRank(values)
                    }
                )
                .OrderByDescending(_ => _.Values.Max(__ => __.Item3))
                .ThenBy(_ => _.Rank)
                .ThenBy(_ => _.Key)
                ;

            foreach(var x in qq)
            {
                var g = x.Values.OrderByDescending(_ => _.Item3);

                var first = g.First();
                var last = g.Last();

                if (result != string.Empty)
                {
                    result += "/";
                }

                if(x.Values.Count() == 2 && first.Item3 == last.Item3)
                {
                    result += "=:" + new string(first.Item1, first.Item3);                    
                }
                else
                {
                    result += first.Item2 + ":" + new string(first.Item1, first.Item3);
                }                
            }


            return result;
        }

        private static int GetRank(IEnumerable<Tuple<char, int, int>> items)
        {
            var g = items.OrderByDescending(_ => _.Item3);

            var first = g.First();
            var last = g.Last();
            
            if(items.Count() == 2 && first.Item3 == last.Item3)
            {
                return 99;
            }
            else
            {
                return first.Item2;
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

        public static Dictionary<char, int> GetDuplicateCharCounts(string str)
        {
            var result = new Dictionary<char, int> { };

            foreach(var c in str.ToList())
            {
                if(!char.IsLower(c) && !char.IsLetter(c))
                {
                    continue;
                }

                if(result.ContainsKey(c))
                {
                    result[c] += 1;
                }
                else
                {
                    result.Add(c, 1);
                }
            }

            return result;
        }
    }
}
