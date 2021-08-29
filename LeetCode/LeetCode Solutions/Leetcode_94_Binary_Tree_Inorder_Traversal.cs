using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Leetcode_94_Binary_Tree_Inorder_Traversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {

            var res = new List<int>();
            if (root == null) return res;

            res.Add(root.val);
            return InorderTraversal(root.left).Concat(res).Concat(InorderTraversal(root.right)).ToList();
        }
    }
}
