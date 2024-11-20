public class Solution {
    public int TakeCharacters(string s, int k) {
        if (s.Length < k*3) return -1;
        int res = int.MaxValue;;
        int countA = 0;
        int countB = 0;
        int countC = 0;

        Dictionary<char, int> count = new Dictionary<char, int>();
        count.Add('a', 0);
        count.Add('b', 0);
        count.Add('c', 0);
        for (int i = 0; i < s.Length; i ++) {
            count[s[i]] += 1;
        }
        if (count.Values.Min() < k) return -1;

        //window of the characters we are not taking
        int start = 0;
        for (int end = 0; end < s.Length; end ++) {
            count[s[end]] -= 1;

            //move window if the range outside no longer meets the k requirement
            while (start < s.Length && count.Values.Min() < k) {
                count[s[start]] += 1; //exclude previous left pointer in window
                start += 1;
            }
            //the range to take is length of s - length of window
            res = Math.Min(res, s.Length - (end-start+1));
        }

        return res;
    }
}
