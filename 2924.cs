public class Solution {
    public int FindChampion(int n, int[][] edges) {
        int res = 0;
        Dictionary<int, int> count = new Dictionary<int, int>(); //keep track of number of parent
        for (int i = 0; i < n; i ++) {
            count.Add(i, 0);
        }

        for (int i = 0; i < edges.Length; i ++) {
            for (int j = 0; j < edges[i].Length; j ++) {
                count[edges[i][j+1]] += 1;
                j ++;
            }
        }

        int unique = 0;
        foreach(KeyValuePair<int, int> kvp in count) {
            if (kvp.Value == 0) {
                res = kvp.Key;
                unique += 1;
            }
        }

        if (unique > 1) return -1;
        return res;
    }
}
