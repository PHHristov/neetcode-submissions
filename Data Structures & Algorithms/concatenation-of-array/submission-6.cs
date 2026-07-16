public class Solution {
    public int[] GetConcatenation(int[] nums) 
    {
        int [] result = nums.Concat(nums).ToArray();
        return result;
    }
}