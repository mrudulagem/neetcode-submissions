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
    List<int> result = new List<int>();
    public int KthSmallest(TreeNode root, int k) {
        Helper(root);
        return result[k - 1];
    }

    private void Helper(TreeNode node) {
        if(node == null) {
            return;
        }
        Helper(node.left);
        result.Add(node.val);
        Helper(node.right);
    }
}
