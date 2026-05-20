public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int,int> indices = new Dictionary <int,int>();

        int diff = 0;

        for (int i=0; i <nums.Length; i++){
            diff = target - nums[i];
            if(indices.ContainsKey(diff))
            {
                return new int[] {indices[diff], i};
            }
            else
            {
                indices[nums[i]] = i;
            }
        }
        return null;

    }
}
