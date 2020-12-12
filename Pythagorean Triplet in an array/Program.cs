using System;
using System.Collections.Generic;

namespace Pythagorean_Triplet_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        // O(N2) and no extra space.
        static IList<List<int>> GetTriplet(int[] nums)
        {
            if (nums == null || nums.Length == 0) return null;
            IList<List<int>> output = new List<List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            Array.Sort(nums);

            int l = 0;
            for (int i = nums.Length - 1; i >= 2; i--)
            {
                int r = i - 1;
                while (l < r)
                {
                    int lVal = nums[l];
                    int rval = nums[r];
                    int sum = Convert.ToInt32(Math.Pow(lVal, 2) + Math.Pow(rval, 2));
                    if (nums[i] == sum)
                        output.Add(new List<int>() { lVal, rval, nums[i] });
                    else if (sum < nums[i]) l++;
                    else r--;
                }
            }
            return output;
        }
    }
}
