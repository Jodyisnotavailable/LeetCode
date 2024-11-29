public class Solution {
    public int OrangesRotting(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int freshO = 0, res = 0;

        Queue<List<int>> queue = new Queue<List<int>>();
        for (int i = 0; i < m; i ++) {
            for (int j = 0; j < n; j ++) {
                //start bps at every rotten orange
                if (grid[i][j] == 2) {
                    queue.Enqueue(new List<int> {i, j});
                } else if (grid[i][j] == 1) {
                    freshO ++;
                }
            }
        }

        var move = new List<List<int>> {
            new List<int> {-1, 0},
            new List<int> {1, 0},
            new List<int> {0, -1},
            new List<int> {0, 1}
        };

        while (queue.Count > 0 && freshO > 0) {
            int queueSize = queue.Count;
            //use initial queue size for loop
            //if not, when new node gets added to the queue it will keep increasing
            //not entering new layer and breaking the algorithm
            for (int i = 0; i < queueSize; i ++) {
                var pos = queue.Dequeue();
                int rowIndex = pos[0];
                int colIndex = pos[1];

                //rot grows 4 directionally
                foreach (var direction in move) {
                    int newRowIn = rowIndex + direction[0];
                    int newColIn = colIndex + direction[1];
                    //if new index is valid and has a fresh orange
                    if (newRowIn >= 0 && newRowIn < m && 
                        newColIn >= 0 && newColIn < n && 
                        grid[newRowIn][newColIn] == 1) {
                        grid[newRowIn][newColIn] = 2;
                        queue.Enqueue(new List<int> {newRowIn, newColIn});
                        freshO --;
                    }
                }
            }
            res ++;
        }

        return freshO > 0 ? -1 : res;
    }
}
