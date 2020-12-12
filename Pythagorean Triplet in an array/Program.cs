using System;
using System.Collections.Generic;

namespace Pythagorean_Triplet_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 3, 1, 4, 6, 5 };
            var result = GetTriplet(nums);
            foreach (var n in result)
                Console.WriteLine(string.Join(" ", n));
        }


        // O(N2) and no extra space.
        static IList<List<double>> GetTriplet(int[] nums)
        {
            if (nums == null || nums.Length == 0) return null;
            IList<List<double>> output = new List<List<double>>();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            Array.Sort(nums);

            for (int i = nums.Length - 1; i >= 2; i--)
            {
                int l = 0;
                int r = i - 1;
                while (l < r)
                {
                    int lVal = nums[l];
                    int rVal = nums[r];
                    int sum = lVal + rVal;
                    if (nums[i] == sum)
                        output.Add(new List<double>() { Math.Sqrt(lVal), Math.Sqrt(rVal), Math.Sqrt(nums[i]) });
                    if (sum < nums[i]) l++;
                    else r--;
                }
            }
            return output;
        }
    }
}
