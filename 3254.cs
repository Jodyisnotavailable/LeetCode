public class Solution {
    public int[] ResultsArray(int[] nums, int k) {
        int count = 1;
        int lP = 0;
        List<int> res = new List<int>();

        //if right pointer is initiated as 1 then it will be out of bound for if nums.Length = 1
        for (int rP = 0; rP < nums.Length; rP ++) {
            if (rP > 0) {
                if (nums[rP-1]+1 == nums[rP]) {
                count += 1;
                }
            }

            //slide window
            if(rP-lP+1 > k) {
                //if element at left pointer is consecutive
                if (nums[lP]+1 == nums[lP+1]) {
                    count -=1;
                }
                lP += 1;
            }

            //subarray
            if (rP-lP+1 == k){
                if (count == k) {
                    res.Add(nums[rP]);
                } else {
                    res.Add(-1);
                }
            }
        }

        return res.ToArray();
    }
}
