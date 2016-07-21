using System.Collections.Generic;

namespace Deck
{
    public class Deck<T>
    {
        private LinkedList<DeckNode<T>> _buffer;

        public Deck()
        {
            _buffer = new LinkedList<DeckNode<T>>();
        }

        public void PushFront(DeckNode<T> value)
        {
            _buffer.AddFirst(value);
        }

        public DeckNode<T> PopFront()
        {
            if (_buffer.First == null)
                return new DeckNode<T>() { IsEmpty = true };
            var result = _buffer.First.Value;
            _buffer.RemoveFirst();
            return result;
        }

        public void PushBack(DeckNode<T> value)
        {
            _buffer.AddLast(value);
        }

        public DeckNode<T> PopBack()
        {
            if (_buffer.Last == null)
                return new DeckNode<T>() {IsEmpty = true};
            var result = _buffer.Last.Value;
            _buffer.RemoveLast();
            return result;
        }
    }
}