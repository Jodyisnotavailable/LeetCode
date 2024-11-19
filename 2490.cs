public class Solution {
    public bool IsCircularSentence(string sentence) {

        string[] words = sentence.Split(' ');
        if (!words[words.Length-1].EndsWith(words[0][0])) return false;

        for (int i = 0; i+1 < words.Length; i ++) {
            if (!words[i].EndsWith(words[i+1][0])) return false;
        }

        return true;
    }
}
