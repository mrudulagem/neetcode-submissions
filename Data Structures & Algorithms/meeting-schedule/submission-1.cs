/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        int n = intervals.Count;
        if(n <= 1) {
            return true;
        }

        intervals.Sort((a,b) => a.start.CompareTo(b.start));
        var int_1 = intervals[0];
        for(int i = 1; i < n; i++) {
            var int_2 = intervals[i];
            if(int_2.start < int_1.end) {
                return false;
            } else {
                int_1 = int_2;
            }
        }

        return true;
    }
}
