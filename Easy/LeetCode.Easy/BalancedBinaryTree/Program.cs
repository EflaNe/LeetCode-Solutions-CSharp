using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBinaryTree
{
    internal class Program
    {
        // 0110 - Balanced Binary Tree,
        //https://leetcode.com/problems/balanced-binary-tree/

        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {
            public bool IsBalanced(TreeNode root)
            {
                return ChechHeight(root) != -1;
            }

            private int ChechHeight(TreeNode node)
            {
                if (node == null)
                    return 0;

                int leftHeight = ChechHeight(node.left);
                if (leftHeight == -1)
                {
                    return -1;
                }

                int rightHeight = ChechHeight(node.right);
                if (rightHeight == -1)
                {
                    return -1;
                }

                if (Math.Abs(leftHeight - rightHeight) > 1)
                {
                    return -1;
                }

                return 1 + Math.Max(leftHeight, rightHeight);

            }
        }
    }
}
