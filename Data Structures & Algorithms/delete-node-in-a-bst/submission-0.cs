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
    public TreeNode DeleteNode(TreeNode root, int key) {

        if(root == null) return root;

        if(key > root.val){
            root.right = DeleteNode(root.right, key);
        }
        else if(key < root.val){
            root.left = DeleteNode(root.left, key);
        }
        else{
            if(root.left == null){ return root.right;} //which can be null;
            if(root.right == null) {return root.left;}
         

            var cur = root.right;
            while(cur.left != null) //get the minimum node from the right subtree
            {
                cur = cur.left;
            } 
            root.val = cur.val;
            root.right = DeleteNode(root.right, cur.val);
        }

        return root;
        
    }
}