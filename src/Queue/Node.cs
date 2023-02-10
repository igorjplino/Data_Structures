﻿namespace Queue;

public class Node<T>
{
    public T Data { get; }
    public Node<T>? Next { get; set; }

    public Node(T data)
    {
        ArgumentNullException.ThrowIfNull(data);

        Data = data;
        Next = default;
    }

    public override string ToString()
    {
        return Data.ToString();
    }
}