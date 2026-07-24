public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequencies = new Dictionary<int, int>();
        foreach(var num in nums) {
            frequencies[num] = frequencies.GetValueOrDefault(num, 0) + 1;
        }

        var topK = new PriorityQueue<int, int>();
        int count = 0;
        foreach(var (num, frequency) in frequencies) {
            if(count >= k) {
                var minElement = topK.Peek();
                var minFrequency = frequencies[minElement];
                if(minFrequency < frequency) {
                    topK.Dequeue();
                    topK.Enqueue(num, frequency);
                }
            } else {
                topK.Enqueue(num, frequency);
                count++;
            }
        }

        var result = new int[k];
        for(int i = 0; i < k; i++) {
            result[i] = topK.Dequeue();
        }

        return result;
    }
}
