public class Solution {
    public int MaxSubArray(int[] nums) { //Kadane's Algorithm O(n)
        var maxSum = nums[0];
        var curSum = 0;

        foreach (int n in nums){
            curSum = Math.Max(curSum, 0);
            curSum += n;
            maxSum = Math.Max(maxSum, curSum);
        }
        return maxSum;
    }
}
