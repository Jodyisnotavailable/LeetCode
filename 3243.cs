public class Solution {
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries) {
        int[] res = new int[queries.Length];
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>(); //adjacency list
        for (int i = 1; i < n; i ++) {
            adj.Add(i-1, new List<int> {i});
        }

        for (int i = 0; i < queries.Length; i ++) {
            adj[queries[i][0]].Add(queries[i][1]);
            res[i] = findShortestD(n, adj);
        }
        
        return res;

        //first attempt, it would always take the earliest path available so some cases wouldnt work
        /*
        int[] res = new int[queries.Length];

        Dictionary<int, int> route = new Dictionary<int, int>(); //keep track of next furthest city
        for (int i = 1; i < n; i ++) {
            route.Add(i-1, i);
        }

        int minD = int.MaxValue;
        for (int i = 0; i < queries.Length; i ++) {
            Console.WriteLine($"i = {i}");
            route[queries[i][0]] = Math.Max(route[queries[i][0]], queries[i][1]);

            //calculate current shortest distance
            int curLocation = 0;
            int distance = 0;
            while (curLocation != n-1) {
                Console.WriteLine($"travelling from {curLocation}...");
                curLocation = route[curLocation];
                Console.WriteLine($"to {curLocation}");
                distance += 1;
            }
            Console.WriteLine($"current distance = {distance}");
            minD = Math.Min(minD, distance);
            Console.WriteLine($"min distance = {minD}");
            res[i] = Math.Min(minD, distance);
        }

        return res;
        */
    }

    private int findShortestD (int n, Dictionary<int, List<int>> adj) {
        bool[] visited = new bool[n];
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(0);
        visited[0] = true;
        
        int curLayNodeCount = 1;
        int nextLayNodeCount = 0;
        int distance = 0;
        while(queue.Count > 0) {
            for (int i = 0; i < curLayNodeCount; i ++) {
                int curNode = queue.Dequeue();

                if (curNode == n-1) {
                    return distance;
                } 

                //explore adjacent nodes
                foreach (var neighbour in adj[curNode]) {
                    if (visited[neighbour]) continue;
                    queue.Enqueue(neighbour);
                    nextLayNodeCount += 1;
                    visited[neighbour] = true;
                }
            }
            
            curLayNodeCount = nextLayNodeCount;
            nextLayNodeCount = 0;
            distance += 1;
           
        }

        return 0;
    }
}
