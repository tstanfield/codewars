using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class PickPeaks
    {
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            var result = new Dictionary<string, List<int>>()
            {
                ["pos"] = new List<int>(),
                ["peaks"] = new List<int>(),
            };

            int prev = 0;
            int curr = 0;
            //for some reason the problem ignores peaks at first position
            bool increasing = false;
            int increasingPos = 0;

            for(int i = 0; i < arr.Count(); i++)
            {
                curr = arr[i];
                if(i == 0)
                {                    
                    prev = curr;
                    continue;
                }

                if(prev > curr)
                {
                    if(increasing)
                    {
                        //new peak at prev position
                        result["pos"].Add(increasingPos);
                        result["peaks"].Add(prev);
                    }
                    increasing = false;
                }
                else if(prev == curr)
                {
                    // plateau - if curr is at the end, make a plateau-peak
                }
                else
                {
                    increasingPos = i;
                    increasing = true;
                }

                prev = curr;
            }
            
            return result;
        }
    }
}
