public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        Array.Sort(nums);
        for(int i = 0; i < nums.Length; i++) {
            if(i > 0 && nums[i] == nums[i - 1]) {
                // Repeated number
                continue;
            }
            var target = 0 - nums[i];
            int j = i + 1, k = nums.Length - 1;
            while(j < k) {
                var currSum = nums[j] + nums[k];
                if(currSum < target) {
                    j++;
                } else if(currSum > target) {
                    k--;
                } else {
                    var inner = new List<int>() {nums[i], nums[j], nums[k]};
                    result.Add(inner);
                    j++;
                    k--;

                    while(j < k && nums[j] == nums[j - 1]) {
                        j++;
                    }
                    while(j < k && nums[k] == nums[k + 1]) {
                        k--;
                    }
                }
            }
        }
        return result;
    }
}
