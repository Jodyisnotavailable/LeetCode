public class Solution {
    public int LargestCombination(int[] candidates) {
        int[] arBitCount = new int[24];

        for (int i = 0; i < candidates.Length; i ++) {
            int j = 23; //e.g. 000000000000000001134432, not reversed
            int count = 0;
            while (candidates[i] > 0) {
                arBitCount[j] += 1 & candidates[i];
                candidates[i] >>= 1;
                j --;
            }
        }

        return arBitCount.Max();
    }
}
