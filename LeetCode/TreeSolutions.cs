using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeSolutions
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


        // Typical BFS 
        public IList<IList<int>> LevelorderTraversalBFS(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (root is null) return res;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                Queue<TreeNode> tempnode = new Queue<TreeNode>();
                IList<int> tempval = new List<int>();

                while (q.Count != 0)
                {
                    var node = q.Dequeue();
                    tempval.Add(node.val);
                    if (node.left != null) tempnode.Enqueue(node.left);
                    if (node.right != null) tempnode.Enqueue(node.right);
                }
                q = tempnode;
                res.Add(tempval);
            }
           
            return res;
        }

        // attributes
        public int MaxDepthRecur(TreeNode root)
        {
            if (root is null) return 0;

            return Math.Max(MaxDepthRecur(root.left), MaxDepthRecur(root.right)) + 1;

        }

        public int MaxDepthDFS(TreeNode root)
        {
            if (root is null) return 0;
            int res = 0;

            Stack<TreeNode> s = new Stack<TreeNode>();
            Stack<int> depth = new Stack<int>();
            s.Push(root);
            depth.Push(0);

            while (s.Count != 0)
            {
                var node = s.Pop();
                var currdepth = depth.Pop();

                res = Math.Max(res, currdepth);
                if (node.right != null)
                {
                    s.Push(node.right);
                    depth.Push(currdepth + 1);
                }

                if (node.left != null)
                {
                    s.Push(node.left);
                    depth.Push(currdepth + 1);
                }

            }

            return res;
        }


        public int MaxDepthBFS(TreeNode root)
        {
            if (root is null) return 0;
            int depth = 1;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                Queue<TreeNode> temp = new Queue<TreeNode>();
                while (q.Count != 0)
                {
                    var node = q.Dequeue();
                    if (node.left != null) temp.Enqueue(node.left);
                    if (node.right != null) temp.Enqueue(node.right);
                }
                depth++;
                q = temp;
            }

            return depth;
        }


        // The struct of the tree
        
        public bool IsSymmetricRecurr(TreeNode root)
        {

            if (root.left == null && root.right == null) return true;

            return Helper(root.left, root.right);

        }

        private bool Helper(TreeNode left, TreeNode right)
        {
            if (left is null && right is null) return true;

            if (left is null || right is null) return false;

            //if (left.val != right.val) return false;

            //return helper(left.left, right.right) && helper(left.right, right.left);

            if (left.val == right.val)
            {
                return Helper(left.left, right.right) && Helper(left.right, right.left);
            }
            else
            {
                return false;
            }
        }

        ////BFS + two pointers
        //public bool IsSymmetricBFS(TreeNode root)
        //{

        //}

        ////DFS
        //public bool IsSymmetricDFS(TreeNode root)
        //{

        //}


        public TreeNode InvertTree(TreeNode root)
        {
            if (root is null) return null;

            TreeNode left = InvertTree(root.left);
            TreeNode right = InvertTree(root.right);

            root.left = right;
            root.right = left;
            return root;

        }

        // Tree Sum (from root to leaf and from A node to B node)
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root is null) return false;

            if (root.left == null && root.right == null && root.val == targetSum) return true;

            else return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
        }

        //public bool HasPathSumDFS(TreeNode root, int targetSum)
        //{
        //    if (root is null) return false;

            
        //}

        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root is null) return null;

            if (root.val == val) return root;

            if (val > root.val) return SearchBST(root.right, val);

            if (val < root.val) return SearchBST(root.left, val);
            // this is only for satisfying the return type requirement, python has no such things
            return new TreeNode();
        }

        public TreeNode InsertIntoBSTRecur(TreeNode root, int val)
        {
 
            // base
            if (root is null) return new TreeNode(val);

            // operation
            if (root.val < val) root.right = InsertIntoBSTRecur(root.right, val);
      
            else root.left = InsertIntoBSTRecur(root.left, val);
      
            return root;
        }

        //public TreeNode InsertIntoBSTDFS(TreeNode root, int val)
        //{

        //}


        public bool IsValidBST(TreeNode root)
        {
            return Helper(root, long.MinValue, long.MaxValue);
        }

        private bool Helper(TreeNode root, long low, long high)
        {
            if (root is null) return true;

            if (root.left is null && root.right is null) return true;

            if(root.val < high && root.val > low) return Helper(root.left, low, root.val) && Helper(root.right, root.val, high);
            return false;

        }

        // 653. Two Sum IV - Input is a BST
        // I want to use Recursive way to do this.
        public bool FindTarget(TreeNode root, int k)
        {
            return DFS(root, root, k);
        }

        private bool DFS(TreeNode root, TreeNode curr, int k)
        {
            if (curr is null) return false;
            return SearchTarget(root, curr, k - curr.val) || DFS(root, curr.left, k) || DFS(root, curr.right, k);
        }

        private bool SearchTarget(TreeNode root, TreeNode curr, int val)
        {
            if (root is null) return false;
            return val == root.val && root != curr || val > root.val && SearchTarget(root.right, curr, val) || val < root.val && SearchTarget(root.left, curr, val);
        }

        // 235. Lowest Common Ancestor of a Binary Search Tree

        public TreeNode LowestCommonAncestorBST(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root is null) return null;

            if (root.val > p.val && root.val > q.val) return LowestCommonAncestor(root.left, p, q);
            if (root.val < p.val && root.val < q.val) return LowestCommonAncestor(root.right, p, q);
            else return root;

        }

        // 236. Lowest Common Ancestor of a Binary Tree

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root is null) return null;

            if (root == p) return p;
            if (root == q) return q;

            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null) return root;
            if (left != null && right == null) return left;
            if (left == null && right != null) return right;
            else return null;
        }

    }
}
