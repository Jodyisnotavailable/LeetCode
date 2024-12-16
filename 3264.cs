public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        //index, (value and index)
        PriorityQueue<int, (int, int)> heap = new PriorityQueue<int, (int, int)>(Comparer<(int, int)>.Create((a, b) => {
            if(a.Item1 == b.Item1) {
                return a.Item2.CompareTo(b.Item2);
            }else {
                return a.Item1.CompareTo(b.Item1);
            }
        }));
        for (int i = 0; i < nums.Length; i ++) {
            heap.Enqueue(i, (nums[i], i));
        }

        for (int j = 0; j < k; j ++) {
            int minIndex = heap.Dequeue();
            nums[minIndex] = nums[minIndex]*multiplier;
            heap.Enqueue(minIndex, (nums[minIndex], minIndex));
        }
        
        return nums;
    }
}
