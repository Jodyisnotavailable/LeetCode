public class Solution {
    public int MaxEqualRowsAfterFlips(int[][] matrix) {
        Dictionary<string, int> count = new Dictionary<string, int>();
        
        for (int row = 0; row < matrix.Length; row ++) {
            string curRow = string.Join("", matrix[row]);
            string invRow = "";
            //invert current row
            foreach (char chr in curRow) {
                if (chr == '0') {
                    invRow += "1";
                } else {
                    invRow += "0";
                }
            }

            if (count.ContainsKey(curRow)) {
                count[curRow] += 1;
            } else if (count.ContainsKey(invRow)) {
                count[invRow] += 1;
            } else {
                count.Add(curRow, 1);
            }
        }

        return count.Values.Max();
    }
}
