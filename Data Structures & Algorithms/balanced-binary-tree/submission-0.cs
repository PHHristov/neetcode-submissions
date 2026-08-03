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
    public bool IsBalanced(TreeNode root) {

        if(root == null) return true;
        if(GetHeight(root) != -1) return true;
        return false;
    }

    public int GetHeight(TreeNode node)
    {
        int lh = 0;
        int rh = 0;
        
        if(node.left == null && node.right == null) return 0;

        if(node.left != null) 
        {
            lh = GetHeight(node.left);
            if(lh == -1) return -1;
            lh++;
        }
        if(node.right != null) 
        {
            rh = GetHeight(node.right);
            if(rh == -1 ) return -1;
            rh++;
        }
        
        if(Math.Abs(lh - rh) > 1) return -1;

        return Math.Max(lh,rh);
    }
}
