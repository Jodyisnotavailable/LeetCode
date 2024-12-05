public class Solution {
    public bool CanChange(string start, string target) {
        int i = 0;
        int j = 0;

        while (i < start.Length || j < target.Length) {
            //skip underscore
            while (i < start.Length && start[i] == '_') i ++;
            while (j < target.Length && target[j] == '_') j ++;
            
            //if we reach the end of one of the strings
            if (i == start.Length || j == target.Length) return i == start.Length && j == target.Length;

            //L and R cant cross each other so the letters have to match to allow moving
            if (start[i] != target[j]) return false;
            //e.g. "L_" cannot become "_L" as 'L' can only move left
            if (start[i] == 'L' && i < j || start[i] == 'R' && i > j) return false;

            i ++;
            j ++;
        }

        return true;
    }
}
