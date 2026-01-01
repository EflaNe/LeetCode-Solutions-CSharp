public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach (int number in nums)
        {
            if (seenNumbers.Contains(number))
            {
                return true;
            }

            seenNumbers.Add(number);
        }
        
        return false;
    }
}