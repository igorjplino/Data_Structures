using System.Collections;

namespace BinaryTree;

public class Tree<T> : IEnumerable<T>
{
    public Node<T> _root;

    public IEnumerable<T> InOrderTraversal(Node<T>? node = null)
    {
        node ??= _root;

        if (node.Left is not null)
            foreach (var n in InOrderTraversal(node.Left))
                yield return n;

        yield return node.Data;

        if (node.Right is not null)
            foreach (var n in InOrderTraversal(node.Right))
                yield return n;
    }

    public IEnumerable<T> PostOrderTraversal(Node<T> node = null)
    {
        node ??= _root;

        if (node.Left is not null)
            foreach (var n in PostOrderTraversal(node.Left))
                yield return n;

        if (node.Right is not null)
            foreach (var n in PostOrderTraversal(node.Right))
                yield return n;

        yield return node.Data;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        yield return InOrderTraversal();
    }
}