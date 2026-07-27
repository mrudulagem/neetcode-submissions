public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)) {
            return 0;
        }
        int start = 0, end = 0, local_max = 0, global_max = 0;
        var set = new HashSet<char>();
        while(start <= end && end < s.Length) {
            while(end < s.Length && !set.Contains(s[end])) {
                set.Add(s[end++]);
            }
            local_max = end - start;
            global_max = Math.Max(local_max, global_max);
            set.Remove(s[start++]);
        }
        return global_max;
    }
}
