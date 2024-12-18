public class Solution {
    public int[] FinalPrices(int[] prices) {
        int[] ans = new int[prices.Length];

        int r = 1;
        for (int l = 0; l < prices.Length; l ++) {
            Console.WriteLine($"left pointer at index{l}");
            //at the end of array
            if (l == prices.Length-1) {
                ans[l] = prices[l];
                break;
            }

            while (r+1 < prices.Length && prices[r]>prices[l]) r ++;
            if (prices[l] >= prices[r]) {
                ans[l] = prices[l] - prices[r];
            } else {
                ans[l] = prices[l];
            }
            //update right pointer
            if (l+1 < prices.Length - 1) r = l + 2;
            
        }

        return ans;
    }
}
