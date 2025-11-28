using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum_II
{
    // 167 - Two Sum II
    // http://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;

            while (start < end)
            {
                if (numbers[start] + numbers[end] > target)
                {
                    end--;
                }
                else if (numbers[start] + numbers[end] < target)
                {
                    start++;
                }
                else
                {
                    return new int[] { start + 1, end + 1 };
                }
            }

            return new int[] { -1, -1 };

        }
    }
}
