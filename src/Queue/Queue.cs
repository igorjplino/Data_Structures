using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue;

public class Queue<T>
{
    private Node<T> _first;
    private Node<T> _last;
    private long _length;

    public Queue()
    {
        _length = 0;
    }

    public bool IsEmpty => _length == 0;

    public long Length => _length;

    public void Push(T value)
    {
        var node = new Node<T>(value);

        if (_last is null)
        {
            _last = node;
        }
        else
        {
            _last.Next = node;
            _last = node;
        }

        if (_first is null)
            _first = node;

        _length++;
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("The queue is empty");

        var elem = _first.Data;

        _first = _first.Next!;

        if (_first is null)
            _last = null;

        _length--;

        return elem;
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("The queue is empty");

        return _first.Data;
    }
}
