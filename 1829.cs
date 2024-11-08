public class Solution {
    public int[] GetMaximumXor(int[] nums, int maximumBit) {
        List<int> ans = new List<int>();
        int xor = 0;
        int k = Convert.ToInt32(Math.Pow(2, maximumBit) - 1);
        
        for (int i = 0; i < nums.Length; i ++) {
            xor ^= nums[i];
        }

        for (int j = nums.Length - 1; j >= 0; j --) {
            ans.Add(xor ^ k);
            xor ^= nums[j];
        }

        return ans.ToArray();
    }
}
