using System;

namespace PriorityQ
{
    public class MinHeap<T>
    {
        private int _size;
        private MinHeapNode<T>[] _buffer;
        private int _length;

        public MinHeap(int size)
        {
            _buffer = new MinHeapNode<T>[size];
            _size = size;
        }

        public MinHeap(int[] buffer)
        {
            _buffer = new MinHeapNode<T>[buffer.Length];
            Array.Copy(buffer, _buffer, buffer.Length);
            _size = _buffer.Length;
            _length = _buffer.Length;
            BuildHeap();
        }

        public MinHeap(int[] buffer, int length)
        {
            if (buffer.Length < length) throw new ArgumentOutOfRangeException(nameof(length));
            _buffer = new MinHeapNode<T>[buffer.Length];
            Array.Copy(buffer, _buffer, buffer.Length);
            _size = length;
            _length = length;
            BuildHeap();
        }

        public int Length
        {
            get { return _length; }
            private set { _length = value; }
        }

        public void InsertWithPriority(int priority, T value)
        {
            if (_length == _size)
                Reallocate();
            _buffer[_length] = new MinHeapNode<T>(priority, value);
            _length++;
            SiftUp(_length - 1);
        }

        public T GetNext()
        {
            var next = _buffer[0];
            _buffer[0] = _buffer[_length - 1];
            _buffer[_length - 1] = null;
            _length--;
            if (_length > 1)
                SiftDown(0);
            return next.Value;
        }

        public T PeekAtNext()
        {
            if (_length == 0)
                throw new Exception("empty");
            return _buffer[0].Value;
        }

        private int GetParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        private int GetMinChildIndex(int index)
        {
            var first = index * 2 + 1;
            var second = index * 2 + 2;
            if (first >= _length)
                return -1;
            if (second >= _length)
                return first;
            return _buffer[first].Priority < _buffer[second].Priority ? first : second;
        }

        private void Reallocate()
        {
            var newBuffer = new MinHeapNode<T>[_size * 2];
            Array.Copy(_buffer, 0, newBuffer, 0, _size);
            _size = _size * 2;
            _buffer = newBuffer;
        }

        private void SiftUp(int index)
        {
            if (_length <= 0)
                throw new Exception("empty");
            while (index > 0)
            {
                var parentIndex = GetParentIndex(index);
                if (_buffer[parentIndex].Priority <= _buffer[index].Priority)
                    return;
                var tmpParent = _buffer[parentIndex];
                _buffer[parentIndex] = _buffer[index];
                _buffer[index] = tmpParent;
                index = parentIndex;
            }
        }

        private void SiftDown(int index)
        {
            if (_length <= 0)
                throw new Exception("empty");
            while (index <= _length / 2 - 1)
            {
                var largestChildIndex = GetMinChildIndex(index);
                if (_buffer[index].Priority <= _buffer[largestChildIndex].Priority)
                    return;
                var tmpParent = _buffer[index];
                _buffer[index] = _buffer[largestChildIndex];
                _buffer[largestChildIndex] = tmpParent;
                index = largestChildIndex;
            }
        }

        private void BuildHeap()
        {
            if (_length <= 0)
                throw new Exception("empty");
            for (int i = _length / 2 - 1; i >= 0; i--)
            {
                SiftDown(i);
            }
        }
    }
}