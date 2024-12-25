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
    public IList<int> LargestValues(TreeNode root) {
        IList<int> res = new List<int>();
        if (root == null) return res;

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int lv = 0;

        while (q.Count > 0) {
            int qSize = q.Count;
            int max = int.MinValue;
            for (int i = 0; i < qSize; i ++) {
                TreeNode node = q.Dequeue();
                max = Math.Max(max, node.val);
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            res.Add(max);
            lv ++;
        }
        
        return res;
    }
}
