public class Solution {
    public int MaxArea(int[] heights) {
        int i = 0, j = heights.Length - 1;
        int max = 0;
        while(i < j) {
            var min = Math.Min(heights[i], heights[j]);
            var local = min * (j - i);
            max = Math.Max(max, local);
            if(min == heights[i]) {
                i++;
            } else {
                j--;
            }
        }

        return max;
    }
}
