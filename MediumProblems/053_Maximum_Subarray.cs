
namespace _053_Maximum_Subarray
{
    // LeetCode: https://leetcode.com/problems/maximum-subarray/
    // Difficulty: Medium
    // Approach: Kadane's Algorithm
    // Time: O(n), Space: O(1)
    static void Main(string[] args)
    {
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int result = MaxSubArray(nums);

        Console.WriteLine($"Maximum Subarray Sum: {result}");
    }

    public static int MaxSubArray(int[] nums)
    {
        int currentSum = nums[0];
        int maxSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}