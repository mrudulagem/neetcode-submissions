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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int pre_start = 0, pre_end = preorder.Length - 1, in_start = 0, in_end = inorder.Length - 1;
        return Helper(preorder, inorder, pre_start, pre_end, in_start, in_end);
    }

    private TreeNode Helper(int[] preorder, int[] inorder, int pre_start, int pre_end, int in_start, int in_end) {
        if(in_start > in_end || pre_start > pre_end) {
            return null;
        }

        int mid = in_start;
        for(mid = in_start; mid <= in_end; mid++) {
            if(preorder[pre_start] == inorder[mid]) {
                break;
            }
        }
        int leftSize = mid - in_start;
        TreeNode curr = new TreeNode(preorder[pre_start]);
        curr.left = Helper(preorder, inorder, pre_start + 1, pre_start + leftSize, in_start, mid - 1);
        curr.right = Helper(preorder, inorder, pre_start + leftSize + 1, pre_end, mid + 1, in_end);

        return curr;
    }
}
