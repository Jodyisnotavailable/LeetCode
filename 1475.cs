public class Solution {
    public int[] FinalPrices(int[] prices) {
        int[] ans = new int[prices.Length];
        Stack stack = new Stack(); //store index of vlaues

        for (int i = 0; i < prices.Length; i ++) {
            if (stack.Count == 0 || prices[i] > prices[(int)stack.Peek()]) {
                stack.Push(i);
            } else {
                //if value of stored index is greater than or equal to current item
                while (stack.Count != 0 && prices[i] <= prices[(int)stack.Peek()]) {
                    int poppedIndex = (int)stack.Pop();
                    ans[poppedIndex] = prices[poppedIndex]-prices[i];
                }
                stack.Push(i);
            }
            
        }
        //remaining values with no discount
        while (stack.Count != 0) {
            ans[(int)stack.Peek()] = prices[(int)stack.Peek()];
            stack.Pop();
        }

        return ans;

        //two pointer
        /*
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
        */
    }
}
