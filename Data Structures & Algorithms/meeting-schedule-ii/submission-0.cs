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
        int[] starts = new int[intervals.Count];
        int[] ends = new int[intervals.Count];
        int i = 0, j = 0, rooms = 0, max = 0;
        foreach(var interval in intervals) {
            starts[i] = interval.start;
            ends[i++] = interval.end;
        }
        i = 0;
        Array.Sort(starts);
        Array.Sort(ends);
        
        while(i < intervals.Count && j < intervals.Count) {
            if(starts[i] < ends[j]) {
                i++;
                rooms++;
            } else {
                // (starts[i] >= ends[j])
                j++;
                rooms--;
            }
            max = Math.Max(max, rooms);
        }
        return max;
    }
}
