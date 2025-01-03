public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        int[] res = new int[queries.Length];
        HashSet<char> vowel = new HashSet<char>{'a', 'e', 'i', 'o', 'u'};
        int[] prefixSum = new int[words.Length];

        int sum = 0;
        for (int i = 0; i < words.Length; i ++) {
            if (vowel.Contains(words[i][0]) && vowel.Contains(words[i][words[i].Length-1])) sum ++;
            prefixSum[i] = sum;
        }

        for (int i = 0; i < queries.Length; i++) {
            //no need to deduct previous sum
            if (queries[i][0] == 0) {
                res[i] = prefixSum[queries[i][1]];
            } else {
                res[i] = prefixSum[queries[i][1]] - (prefixSum[queries[i][0] - 1]);
            }
        }

        return res;

        /*
        HashSet<char> vowel = new HashSet<char>{'a', 'e', 'i', 'o', 'u'};
        List<int> temp = new List<int>(); //index of words that satisfy the vowel conditions
        int[] res = new int[queries.Length];

        for (int i = 0; i < words.Length; i ++) {
            if (vowel.Contains(words[i][0]) && vowel.Contains(words[i][words[i].Length-1])) temp.Add(i);
        }

        for (int i = 0; i < queries.Length; i++) {
            for (int j = queries[i][0]; j <= queries[i][1]; j ++) {
                if (temp.Contains(j)) res[i] += 1;
            }
        }
        
        return res;
        */
    }
}
