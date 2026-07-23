public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {

        int count = 0, total = 0, j = 0;
        for(var i = 0; i < arr.Length; i ++){
            while(j-i < k  && (i + k <= arr.Length)){
                total += arr[j];
                
                j++;
            }

            if(total/k >= threshold)
            {
                count++;
                 
            }
            j = i + 1;
            total = 0;
        }
        return count;
        
    }
}