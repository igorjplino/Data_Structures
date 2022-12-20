using System.Text;

namespace LinkedList
{
    internal class LinkedList<T>
    {
        private Node<T>? _head;
        private long _length;

        public LinkedList()
        {
            _head = null;
            _length = 0;
        }

        public bool IsEmpty => _head == null;
        public long Length => _length;

        public void Append(T value)
        {
            var newValue = new Node<T>(value);

            if (IsEmpty)
            {
                _head = newValue;

                _length++;
                return;
            }

            var pointer = _head;

            while (pointer!.Next is not null)
                pointer = pointer.Next;

            pointer.Next = newValue;

            _length++;
        }

        public long GetIndex(T? value)
        {
            var pointer = _head;

            long i = 0;

            while (pointer is not null)
            {
                if (pointer.Data!.Equals(value))
                    return i;

                i++;
                pointer = pointer.Next;
            }

            return -1;
        }

        public void Insert(int index, T value)
        {
            var newValue = new Node<T>(value);

            if (index == 0)
            {
                newValue.Next = _head;
                _head = newValue;

                _length++;
                return;
            }

            var pointer = GetNodeByIndex(index - 1);
            newValue.Next = pointer.Next;
            pointer.Next = newValue;

            _length++;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            var pointer = _head;
            while (pointer is not null)
            {
                sb.Append(string.Format("{0} -> ", pointer.Data));
                pointer = pointer.Next;
            }

            return sb.ToString();
        }

        private Node<T> GetNodeByIndex(long index)
        {
            var pointer = _head;

            for (var i = 0; i < index; i++)
            {
                pointer = pointer?.Next ?? throw new IndexOutOfRangeException();
            }

            return pointer ?? throw new IndexOutOfRangeException();
        }
    }
}
