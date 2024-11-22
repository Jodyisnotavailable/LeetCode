public class Solution {
    public int MaxEqualRowsAfterFlips(int[][] matrix) {
        Dictionary<string, int> count = new Dictionary<string, int>();
        
        for (int row = 0; row < matrix.Length; row ++) {
            string curRow = string.Join("", matrix[row]);
            string invRow = "";
            //invert the row
            foreach (char chr in curRow) {
                if (chr == '0') {
                    invRow += "1";
                } else {
                    invRow += "0";
                }
            }
            if (!count.ContainsKey(curRow) && !count.ContainsKey(invRow)) {
                count.Add(curRow, 1);
            } else {
                try{
                    count[curRow] += 1;
                }
                catch (Exception e) {
                    count[invRow] += 1;
                }
                    
            }
        }

        return count.Values.Max();
    }
}
