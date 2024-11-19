public class Solution {
    public long MaximumSubarraySum(int[] nums, int k) {
        int start = 0;
        int end  = k-1;
        long curSum = 0;
        long ans = 0;

        Dictionary<int, int> count = new Dictionary<int, int>(); //number and its frequency
        for (int i = start; i <= end; i ++) {
            if (!count.ContainsKey(nums[i])) {
                count.Add(nums[i], 1);
            } else {
                count[nums[i]] += 1;
            }
            curSum += nums[i];
        }
        //subarray size should be equal to k if all numbers are distinct
        if (count.Count == k) ans = curSum; 
        end += 1;


        for (int i = start+1; end < nums.Length; i ++) {
            //move window by reducing frequency of previous starting element and reducing sum
            count[nums[i-1]] -= 1;
            if (count[nums[i-1]] == 0) count.Remove(nums[i-1]);
            curSum -= nums[i-1];

            //add new number and update sum
            if (count.ContainsKey(nums[end])) {
                count[nums[end]] += 1;
            } else {
                count.Add(nums[end], 1);
            }
            /*
            foreach (KeyValuePair<int, int> pair in count) {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            */
            curSum += nums[end];

            if (count.Count == k) ans = Math.Max(ans, curSum); 
            //Console.WriteLine($"sum at [{i}] = {curSum}; max sum = {ans}");

            end += 1;
        }
        
        return ans;
    }
}
