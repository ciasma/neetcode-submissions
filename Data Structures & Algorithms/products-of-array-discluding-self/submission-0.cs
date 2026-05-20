public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        int pos = 0;
        int [] output = new int[nums.Length];

        while(pos < nums.Length){
            for(int i=nums.Length -1; i>= 0; i--){
                if(i != pos)
                {
                    product *= nums[i];
                }

                if(i == pos && pos > 0){
                    continue;
                }
            }
            output[pos] = product;
            product = 1;
            pos++;
        }
        return output;
        
    }
 
}
