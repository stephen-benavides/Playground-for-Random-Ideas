using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.LeetCode
{
    public class TwoSum
    {
        /*
         * Add two numbers in array 
         */
        public static int[] SumNumbers(int[] nums, int target)
        {
            Dictionary<int, int> elements = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int j = target - nums[i];
                elements.Add(nums[i], i);
                if (elements.ContainsKey(j) && elements[nums[i]] != nums[i])
                {
                    return new int[] { nums[j], elements[i] };
                }

            }

            return null;
        }
    }
}