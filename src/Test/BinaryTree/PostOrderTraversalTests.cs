using BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BinaryTree
{
    public class PostOrderTraversalTests
    {
        [Fact]
        public void TempTest()
        {
            var n1 = new Node<string>("I");
            var n2 = new Node<string>("N");
            var n3 = new Node<string>("S");
            var n4 = new Node<string>("C");
            var n5 = new Node<string>("R");
            var n6 = new Node<string>("E");
            var n7 = new Node<string>("V");
            var n8 = new Node<string>("A");
            var n9 = new Node<string>("-");
            var n10 = new Node<string>("5");
            var n11 = new Node<string>("3");

            n11.Left = n6;
            n11.Right = n10;

            n6.Left = n1;
            n6.Right = n5;

            n5.Left = n2;
            n5.Right = n4;

            n4.Right = n3;

            n10.Left = n8;
            n10.Right = n9;

            n8.Right = n7;

            var tree = new BaseBinaryTree<string>();
            tree._root = n11;

            var expected = "INSCREVA-35";
            var sb = new StringBuilder();
            foreach (var item in tree.PostOrderTraversal())
            {
                sb.Append(item);
            }

            var result = sb.ToString();
        }
    }
}
