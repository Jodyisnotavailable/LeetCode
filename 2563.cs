public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        long res = 0;
        Array.Sort(nums);
        
        for (int l = 0; l < nums.Length; l ++) {
            for (int r = nums.Length-1; r > l; r --) {
                if (lower <= nums[r]+nums[l] && nums[r]+nums[l] <= upper) {
                    res += 1;
                }
            }
        }

        return res;
    }
}
