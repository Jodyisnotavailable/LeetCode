public class Solution {
    public int HeightChecker(int[] heights) {
        int res = 0;
        int[] sorted = new int[heights.Length];
        heights.CopyTo(sorted, 0);
        Array.Sort(sorted);

        for (int i = 0; i < heights.Length; i ++) {
            if (heights[i] != sorted[i]) res ++;
        }
        
        return res;
    }
}
