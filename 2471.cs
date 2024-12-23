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
    public int MinimumOperations(TreeNode root) {
        int count = 0;
        if (root == null) return count;

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0) {
            int qSize = q.Count;
            Dictionary<int, int> curLvNodes = new Dictionary<int, int>();
            for (int i = 0; i < qSize; i ++) {
                TreeNode node = q.Dequeue();
                //turn current lv of nodes into hashmap with value and index
                curLvNodes.Add(node.val, i);
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }

            //sort list
            List<int> ogList = new List<int>(curLvNodes.Keys);
            List<int> sorted = new List<int>(ogList);
            sorted.Sort();
            for (int i = 0; i < ogList.Count; i ++) {
                if (ogList[i] != sorted[i]){
                    //7 (index = 0)
                    int temp = ogList[i];
                    // 5685
                    ogList[i] = sorted[i];
                    //5687
                    ogList[curLvNodes[sorted[i]]] = temp;
                    //update hash
                    curLvNodes[temp] = curLvNodes[sorted[i]];
                    
                    count ++;
                }
            }
            
            /*
            for (int i = 0; i < sorted.Count; i ++) {
                if (curLvNodes.IndexOf(sorted[i]) != i){
                    int temp = curLvNodes[i];
                    curLvNodes[i] = sorted[i];
                    curLvNodes[curLvNodes.LastIndexOf(sorted[i])] = temp;
                    count ++;
                }
            }
            */
        }
        
        return count;
        
    }
}
