public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum) {
        int res = 0;
        HashSet<int> bannedSet = new HashSet<int>(); //reduce lookup time
        for (int i = 0; i < banned.Length; i ++) bannedSet.Add(banned[i]);

        int sum = 0;
        for (int num = 1; num <= n; num ++) {
            if (!bannedSet.Contains(num) && sum+num <= maxSum) {
                sum += num;
                res ++;
            }
        }

        return res;
    }
}
