public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int[] res = new int[code.Length];
        if (k == 0) return res;

        for (int lP = 0; lP < code.Length; lP ++) {
            if (k > 0) {
                for (int rP = lP+1; rP-lP <= k; rP ++) {
                    res[lP] += code[rP % code.Length];
                }
            } else {
                //start from furthest point e.g. case 3: at [0] 9+3 instead of 3+9
                for (int rP = lP-Math.Abs(k); rP < lP; rP ++) {
                    //add divisor to make sure result is positive
                    res[lP] += code[(rP+code.Length) % code.Length];
                }
            }
            
        }
        
        return res;
    }
}
