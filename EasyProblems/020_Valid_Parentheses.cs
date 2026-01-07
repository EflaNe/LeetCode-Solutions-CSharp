namespace _0020_Valid_Parentheses
{
    // LeetCode: https://leetcode.com/problems/valid-parentheses/
    // Difficulty: Easy
    // Approach: Stack
    // Time: O(n), Space: O(n)
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
