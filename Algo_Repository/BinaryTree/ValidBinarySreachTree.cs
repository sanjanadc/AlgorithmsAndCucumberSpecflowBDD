using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.BinaryTree
{
    public  class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal static  class ValidBinarySreachTree
    {
        public static bool IsValidBST(TreeNode root)
        {

            return BST(root, long.MinValue, long.MaxValue);
        }

        public static bool BST(TreeNode root, long min, long max)
        {
            if (root == null) return true;

            if (root.val <= min || root.val >= max) return false;

            return BST(root.left, min, root.val) && BST(root.right, root.val, max);
        }

        //public static void Main()
        //{
        //    TreeNode root = new TreeNode(2);
            
        //    root.left = new TreeNode(1);
        //    root.right = new TreeNode(3);

        //    IsValidBST(root);
        //}
    }

    

}
