public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> window = new HashSet<int>();
        int L = 0;

        for (int R = 0; R < nums.Length; R++) {
            if (R - L > k) {
                window.Remove(nums[L]);
                L++;
            }
            if (window.Contains(nums[R])) {
                return true;
            }
            window.Add(nums[R]);
        }

        return false;
    }
}