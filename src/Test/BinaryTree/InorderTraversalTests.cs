using BinaryTree;

namespace Test.BinaryTree;
public class InorderTraversalTests
{
    [Fact]
    public void TempTest()
    {
        /// representation of the tree
        /*
                    1
                2       3
            4       5       6
        7
         */

        var n1 = new Node<int>(1);
        var n2 = new Node<int>(2);
        var n3 = new Node<int>(3);
        var n4 = new Node<int>(4);
        var n5 = new Node<int>(5);
        var n6 = new Node<int>(6);
        var n7 = new Node<int>(7);

        n1.Left = n2;
        n1.Right = n3;

        n2.Left = n4;
        n2.Right = n5;

        n3.Right = n6;
        n4.Left = n7;

        var tree = new Tree<int>();
        tree._root = n1;

        var expected = new int[] { 7, 4, 2, 5, 1, 3, 6 };
        var result = tree.InorderTraversal().ToList();
    }
}
