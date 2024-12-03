public class Solution {
    public bool RotateString(string s, string goal) {
        if (s.Length != goal.Length) return false;
        string newString = string.Concat(Enumerable.Repeat(s, 2));
        return (newString.Contains(goal));
        
        /* first attempt, brute force
        if (s.Length != goal.Length) return false;

        string newS = s.Substring(1) + s[0].ToString();
        if (s == goal || newS == goal) return true;

        for (int i = 1; i < s.Length; i ++) {
            newS = newS.Substring(1) + s[i].ToString();
            if (newS == goal) return true;
        }

        return false;
        */
    }
}
