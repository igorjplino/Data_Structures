namespace BinaryTree;

public class BinarySearchTree : BaseBinaryTree<int>
{
    public void Insert(int value)
    {
        Node<int>? parent = null;
        var x = _root;

        while (x is not null)
        {
            parent = x;
            if (value < x.Data)
                x = x.Left;
            else
                x = x.Right;
        }

        if (parent is null)
            _root = new Node<int>(value);
        else if (value < parent.Data)
            parent.Left = new Node<int>(value);
        else
            parent.Right = new Node<int>(value);
    }

    public int? Search(int value)
    {
        return Search(value, _root)?.Data;
    }

    private Node<int>? Search(int value, Node<int>? node)
    {
        if (node is null)
            return node;

        if (node.Data == value)
            return node;

        if (node.Data < value)
            return Search(value, node.Left);
        
        return Search(value, node.Right);
    }
}

