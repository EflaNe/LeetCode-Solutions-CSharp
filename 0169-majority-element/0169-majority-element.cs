public class Solution {
    public int MajorityElement(int[] nums) {
       Dictionary<int,int> checkList = new Dictionary<int,int>();

        foreach(var num in nums)
        {
            if(!checkList.ContainsKey(num))
            {
                checkList[num] = 0;
            }
            checkList[num]++;

            if(checkList[num] > nums.Length/ 2)
                return num;
        }
        return -1;

    }
}