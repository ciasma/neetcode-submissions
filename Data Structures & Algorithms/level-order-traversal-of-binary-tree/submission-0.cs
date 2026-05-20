/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {

        
        var que = new Queue<TreeNode>();
        List<List<int>> res = new List<List<int>>();
        if(root == null) return res;
        que.Enqueue(root);
        
       
        while (que.Count > 0)
        {
            int levelSize = que.Count;
            List<int> currentLevelList = new List<int>();
            for (int i = 0; i < levelSize; i++)
            {
                var curr = que.Dequeue();
               
                currentLevelList.Add(curr.val);
                if (curr.left != null)
                {
                    
                    que.Enqueue(curr.left);
                }
                if (curr.right != null)
                {
                    
                    que.Enqueue(curr.right);
                }
            }  
            res.Add(currentLevelList);
        }
        return res;
 
    }
}
