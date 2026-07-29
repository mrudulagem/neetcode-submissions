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
    public int MaxDepth(TreeNode root) {
        int depth = 0;
        return  Helper(root, depth);
    }

    private int Helper(TreeNode node, int depth) {
        if(node == null) {
            return depth;
        }
        var left_depth = Helper(node.left, depth + 1);
        var right_depth = Helper(node.right, depth + 1);
        return Math.Max(left_depth, right_depth);
    }
}
