public class Solution {
    public int FindLengthOfShortestSubarray(int[] arr) {
        int lPt = 0;
        int rPt = arr.Length-1;

        //remove prefix
        while (rPt > 0 && arr[rPt] >= arr[rPt-1]) {
            rPt -=1;
        }
        int res = rPt;

        //suffix or middle
        while (rPt > lPt) {
            while (rPt < arr.Length && rPt > lPt+1 && arr[rPt] >= arr[rPt-1] && arr[rPt] >= arr[lPt]) {
                rPt -= 1;
            }
            //make sure prefix < suffix
            while (rPt < arr.Length && arr[lPt] > arr[rPt]) {
                rPt += 1;
            }
            res = Math.Min(res, rPt-lPt-1);
            if (arr[lPt] > arr[lPt+1]) break;
            lPt += 1;
        }

        return res;
    }
}
