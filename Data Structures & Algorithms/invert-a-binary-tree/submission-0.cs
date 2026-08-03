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
    public TreeNode InvertTree(TreeNode root) 
    {
        Stack<TreeNode> st = new();
        if(root == null) return root;
        st.Push(root);

        while(st.Count > 0)
        {
            TreeNode node = st.Pop();

            TreeNode tmp = node.right;
            node.right = node.left;
            node.left = tmp;

            if(node.left != null) st.Push(node.left);
            if(node.right != null) st.Push(node.right);

        }

        return root;
    }
}
 