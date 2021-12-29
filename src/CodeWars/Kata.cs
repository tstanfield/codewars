using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class Kata
    {
        public static int Lcm(List<int> nums)
        {
            if(nums.Count == 0)
            {
                return 1;
            }
            else if(nums.Count == 1)
            {
                return nums[0];
            }

            int lcm = LcmForTwo(nums[0], nums[1]);
            
            for(int i = 2; i < nums.Count; i++)
            {
                lcm = LcmForTwo(nums[i], lcm);
            }

            return lcm;
        }

        //euclidean algorithm https://en.wikipedia.org/wiki/Euclidean_algorithm
        public static int Gcd(int a, int b)
        {
            if(b == 0)
            {
                return a;
            }

            return Gcd(b, a % b);
        }

        //https://en.wikipedia.org/wiki/Least_common_multiple
        public static int LcmForTwo(int a, int b)
        {
            return a / Gcd(a, b) * b;
        }
    }
}
