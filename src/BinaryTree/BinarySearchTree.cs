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

    public int Min(Node<int>? node = null)
    {
        node ??= _root;

        while (node.Left is not null)
            node = node.Left;

        return node.Data;
    }

    public int Max(Node<int>? node = null)
    {
        node ??= _root;

        while (node.Right is not null)
            node = node.Right;

        return node.Data;
    }

    public void Remove(int value) => Remove(value);

    private Node<int>? Remove(int value, Node<int>? node = null)
    {
        node ??= _root;

        if (node is null)
            return node;

        if (node.Data < value)
            node.Left = Remove(value, node.Left);
        else if (node.Data > value)
            node.Right = Remove(value, node.Right);
        else
        {
            if (node.Left is null)
                return node.Right;

            if (node.Right is null)
                return node.Left;

            var substitute = Min(node.Right);

            node.NewData(substitute);

            node.Right = Remove(substitute, node.Right);
        }

        return node;
    }
}

