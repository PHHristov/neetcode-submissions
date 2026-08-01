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
    public int result = 0;
    public int DiameterOfBinaryTree(TreeNode root) 
    {
        GetDiameter(root);
        
        return result;
    }

    public int GetDiameter(TreeNode root)
    {
        if(root == null) return 0;
        int l = GetDiameter(root.left) + 1;
        int r = GetDiameter(root.right) + 1;
        if(l + r - 2 > result) result = l + r - 2;
        return r >= l ? r : l;
    }
}
