public class Solution {
    public int NumIslands(char[][] grid) {
        
        var numOfIslands = 0;
        
        for(var i = 0; i < grid.Length; i++){
           for (var j=0; j < grid[i].Length; j++){
               if(grid[i][j] == '1')
                    numOfIslands += DFS(grid, i ,j );
           }
    }
        return numOfIslands;
}
    public int DFS(char [][] grid, int i , int j){
        if(i < 0 || i >= grid.Length || j < 0 || j>= grid[i].Length || grid[i][j]=='0' )
            return 0;
        
        grid[i][j] = '0';
        
        DFS(grid, i+1, j);
        DFS(grid, i-1, j);
        DFS(grid, i, j+1);
        DFS(grid, i, j-1);
        
        return 1;
    }
}