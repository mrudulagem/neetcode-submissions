public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var result = new List<int[]>();
        int i = 0, n = intervals.Length;

        while(i < n && intervals[i][1] < newInterval[0]) {
            result.Add(intervals[i++]);
        }

        while(i < n && intervals[i][0] <= newInterval[1]) {
            newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
            newInterval[1] = Math.Max(intervals[i++][1], newInterval[1]);
        }
        result.Add(newInterval);

        while(i < n) {
            result.Add(intervals[i++]);
        }

        return result.ToArray();
    }
}
