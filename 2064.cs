public class Solution {
    public int MinimizedMaximum(int n, int[] quantities) {
        Array.Sort(quantities);
        int maxQ = quantities[quantities.Length-1];
        int minQ = 1;

        while (maxQ >= minQ) {
            int mdPt = (int)Math.Ceiling((double)(maxQ+minQ)/2);
            int count = 0;
            for (int i = 0; i < quantities.Length; i ++) {
                count += (int)Math.Ceiling((double)quantities[i]/mdPt);
            }
            if (count > n) {
                minQ = mdPt + 1;
            } else {
                maxQ = mdPt - 1;
            }
        }
        
        return minQ;
    }
}
