public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int,int> indices = new Dictionary<int,int>();

        int diff = 0;

        for(int i = 0; i < numbers.Length; i++){
            diff = target - numbers[i];
            if(indices.ContainsKey(diff))
            {
                return new int [] {++indices[diff], ++i};
            }
            indices.Add(numbers[i], i);
        }
        return null;
    }
}
