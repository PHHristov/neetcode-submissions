public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        Dictionary<char,int> dic = new();
        if(s.Length != t.Length) return false;
        foreach(char c in s)
        {
            dic[c] = dic.GetValueOrDefault(c) + 1;
        }
        foreach(char c in t)
        {
            dic[c] = dic.GetValueOrDefault(c) - 1;
        }

        return dic.All(x => x.Value == 0);
        
    }
}
