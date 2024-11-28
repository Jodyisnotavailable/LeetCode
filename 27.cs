public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int j = 0; //the index that the element should go to; increases by 1 each time

        for (int i = 0; i < nums.Length; i ++) {
            if (nums[i] != val) {
                nums[j] = nums[i];
                j += 1;
            }
        }

        return j;
    }
}
