public class Solution {
    public int[] GetConcatenation(int[] nums) 
    {
        int[] resul = new int[nums.Length * 2];
        
        int numPointer = 0;

        for(int i = 0; i < resul.Length; i++)
        {
            if(numPointer >= nums.Length) numPointer = 0;

            resul[i] = nums[numPointer];

            numPointer++;
        }
        return resul;
    }
}