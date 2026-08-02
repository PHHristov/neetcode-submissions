public class Solution {
    public void ReverseString(char[] s) 
    {
        int sPoint = 0;
        int ePoint = s.Length - 1;

        while(sPoint < ePoint)    
        {
            char tmp = s[sPoint];
            s[sPoint] = s[ePoint];
            s[ePoint] = tmp;
            sPoint++;
            ePoint--;
        }


    }
}