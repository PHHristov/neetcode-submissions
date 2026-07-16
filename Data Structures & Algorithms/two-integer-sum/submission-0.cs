public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int> dic = new();
        int[] result = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            int look = target - nums[i];
            if(dic.ContainsKey(look))
            {
                result[0] = dic[look];
                result[1] = i;
                return result;
            } 
            dic[nums[i]] = i;
        }

        return result;
    }
}
