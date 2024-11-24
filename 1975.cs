public class Solution {
    public long MaxMatrixSum(int[][] matrix) {
        int biggestNeg = int.MinValue; //prioritize flipping smaller negative number
        int smallestPos = int.MaxValue;
        int negCount = 0;
        long absSum = 0;

        for (int i = 0; i < matrix.Length; i ++) {
            for (int j = 0; j < matrix[i].Length; j ++) {
                if (matrix[i][j] < 0) {
                    negCount += 1;
                    biggestNeg = Math.Max(biggestNeg, matrix[i][j]);
                } else {
                    smallestPos = Math.Min(smallestPos, matrix[i][j]);
                }
                absSum += Math.Abs(matrix[i][j]);
            }
        }

        //turn every pair of negative numbers into positive
        if (negCount % 2 == 0) return absSum;

        //only flip the remaining negative number if there is a positive number to be considered
        //if the cost of flipping is greater than keeping the original neg number, dont
        if ((smallestPos == int.MaxValue) || (smallestPos * -1 < biggestNeg)) {
            return absSum - Math.Abs(biggestNeg)*2;
        } else {
            return absSum - smallestPos*2;
        }
    }
}
