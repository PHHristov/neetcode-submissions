public class Solution {
    public int MajorityElement(int[] nums) 
    {
        int count = 1;
        int result = nums[0];

        foreach(int num in nums)
        {
            if(count == 0)
            {
                result = num;
                count++;
                continue;
            }
            if(num == result) count++;
            else count --;
        }

        return result;
    }
}