public class Solution {
    public bool[] IsArraySpecial(int[] nums, int[][] queries) {
        bool[] res = new bool[queries.Length];
        int[] subLength = new int[nums.Length]; // keep track of how long a special subarray is for each element

        int count = 1;
        subLength[0] = count;
        for (int i = 1; i < nums.Length; i ++) {
            if (nums[i]%2 != nums[i-1]%2) {
                count += 1;
            } else {
                count = 1;
            }
            subLength[i] = count;
        }
        
        //for example, if the query is [0,4] with length of 5
        //but the longest possible special subarray ending at nums[4] is 1 -> false 
        for (int i = 0; i < queries.Length; i ++) {
            res[i] = (queries[i][1] - queries[i][0] + 1 <= subLength[queries[i][1]]);
        }

        return res;
    }
}
