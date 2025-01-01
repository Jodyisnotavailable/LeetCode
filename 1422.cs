public class Solution {
    public int MaxScore(string s) {
        int count1 = s.Count(c => c == '1');
        int res = 0;
        int count0 = 0;

        //split at first index if all characters are identical
        if (count1 == s.Length || s.Count(c => c == '0') == s.Length) return s.Length-1;

        for (int i = 0; i < s.Length-1; i ++) {
            if (s[i] == '0') {
                count0 ++;
            } else {
                count1 --;
            }
            res = Math.Max(res, count0+count1);
        }
        
        return res;
    }
}
