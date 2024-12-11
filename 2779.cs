public class Solution {
    public int MaximumBeauty(int[] nums, int k) {
        int res = 0;
        int dif = 2*k; //max diff possible for -k or +k
        Array.Sort(nums);

        int r = 0;
        for (int l = 0; l < nums.Length; l ++) {
            while (r < nums.Length && nums[r]-nums[l] <= dif) {
                r ++;
            }
            res = Math.Max(res, r-l);
        }

        return res;
    }
}
