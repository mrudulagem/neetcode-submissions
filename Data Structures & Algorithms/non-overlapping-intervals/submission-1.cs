public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        if(intervals.Length < 2) {
            return 0;
        }

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        int overlap = 0;
        var prev = intervals[0];
        for(int i = 1; i < intervals.Length; i++) {
            var curr = intervals[i];
            if(curr[0] < prev[1]) {
                overlap++;
                // Keep the one which has lower end
                // Meaning remove the one which has higher end
                prev[1] = Math.Min(prev[1], curr[1]);
            } else {
                // curr[0] >= prev[1];
                prev[1] = curr[1];
            }
        }

        return overlap;
    }
}
