public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        List<List<int>> result = new List<List<int>>();
        int j,k, target, currentSum;
        Array.Sort(nums);
        for (int i=0; i < nums.Length; i++){
            if(i > 0 && nums[i] == nums[i-1]){
                continue;
            }
            j = i+1;
            k = nums.Length - 1;

            while(j < k){
                target = nums[i] * -1;
                currentSum = nums[j] + nums[k];
                if(currentSum > target){
                    k--;
                }
                else if(currentSum < target){
                    j++;
                }
                else {
                    result.Add(new List<int> {nums[i], nums[j],nums[k]}); 
                    k--;
                    j++;   
                    while (j < k  && nums[j] == nums[j -1]) {
                        j++;
                    }
                }                             
                
            }            
        }
        return result;        
    }
}
