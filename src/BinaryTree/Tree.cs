using System.Collections;

namespace BinaryTree;

public class Tree<T> : IEnumerable<T>
{
    public Node<T> _root;

    public IEnumerable<T> SymmetricTraversal(Node<T>? node = null)
    {
        node ??= _root;

        if (node.Left is not null)
            foreach (var n in SymmetricTraversal(node.Left))
                yield return n;

        yield return node.Data;

        if (node.Right is not null)
            foreach (var n in SymmetricTraversal(node.Right))
                yield return n;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        yield return SymmetricTraversal();
    }
}