
namespace _009._Palindrome_Number
{
    // LeetCode: https://leetcode.com/problems/palindrome-number/
    // Difficulty: Easy
    // Approach: Reverse Half
    // Time: O(log n), Space: O(1)
    internal class Program
    {
        static void Main(string[] args)
        {
                        int x = 121;

            bool result = IsPalindrome(x);

            Console.WriteLine($"Is {x} a palindrome? -> {result}");
        }

        static bool IsPalindrome(int x)
        {
            // Negative numbers and numbers ending with 0 (except 0 itself) cannot be palindrome
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int reversedHalf = 0;

            // Reverse only half of the number
            while (x > reversedHalf)
            {
                reversedHalf = reversedHalf * 10 + x % 10;
                x /= 10;
            }

            // For even length: x == reversedHalf
            // For odd length: x == reversedHalf / 10
            return x == reversedHalf || x == reversedHalf / 10;
        }
    }
}