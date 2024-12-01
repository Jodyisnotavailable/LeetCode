public class Solution {
    public bool CheckIfExist(int[] arr) {
        List<int> nums = new List<int>();

        for (int i = 0; i < arr.Length; i ++) {
            int targetNum1 = 2*arr[i];
            if (nums.Contains(targetNum1)) return true;
            if (arr[i]%2 == 0) {
                int targetNum2 = arr[i]/2;
                if (nums.Contains(targetNum2)) return true;
            }
            
            nums.Add(arr[i]);
        }

        return false;
    }
}
