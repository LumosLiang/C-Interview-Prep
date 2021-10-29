using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode next;

        public TreeNode() { }

        public TreeNode(int _val)
        {
            val = _val;
        }
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }


        public TreeNode(int _val, TreeNode _left, TreeNode _right, TreeNode _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }

    }
}
