namespace BinaryTree;

public class Node<T>
{
    public T Data { get; }
    public Node<T>? Left { get; set; }
    public Node<T>? Right { get; set; }

    public Node(T data)
    {
        ArgumentNullException.ThrowIfNull(data);

        Data = data;
        Left = default;
        Right = default;
    }

    public override string ToString()
    {
        return Data.ToString();
    }
}