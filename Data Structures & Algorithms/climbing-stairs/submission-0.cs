public class Solution {
    private static Dictionary<int, int> memo = new Dictionary<int, int>();
    public int ClimbStairs(int i) {     
        if (i <= 2) return i; //base case


        if (!memo.ContainsKey(i))
        {
            memo.Add(i, ClimbStairs(i - 1) + ClimbStairs(i - 2));
        }

        return memo[i];
        
    }
}
