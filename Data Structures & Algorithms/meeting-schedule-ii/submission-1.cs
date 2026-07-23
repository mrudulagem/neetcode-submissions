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
    public int MinMeetingRooms(List<Interval> intervals) {
        var starts = new int[intervals.Count];
        var ends = new int[intervals.Count];
        
        for(int i = 0; i < intervals.Count; i++) {
            starts[i] = intervals[i].start;
            ends[i] = intervals[i].end;
        }

        Array.Sort(starts);
        Array.Sort(ends);

        int active_meetings = 0, max = 0, start_index = 0, end_index = 0;
        while(start_index < intervals.Count && end_index < intervals.Count) {
            if(starts[start_index] < ends[end_index]) {
                start_index++;
                active_meetings++;
            } else {
                end_index++;
                active_meetings--;
            }
            max = Math.Max(max, active_meetings);
        }
        return max;
    }
}
