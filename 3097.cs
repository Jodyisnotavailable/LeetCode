public class Solution {
    public int MinimumSubarrayLength(int[] nums, int k) {
        int lPoint = 0;
        int[] arrBits = new int[32];
        int res = int.MaxValue;

        for (int r = 0; r < nums.Length; r ++) {
            if (nums[r] >= k) return 1;
            updateBits(arrBits, nums[r], 1);

            int curInt = convertBitToInt(arrBits);
            while (lPoint <= r && curInt >= k) {
                res = Math.Min(res, r-lPoint+1);
                Console.WriteLine(res);
                updateBits(arrBits, nums[lPoint], -1);
                curInt = convertBitToInt(arrBits);
                lPoint += 1;
            } 
        }

        if (res != int.MaxValue) return res;
        return -1;
    }

    private void updateBits(int[] arrBits, int n, int diff) {
        for (int i = 0; i < 32; i ++) {
                if (((n >> i) & 1) != 0) {
                    arrBits[i] += diff;
                }
            }
    }

    private int convertBitToInt (int[] arrBits) {
        int bitRes = 0;
        for (int i = 0; i < 32; i ++) {
            if (arrBits[i] != 0) {
                bitRes |= 1 << i;
            }
        }
        return bitRes;
    }
}
