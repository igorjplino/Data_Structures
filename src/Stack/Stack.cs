using System.Collections;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private Node<T> _top;
        private long _length;

        public Stack()
        {
            _length = 0;
        }

        public bool IsEmpty => _top == null;

        public long Length => _length;

        public void Push(T value)
        {
            var node = new Node<T>(value)
            {
                Next = _top
            };

            _top = node;

            _length++;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new Exception("Stack is empty");

            var node = _top;
            _top = node.Next!;

            _length--;

            return node.Data;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new Exception("Stack is empty");

            return _top.Data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (IsEmpty)
                yield return (T)Enumerable.Empty<T>();

            var pointer = _top;

            while (pointer is not null)
            {
                yield return pointer.Data;

                pointer = pointer.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
