using System;
using System.Collections;
using System.Collections.Generic;

namespace Deck
{
    public class CQueue
    {
        private int _first;
        private int _last;
        private int[] _buffer;
        private int _size;

        public CQueue(int size)
        {
            _first = 0;
            _last = 0;
            _buffer = new int[size];
            _size = size;
        }

        public void Enqueue(int value)
        {
            if(_last + 1 % _size == _first)
                throw new Exception("Queue is full");
            _buffer[_last] = value;
            _last = (_last + 1) %_size;
        }

        public int Dequeue()
        {
            if (_last  == _first)
                throw new Exception("Queue is empty");
            var value = _buffer[_first];
            _first = (_first + 1) % _size;
            return value;
        }
    }
}