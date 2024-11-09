public class Solution {
    public long MinEnd(int n, int x) {
        //positive int[] num in ascending order; num.length = n
        //num[i] & num[i+1] ... & num[n-1] = x
        /*
        List<long> num = new List<long>();
        num.Add(x);
        int count = 1;
        
        int nextEle = x+1;
        for (int i = 1; i < n ; i ++) {
            while ((x & nextEle) != x) {
                nextEle ++;
            }
            num.Add(nextEle);
            nextEle ++;
        }

        return num[n-1];   
        */

        long res = x;
        for (int i = 1; i < n ; i ++) {
            res = (res + 1) | x;
        }
        

        return res;   
    }
}
