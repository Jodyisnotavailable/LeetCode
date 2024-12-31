public class Solution {
    public int LastStoneWeight(int[] stones) {
        //max heap
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        for (int i = 0; i < stones.Length; i ++) {
            heap.Enqueue(stones[i], stones[i]);
        }

        while (heap.Count > 1) {
            int max1 = heap.Dequeue();
            int max2 = heap.Dequeue();
            heap.Enqueue(max1-max2, max1-max2);
        }
        
        return heap.Peek();
    }
}
