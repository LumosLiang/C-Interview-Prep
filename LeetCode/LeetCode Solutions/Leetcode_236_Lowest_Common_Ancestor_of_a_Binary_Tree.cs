
namespace LeetCode
{
    public class Leetcode_236_Lowest_Common_Ancestor_of_a_Binary_Tree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {

            if (root == p || root == q || root == null) return root;

            TreeNode left = LowestCommonAncestor(root.left, p, q);
            TreeNode right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null) return root;

            if (left != null) return left;
            else return right;

        }
    }
}
