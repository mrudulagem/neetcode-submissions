public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        var postfix = new int[nums.Length];
        var result = new int[nums.Length];
        prefix[0] = 1;
        postfix[nums.Length - 1] = 1;
        for(int i = 1; i < nums.Length; i++) {
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }
        for(int i = nums.Length - 2; i >= 0; i--) {
            postfix[i] = postfix[i + 1] * nums[i + 1];
        }

        for(int i = 0; i < nums.Length; i++) {
            result[i] = prefix[i] * postfix[i];
        }

        return result;
    }
}
