using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(20);
            root.left = new TreeNode(15);
            root.right = new TreeNode(22);

            Solution result = new Solution();
            TreeNode res = result.InvertTree(root);

            Console.WriteLine(res.left.val);
            Console.ReadLine();


        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            TreeNode mid;
            if (root != null)
            {
               mid = root.left ;
               root.left = root.right;
               root.right = mid;
               InvertTree(root.left);
               InvertTree(root.right);
    
            }
            return root;
           

        }
    }
}
