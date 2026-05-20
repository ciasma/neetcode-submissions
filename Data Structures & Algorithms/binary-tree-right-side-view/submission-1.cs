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
    public List<int> RightSideView(TreeNode root) {

        
        if(root == null) return new List<int>();

        List<int> result = new List<int>();
        Queue<TreeNode> que = new Queue<TreeNode>();

        que.Enqueue(root);
        
        while(que.Count > 0){

            TreeNode rightSide = null;
            var qLength = que.Count;

            for(int i= 0; i < qLength; i++ ){        
        
                var curr = que.Dequeue();
                if(curr != null){
                    rightSide = curr;
                    que.Enqueue(curr.left);
                    que.Enqueue(curr.right);
            
                }
            }
            if(rightSide != null) result.Add(rightSide.val);

        }
        return result;
        
    }
}
