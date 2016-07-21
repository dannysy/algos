using System;

namespace Deck
{
    public class IntArrayDeck
    {
        private int _first;
        private int _last;
        private int _size;
        private int[] _buffer;

        public IntArrayDeck(int size)
        {
            _first = 0;
            _last = 0;
            _buffer = new int[size];
            _size = size;
        }

        public void PushFront(int value)
        {
            if(_last + 1 % _size == _first)
                ReallocateFront();
            _buffer[_last] = value;
            _last++;
        }

        public int PopFront()
        {
            if(_last == _first)
                return -1;
            var result = _buffer[_last - 1];
            _buffer[_last - 1] = 0;
            _last--;
            return result;
        }

        public void PushBack(int value)
        {
            if(_first == 0)
                ReallocateBack();
            _buffer[_first - 1] = value;
            _first--;
        }

        public int PopBack()
        {
            if(_last == _first)
                return -1;
            var result = _buffer[_first];
            _buffer[_first] = 0;
            _first++;
            return result;
        }

        private void ReallocateFront()
        {
            var newBuffer = new int[_size * 2];
            Array.Copy(_buffer, 0, newBuffer, 0, _size);
            _size = _size * 2;
            _buffer = newBuffer;
        }

        private void ReallocateBack()
        {
            var newBuffer = new int[_size * 2];
            Array.Copy(_buffer, 0, newBuffer, _size, _size);
            _first = _first + _size;
            _last = _last + _size;
            _size = _size * 2;
            _buffer = newBuffer;
        }
    }
}