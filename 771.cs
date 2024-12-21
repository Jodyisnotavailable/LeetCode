public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int res = 0;

        for (int i = 0; i < stones.Length; i ++) {
            if (jewels.IndexOf(stones[i]) != -1) res ++;
        }

        return res;
        
        //hash
        /*
        int res = 0;
        HashSet<char> jewel = new HashSet<char>(jewels);

        for (int i = 0; i < stones.Length; i ++) {
            if (jewel.Contains(stones[i])) res ++;
        }

        return res;
        */        
    }
}
