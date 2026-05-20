public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
       
        int l = 0, r = numbers.Length - 1;

        while (l < r) {
            int curSum = numbers[l] + numbers[r];

            if (curSum > target) {
                r--;
            } else if (curSum < target) {
                l++;
            } else {
                return new int[]{l + 1, r + 1};
            }
        }
        
        return new int[0];
       
       /* Dictionary<int,int> indices = new Dictionary<int,int>();

        int diff = 0;

        for(int i = 0; i < numbers.Length; i++){
            diff = target - numbers[i];
            if(indices.ContainsKey(diff))
            {
                return new int [] {++indices[diff], ++i};
            }
            indices.Add(numbers[i], i);
        }
        return null; */
    }
}
