namespace BinaryTree;

public class Node<T>
{
    public T Data { get; private set; }
    public Node<T>? Left { get; set; }
    public Node<T>? Right { get; set; }

    public Node(T data)
    {
        ArgumentNullException.ThrowIfNull(data);

        Data = data;
        Left = default;
        Right = default;
    }

    public void NewData(T data)
    {
        ArgumentNullException.ThrowIfNull(data);

        Data = data;
    }

    public override string ToString()
    {
        return Data.ToString();
    }
}