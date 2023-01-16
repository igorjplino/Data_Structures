using System.Collections;
using System.Threading;

namespace Array
{
    public class Array<T> : IEnumerable<T>
    {
        private long _limitSize;

        private T[] _array;
        private long _length;

        public Array(long? size = 0)
        {
            _limitSize = size ?? 10;
            _array = new T[_limitSize];
            _length = 0;
        }

        public long Lenght => _length;

        public bool IsEmpty => _length == 0;

        public void Append(T value)
        {
            if (_limitSize == _length)
            {
                IncrementArraySize();
            }

            _array[_length] = value;
            
            _length++;
        }

        private void IncrementArraySize()
        {
            _limitSize += 10;
            var newArray = new T[_limitSize];

            for (long i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        public void Insert(long index, T value)
        {
            if (index > (_limitSize - 1))
                throw new ArgumentOutOfRangeException();

            if (_limitSize == _length)
            {
                IncrementArraySize();
            }

            for (long i = _length; i >= index; i--)
            {
                _array[i]  = _array[i - 1];
            }

            _array[index] = value;

            _length++;
        }

        public long GetIndex(T value)
        {
            for (int i = 0; i < _length; i++)
            {
                if (_array[i]!.Equals(value))
                    return i;
            }

            return -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (IsEmpty)
                yield return (T)Enumerable.Empty<T>();

            for (int i = 0; i < _length; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
