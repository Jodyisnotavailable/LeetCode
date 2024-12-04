public class Solution {
    public bool CanMakeSubsequence(string str1, string str2) {
        int i = 0;
        int j = 0;

        while (i < str1.Length && j < str2.Length) {
            int str1i = (int)str1[i] % 32;
            int str2j = (int)str2[j] % 32;
            //2nd case for z->a; 3rd case for y->z
            if (str1i == str2j || (str1i+1)%26 == str2j || str1i+1 == str2j) {
                i ++;
                j ++;
            } else {
                i ++;
            }
        }
        return (j == str2.Length);
    }
}
