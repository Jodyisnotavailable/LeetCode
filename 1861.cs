public class Solution {
    public char[][] RotateTheBox(char[][] box) {
        int m = box.Length;
        int n = box[0].Length;
        char[][] res = new char[n][];
        for (int i = 0; i < res.Length; i ++) {
            res[i] = new char[m];
        }

        for (int i = 0; i < box.Length; i++) {
            for (int j = 0; j < box[i].Length; j ++) {
                //e.g. box[1][3] => res[3][0]; [i][j] => [j][m-1-i]
                res[j][Math.Abs(m-1-i)] = box[i][j];
            }
        }
        
        //start from bottom of the first column
        for (int j = 0; j < m; j ++) {
            int lowestEmpty = n-1; //lowest empty cell
            for (int i = n-1; i >= 0; i --) {
                //if cell has obstacle, move above it
                if (res[i][j] == '*') lowestEmpty = i-1;
                //if cell has rock, switch with lowest empty cell
                if (res[i][j] == '#') {
                    //the switch has to happen in this order
                    //if the empty cell is applied after the stone then cell that already has stone will lose the stone bc it is switching with itself
                    res[i][j] = '.';
                    res[lowestEmpty][j] = '#';
                    lowestEmpty --;
                }
            }
        }
        
        return res;
    }
}
