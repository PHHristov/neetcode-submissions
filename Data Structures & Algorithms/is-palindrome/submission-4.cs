public class Solution {
    public bool IsPalindrome(string s) 
    {
        string sL = s.ToLower();
        int sPoint = 0;
        int ePoint = s.Length - 1;

        while(sPoint < ePoint)    
        {
            if(!char.IsLetterOrDigit(sL[sPoint]))
            {
                sPoint++;
                continue;
            }
            if(!char.IsLetterOrDigit(sL[ePoint]))
            {
                ePoint--;
                continue;
            }

            if(sL[sPoint] != sL[ePoint]) return false;
            sPoint++;
            ePoint--;
        }
        return true;
    }
}
