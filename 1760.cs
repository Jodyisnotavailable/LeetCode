public class Solution {
    public int MinimumSize(int[] nums, int maxOperations) {
        int minN = 1;
        int maxN = nums.Max();

        while (minN < maxN) {
            int midPt = (maxN+minN)/2;
            
            if (divisible(nums, midPt, maxOperations)) {
                maxN = midPt;
            } else {
                minN = midPt+1;
            }
        }

        return minN;
    }

    private bool divisible(int[] nums, int maxN, int maxOperations) {
            int ops = 0;
            //example 2: 2/2 = 1 & 8/2 = 4 -> it would take 1 operation for [2] to reach the min number of 2
            //while it would take 4 operations for [8] to reach the min num of 2
            for (int i = 0; i < nums.Length; i ++) {
                ops += (nums[i]+maxN-1)/maxN - 1;
                if (ops > maxOperations) return false;
            }
            
            return true;
        }
}
