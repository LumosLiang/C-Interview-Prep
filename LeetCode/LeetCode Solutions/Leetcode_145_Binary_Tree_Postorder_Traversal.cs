using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{

    public class Leetcode_145_Binary_Tree_Postorder_Traversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var res = new List<int>();
            if (root == null)
            {
                return res;
            }
            res.Add(root.val);
            return PostorderTraversal(root.left).Concat(PostorderTraversal(root.right)).Concat(res).ToList();

        }
    }
}