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
    public List<List<int>> LevelOrder(TreeNode root) {
        var result = new List<List<int>>();
        if(root == null) {
            return result;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0) {
            var size = queue.Count;
            var inner = new List<int>();
            while(size > 0) {
                var node = queue.Dequeue();
                inner.Add(node.val);
                if(node.left != null) {
                    queue.Enqueue(node.left);
                }
                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
                size--;
            }
            result.Add(inner);
        }

        return result;
    }
}
