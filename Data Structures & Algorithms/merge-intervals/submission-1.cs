public class Solution {
    public int[][] Merge(int[][] intervals) {
        if(intervals.Length < 2) {
            return intervals;
        }

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var result = new List<int[]>();

        var prev = intervals[0];
        for(int i = 1; i < intervals.Length; i++) {
            var curr = intervals[i];
            if(curr[0] <= prev[1]) {
                prev[1] = Math.Max(curr[1], prev[1]);
            } else {
                result.Add(prev);
                prev = curr;
            }
        }
        result.Add(prev);

        return result.ToArray();
    }
}
