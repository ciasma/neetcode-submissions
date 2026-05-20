public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {

        var MaxArea = 0;
        for(int r = 0; r < grid.Length; r++){
            for(int c = 0; c < grid[0].Length; c++)
            {
                if(grid[r][c]==1){
                    MaxArea= Math.Max(DFS(grid, r, c), MaxArea);
                }
            }
        }
        return MaxArea;
        
    }

    public int DFS(int[][]grid, int r, int c){
        if(r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length ||
        grid[r][c] == 0) return 0;

        grid[r][c] = 0;
        var area = 1;

        area += DFS(grid, r-1, c);
        area += DFS(grid, r+1, c);
        area += DFS(grid, r, c-1);
        area += DFS(grid, r, c+1);

        return area;
    }
}
