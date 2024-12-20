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
    public TreeNode ReverseOddLevels(TreeNode root) {
        if (root == null) return null;

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int lv = 0;

        while (q.Count > 0) {
            int qSize = q.Count;
            List<TreeNode> curLvNodes = new List<TreeNode>();
            //go through all nodes in current lv
            for (int i = 0; i < qSize; i ++) {
                TreeNode node = q.Dequeue();
                curLvNodes.Add(node);
                //queue child nodes
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }

            //odd level
            if (lv%2 != 0) {
                //swap start with end
                int l = 0;
                int r = curLvNodes.Count - 1;
                while (r > l) {
                    int placeHold = curLvNodes[l].val;
                    curLvNodes[l].val = curLvNodes[r].val;
                    curLvNodes[r].val = placeHold;
                    l ++;
                    r --;
                }
            }
            lv ++;
        }
        
        return root;
    }
}
