public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int lP = 0;
        int res = int.MaxValue;
        int sum = 0;

        for (int rP = 0; rP < nums.Length; rP ++) {
            sum += nums[rP];

            //push left side of window as far as possible
            while (sum >= target) {
                res = Math.Min(res, rP-lP+1);
                sum -= nums[lP];
                lP += 1;
            } 
        }
        
        return res == int.MaxValue ? 0 : res;
    }
}
