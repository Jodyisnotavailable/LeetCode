public class Solution {
    public bool CanSortArray(int[] nums) {
        int curMin = nums[0];
        int curMax = nums[0]; 
        int lastMax = 0;

        for (int i = 0; i < nums.Length; i ++) {
            if (getBit(nums[i]) == getBit(curMin)) {
                curMax = Math.Max(curMax, nums[i]);
                curMin = Math.Min(curMin, nums[i]);
            } else { //end of segment
                if (curMin < lastMax) return false; //check previous segment
                lastMax = curMax;
                //new segment
                curMax = nums[i];
                curMin = nums[i];
            }
        }
        if (curMin < lastMax) return false; //check final segment
        return true;
    }

    private int getBit(int n) {
        int count = 0;
        while (n > 0) {
            count += n & 1;
            n >>= 1;
        }
        return count;
    }
}
