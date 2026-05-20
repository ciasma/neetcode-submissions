public class Solution {
    public int MaxArea(int[] heights) {

        int l = 0, r = heights.Length - 1;

        int res = 0;

        while(l < r){
            int area = (r - l) * Math.Min(heights[l],heights[r]);
            res = Math.Max(area, res);
            if(heights[l] < heights[r]){
                l++;
                
            }
            else{
                r--;
            }
        }
        return res;
        
    }
}
