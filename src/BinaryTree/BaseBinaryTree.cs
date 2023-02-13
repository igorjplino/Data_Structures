using System.Collections;

namespace BinaryTree;

public class BaseBinaryTree<T> : IEnumerable<T>
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

    public IEnumerable<T> LevelOrderTraversal(Node<T> node = null)
    {
        node ??= _root;

        var queue = new Queue.Queue<Node<T>>();

        queue.Push(node);

        while (!queue.IsEmpty)
        {
            node = queue.Pop();

            if (node.Left is not null)
                queue.Push(node.Left);

            if (node.Right is not null)
                queue.Push(node.Right);
            
            yield return node.Data;
        }

        yield break;
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