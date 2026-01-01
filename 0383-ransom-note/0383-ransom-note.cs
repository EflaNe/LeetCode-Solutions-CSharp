public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] counts = new int[26];

        foreach(char c in magazine)
        {
            int index = c - 'a';
            counts[index]++;
        }
        foreach(char c in ransomNote)
        {
            int index = c - 'a';
            counts[index]--;

            if(counts[index] < 0)
            {
                return false;
            }
        }
        return true;
    }
}