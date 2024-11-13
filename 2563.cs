public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        long res = 0;
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length; i ++) {
            //find the min/max value the left/right point needs to be
            int minVal = lower - nums[i];
            int maxVal = upper - nums[i];
            //get the range of array between the min and max
            res += (binSearch(i+1, nums.Length-1, maxVal+1, nums) - binSearch(i+1, nums.Length-1, minVal, nums));
            
        }

        return res;
    }

    private int binSearch(int lPt, int rPt, int target, int[] nums) {
        while (lPt <= rPt) {
            int mPt = lPt + (rPt-lPt)/2;
            if (nums[mPt] >= target) {
                rPt = mPt - 1;
            } else {
                lPt = mPt + 1;
            }
        }
        return rPt;
    }
    
}
