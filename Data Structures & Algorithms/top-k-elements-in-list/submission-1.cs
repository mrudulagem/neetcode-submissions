public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequencies = new Dictionary<int,int>();
        foreach(var num in nums) {
            frequencies[num] = frequencies.GetValueOrDefault(num, 0) + 1;
        }

        var topK = new PriorityQueue<int, int>();

        foreach(var (num, frequency) in frequencies) {
            topK.Enqueue(num, frequency);
            if(topK.Count > k) {
                topK.Dequeue();
            }
        }

        var result = new int[k];
        for(int i = 0; i < k; i++) {
            result[i] = topK.Dequeue();
        }

        return result;
    }
}
