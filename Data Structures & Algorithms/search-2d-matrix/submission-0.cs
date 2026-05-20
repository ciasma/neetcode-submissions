public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var rowCount = matrix.Length -1;
        //Console.WriteLine($"rowcount is: {rowCount}");
        var colCount = matrix[0].Length - 1;
        //Console.WriteLine($"colCount is: {colCount}");
        int? selectedRow = null;
        for(int i = 0; i <= rowCount; i++){
            //Console.WriteLine($"i is {i}");
            //Console.WriteLine($"matrix[i][colCount] is {matrix[i][colCount]}");
            if(matrix[i][colCount] == target) return true;
            if(target < matrix[i][colCount]) {
                selectedRow = i;
                break;
            }
            
        }
        if(!selectedRow.HasValue) return false;

        //Console.WriteLine($"Selected row is {selectedRow}");

        int l=0, r = colCount, mid = 0;

        while(l<=r){
            mid = (l+r)/2;
            if(target ==  matrix[selectedRow.Value][mid]) return true;
            if (target > matrix[selectedRow.Value][mid]){
                l = mid + 1;
            }
            else{
                r = mid -1;
            }
            
        }
        return false;        
    }
}
