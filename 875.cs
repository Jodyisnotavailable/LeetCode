public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int minSpd = 1;

        Array.Sort(piles);
        int maxSpd = piles[piles.Length-1];

        while (maxSpd >= minSpd) {
            int mdPt = (int)Math.Ceiling((double)(maxSpd+minSpd)/2);
            int hourCount = 0;
            for (int i = 0; i < piles.Length; i ++) {
                hourCount += (int)Math.Ceiling((double)piles[i]/mdPt);
            }
            if (hourCount > h) {
                minSpd = mdPt + 1;
            } else {
                maxSpd = mdPt - 1;
            }
        }
        


        return minSpd;
    }
}
