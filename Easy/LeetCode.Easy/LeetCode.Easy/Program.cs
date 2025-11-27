using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 0001 - Two Sum
// LeetCode link: https://leetcode.com/problems/two-sum/



namespace LeetCode.Easy
{
        public class TwoSumSolution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                var map = new Dictionary<int, int>(); 

                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];

                    if (map.ContainsKey(complement))
                    {
                        return new int[] { map[complement], i };
                    }

                    if (!map.ContainsKey(nums[i]))
                    {
                        map.Add(nums[i], i);
                    }
                }       
                throw new InvalidOperationException("No solution found.");
            }
        }  
}

