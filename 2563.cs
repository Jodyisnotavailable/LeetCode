public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        long res = 0;
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length; i ++) {
            for (int j = i+1; j < nums.Length; j ++) {
                if (lower <= nums[i]+nums[j] && nums[i]+nums[j] <= upper) {
                    res += 1;
                }
            }
        }

        return res;
    }
}
