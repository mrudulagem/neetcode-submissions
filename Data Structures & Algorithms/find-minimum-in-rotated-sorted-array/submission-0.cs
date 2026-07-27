public class Solution {
    public int FindMin(int[] nums) {
        int min = int.MaxValue;
        int l = 0, r = nums.Length - 1;
        while(l <= r) {
            if(nums[l] < nums[r] && min >= nums[l]) {
                return nums[l];
            }
            int mid = (l + r) / 2;
            min = Math.Min(min, nums[mid]);
            if(nums[l] <= nums[mid]) {
                l = mid + 1;
            } else if(nums[mid] <= nums[r]) {
                r  = mid - 1;
            }
        }

        return min;
    }
}
