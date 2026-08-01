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
    public List<int> PreorderTraversal(TreeNode root) 
    {
        List<int> result = new();

        Traverse(root, result);    

        return result;
    }


    public void Traverse(TreeNode root, List<int> result)
    {
        if(root == null) return;

        result.Add(root.val);
        Traverse(root.left, result);
        Traverse(root.right, result);
    }
}