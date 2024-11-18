public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int[] res = new int[code.Length];
        if (k == 0) return res;

        int start = 0;
        int end = 0;
        int sum = 0;
        
        //window
        if (k > 0) {
            start = 1;
            end = k;
        } else {
            //previous elements "prefix"
            start = (k+code.Length) % code.Length;
            end = code.Length - 1;
        }
        
        for (int i = start; i <= end; i ++) {
            sum += code[i];
        }

        //update res and then update sum and window
        for (int i = 0; i < code.Length; i ++) {
            res[i] = sum;
            sum -= code[(start) % code.Length];
            sum += code[(end + 1) % code.Length];
            start += 1;
            end += 1;
        }
        
        return res;
        
        //brute force
        /*
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
        */
    }
}
