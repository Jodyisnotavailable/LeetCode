public class Solution {
    public int WaysToSplitArray(int[] nums) {
        int res = 0;
        long rightSum = 0;
        for (int i = 0; i < nums.Length; i ++) {
            rightSum += nums[i];
        }

        long leftSum = 0;
        for (int i = 0; i < nums.Length-1; i ++) {
            leftSum += nums[i];
            rightSum -= nums[i];
            if (leftSum >= rightSum) res ++;
        }

        return res;

        /*
        int res = 0;

        int[] prefixSum = new int[nums.Length];
        int sum = 0;
        for (int i = 0; i < nums.Length; i ++) {
            sum += nums[i];
            prefixSum[i] = sum;
            Console.WriteLine(prefixSum[i]);
        }

        for (int j = 0; j < prefixSum.Length-1; j ++) {
            int left = prefixSum[j];
            int right = sum-left;
            if (left >= right) res ++;
        }
        
        return res;
        */
    }
}
