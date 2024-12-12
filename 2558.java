class Solution {
    public long pickGifts(int[] gifts, int k) {
        PriorityQueue<Integer> maxHeap= new PriorityQueue<Integer>(Comparator.reverseOrder());
        for (int i = 0; i < gifts.length; i ++) {
            maxHeap.add(gifts[i]);
        }
        //add square root of max pile then remove the max pile from heap
        for (int j = 0; j < k; j ++) {
            maxHeap.add((int)Math.sqrt(maxHeap.peek()));
            maxHeap.poll();
        }

        long res = 0;
        while (!maxHeap.isEmpty()) {
            res+= maxHeap.poll();
        }
        return res;



        //brute force
        /*
        for (int i = 0; i < k; i ++) {
            Arrays.sort(gifts);
            gifts[gifts.length-1] = (int)Math.sqrt(gifts[gifts.length-1]);
        }

        return (long)IntStream.of(gifts).sum();
        */
    }
}
