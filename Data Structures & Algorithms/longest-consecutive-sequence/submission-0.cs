public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>();
        foreach(var num in nums) {
            set.Add(num);
        }

        int global = 0;
        foreach(var num in set) {
            if(set.Contains(num - 1)) {
                continue;
            }

            var current = num;
            var local = 0;
            while(set.Contains(current)) {
                current++;
                local++;
            }
            global = Math.Max(global, local);
        }

        return global;
    }
}
