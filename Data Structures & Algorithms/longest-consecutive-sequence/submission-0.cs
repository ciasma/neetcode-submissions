public class Solution {
    public int LongestConsecutive(int[] nums) {

         var set = new HashSet<int>(nums);
            var longest = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                if (!set.Contains(nums[i] - 1))  //if there is no number less than nums[i]  in the set, it might be the start of a sequence
                {
                    int length = 1;
                    while (set.Contains(nums[i] + length))
                    {
                        length++;
                    }
                    longest = Math.Max(length, longest);
                }
            }
            return longest;
        
    }
}
