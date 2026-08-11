public class Solution {
    public int MinOperations(string[] logs) 
    {
        Stack<string> st = new();

        foreach(string log in logs)
        { 
            if(log == "../") {
                if(st.Count > 0) st.Pop();
            }
            else if(log == "./") continue;
            else st.Push(log);
        }
        return st.Count;
    }
}