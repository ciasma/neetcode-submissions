public class Solution {
    public int Search(int[] nums, int target) {

         int l = 0, r = nums.Length -1;
       while (l <= r){
        var middle = (l+r)/2;
        Console.WriteLine($"middle is: {middle}");
        if(nums[middle] == target){
            return middle;
        }
        if( target > nums[middle]){
            l = middle + 1;
            
        }else{
            r = middle -1;
        }

       }
       return -1;


        
    }
}
