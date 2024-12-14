public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int l = 1;

        for(int r = 1; r < nums.Length; r++) {
            if(nums[r] != nums[r-1]) {
                nums[l] = nums[r];
                l ++;
            }
        }

        return l;
        
        //first attempt
        /*
        HashSet<int> res = new HashSet<int>();
        for (int i = 0; i < nums.Length; i ++) {
            res.Add(nums[i]);
        }

        int j = 0;
        foreach (var ele in res) {
            nums[j] = ele;
            j ++;
        }

        return res.Count;
        */
    }
}
