public class Solution {
    public int MinChanges(string s) {
        int res = 0;
        for (int i = 0; i < s.Length; i ++) {
            if (i%2 == 0) {
                if (s[i] != s[i+1]) res += 1;
            }
        }
        return res;
    }
}
