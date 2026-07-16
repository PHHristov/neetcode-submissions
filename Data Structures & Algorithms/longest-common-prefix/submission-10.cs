public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {
        StringBuilder sb = new();

        for(int i = 0; i < strs[0].Length; i ++)    
        {
            char match = strs[0][i];
            for(int j = 0; j < strs.Length; j++)
            {
                if(i >= strs[j].Length || match != strs[j][i]) return sb.ToString();
            }
            sb.Append(match);
        }

        return sb.ToString();
    }
}