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
    public int KthSmallest(TreeNode root, int k) {

        List<int> res = new List<int>();
        res = InOrderTraversal(root,  res);
         
        return res[k-1];
        
    }

      private List<int> InOrderTraversal(TreeNode root, List<int> res) {

        if(root == null) return res;

        InOrderTraversal(root.left, res);
        res.Add(root.val);
        InOrderTraversal(root.right, res);

        return res;        
    }
     
}
