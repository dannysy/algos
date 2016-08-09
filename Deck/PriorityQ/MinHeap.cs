using System;

namespace PriorityQ
{
    public class MinHeap : PriorityQueueBase
    {
        private int _size;
        private int[] _buffer;
        private int _length;

        public MinHeap(int size)
        {
            _buffer = new int[size];
            _size = size;
        }

        public MinHeap(int[] buffer)
        {
            _buffer = new int[buffer.Length];
            Array.Copy(buffer, _buffer, buffer.Length);
            _size = _buffer.Length;
            _length = _buffer.Length;
            BuildHeap();
        }

        public MinHeap(int[] buffer, int length)
        {
            if (buffer.Length < length) throw new ArgumentOutOfRangeException(nameof(length));
            _buffer = new int[buffer.Length];
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

        public override void InsertWithPriority(int priority)
        {
            if (_length == _size)
                Reallocate();
            _buffer[_length] = priority;
            _length++;
            SiftUp(_length - 1);
        }

        public override int GetNext()
        {
            var next = _buffer[0];
            _buffer[0] = _buffer[_length - 1];
            _buffer[_length - 1] = 0;
            _length--;
            if (_length > 1)
                SiftDown(0);
            return next;
        }

        public override int PeekAtNext()
        {
            if (_length == 0)
                throw new Exception("empty");
            return _buffer[0];
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
            return _buffer[first] < _buffer[second] ? first : second;
        }

        private void Reallocate()
        {
            var newBuffer = new int[_size * 2];
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
                if (_buffer[parentIndex] <= _buffer[index])
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
                if (_buffer[index] <= _buffer[largestChildIndex])
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