

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Leetcode_116_Populating_Next_Right_Pointers_in_Each_Node
    {
        // DFS
        public TreeNode Connect(TreeNode root)
        {
            // Base
            if (root == null || root.left == null) return root;
            
            root.left.next = root.right;
            if (root.next != null) root.right.next = root.next.left;
            else root.right.next = null;
            root.left = Connect(root.left);
            root.right = Connect(root.right);

            return root;
        }

    }


}
