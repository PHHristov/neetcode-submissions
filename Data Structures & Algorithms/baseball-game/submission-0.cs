public class Solution {
    public int CalPoints(string[] operations) 
    {   
        Stack<int> st = new();

        foreach( string op in operations)
        {
            if(op == "+")
            {
                int op1 = st.Pop();
                int op2 = st.Peek();
                st.Push(op1);
                st.Push(op1 + op2);
            }
            else if(op == "D") st.Push(st.Peek() * 2);
            else if(op == "C") st.Pop();
            else st.Push(Int32.Parse(op));
        }

        return st.ToArray().Sum();
    }
}