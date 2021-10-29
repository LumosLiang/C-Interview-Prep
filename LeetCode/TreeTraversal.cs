using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeTraversal
    {

        // root - left - right
        public IList<int> PreorderTraversalDFS(TreeNode root)
        {
            List<int> res = new List<int>();
            if (root is null) return res;

            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);

            while (s.Count != 0)
            {
                var temp = s.Pop();
                if (temp != null)
                {
                    res.Add(temp.val);
                    s.Push(temp.right);
                    s.Push(temp.left);
                }
            }
            return res;
        }

        public IList<int> PreorderTraversalDFS2(TreeNode root)
        {
            List<int> res = new List<int>();
            DFSPreorder(root, res);
            return res;
        }

        private void DFSPreorder(TreeNode root, List<int> list)
        {
            if (root is null) return;

            list.Add(root.val);
            DFSPreorder(root.left, list);
            DFSPreorder(root.right, list);
        }


        public IList<int> PreorderTraversalRecur(TreeNode root)
        {

            List<int> res = new List<int>();
            if (root is null) return res;

            res.Add(root.val);
            res.AddRange(PreorderTraversalRecur(root.left));
            res.AddRange(PreorderTraversalRecur(root.right));

            return res;
        }

        // left root right
        public IList<int> InorderTraversalDFS(TreeNode root)
        {
            var res = new List<int>();
            if (root is null) return res;

            Stack<TreeNode> s = new Stack<TreeNode>();

            while (s.Count != 0 || root != null)
            {
                if (root != null)
                {
                    s.Push(root);
                    root = root.left;
                }
                else
                {
                    var temp = s.Pop();
                    res.Add(temp.val);
                    root = temp.right;
                }
            }
            return res;
        }

        public IList<int> InorderTraversalDFS2(TreeNode root)
        {
            var res = new List<int>();
            DFSInorder(root, res);

            return res;
        }

        private void DFSInorder(TreeNode root, List<int> res)
        {
            if (root is null) return;
            DFSInorder(root.left, res);
            res.Add(root.val);
            DFSInorder(root.right, res);
        }

        public IList<int> InorderTraversalRecur(TreeNode root)
        {
            var res = new List<int>();
            if (root is null) return res;

            res.AddRange(InorderTraversalRecur(root.left));
            res.Add(root.val);
            res.AddRange(InorderTraversalRecur(root.right));

            return res;
        }

        // left right root
        // reverse preorder(root. right left)
        public IList<int> PostorderTraversalDFS(TreeNode root)
        {
            var res = new List<int>();
            if (root is null) return res;

            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode last = null;

            while (s.Count != 0 || root != null)
            {
                if (root != null)
                {
                    s.Push(root);
                    root = root.left;
                }
                else
                {
                    var temp = s.Peek();
                    if (temp.right != null && temp.right != last)
                    {
                        root = temp.right;
                    }
                    else
                    {
                        res.Add(temp.val);
                        last = temp;
                        s.Pop();
                    }
                }
            }
            return res;

        }

        public IList<int> PostorderTraversalDFS2(TreeNode root)
        {
            var res = new List<int>();
            DFSPostorder(root, res);
            return res;
        }

        private void DFSPostorder(TreeNode root, List<int> res)
        {
            if (root is null) return;
            DFSPostorder(root.left, res);
            DFSPostorder(root.right, res);
            res.Add(root.val);
        }

        public IList<int> PostorderTraversalRecur(TreeNode root)
        {
            var res = new List<int>();
            if (root is null) return res;

            res.AddRange(InorderTraversalRecur(root.left));
            res.AddRange(InorderTraversalRecur(root.right));
            res.Add(root.val);
            return res;
        }

        //public IList<int> LevelorderTraversalBFS(TreeNode root)
        //{

        //}


    }
}
