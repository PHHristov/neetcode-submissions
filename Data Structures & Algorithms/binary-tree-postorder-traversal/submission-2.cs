/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<int> PostorderTraversal(TreeNode root) 
    {
        Stack<TreeNode> st = new();
        List<int> result = new();

        if (root == null) return result;
        st.Push(root);

        while(st.Count > 0)
        {
            TreeNode node = st.Pop();
            result.Add(node.val);

            if(node.left != null)
            {
                st.Push(node.left);
            }

            if(node.right != null)
            {
                st.Push(node.right);
            }

        }
        result.Reverse();
        
        return result;
    }
}