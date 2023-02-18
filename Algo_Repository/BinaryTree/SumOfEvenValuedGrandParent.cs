using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.BinaryTree
{
    internal static class SumOfEvenValuedGrandParent
    {
        public static int SumEvenGrandparent(TreeNode root)
        {

            if (root == null)
                return 0;

            int sum = 0;
            DFS(root, null, null, ref sum);
            return sum;
        }

        private static void DFS(TreeNode node, TreeNode parent, TreeNode grandParent, ref int sum)
        {
            if (node == null)
                return;

            if (grandParent != null && grandParent.val % 2 == 0)
                sum += node.val;

            DFS(node.left, node, parent, ref sum);
            DFS(node.right, node, parent, ref sum);
        }

        //public static void Main()
        //{
        //    TreeNode root = new TreeNode(6);

        //    root.left = new TreeNode(7);
        //    root.right = new TreeNode(8);
        //    root.left.left = new TreeNode(2);
        //    root.left.right = new TreeNode(7);
        //    root.left.left.left = new TreeNode(9);
        //    root.right.left = new TreeNode(1);
        //    root.right.right = new TreeNode(3);
        //    root.right.right.right  = new TreeNode(5);
        //    root.left.right.left = new TreeNode(1);
        //    root.left.right.right = new TreeNode(4);

        //    SumEvenGrandparent(root);
        //}
    }
}
