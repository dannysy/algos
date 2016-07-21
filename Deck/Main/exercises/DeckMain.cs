using System;

namespace Main.exercises
{
    public class DeckMain
    {
        //public static void Main()
        //{
        //    var length = Console.ReadLine();
        //    uint len;
        //    if (!uint.TryParse(length, out len) || len <= 0)
        //        return;
        //    var deck = new Deck(100000);
        //    string result = string.Empty;
        //    for (int i = 0; i < len; i++)
        //    {
        //        var firstString = Console.ReadLine();
        //        if (firstString == null)
        //            return;
        //        var command = firstString.Split(' ');
        //        if (command.Length != 2)
        //            return;
        //        result = GetResult(command, deck);
        //        if (result == "NO")
        //            break;
        //    }
        //    Console.WriteLine(result);
        //    Console.ReadKey();
        //}

        private static string GetResult(string[] command, Deck deck)
        {
            switch (command[0])
            {
                case "1":
                {
                    deck.PushFront(Convert.ToInt32(command[1]));
                    return string.Empty;
                }
                case "2":
                {
                    var result = deck.PopFront();
                    return result == Convert.ToInt32(command[1]) ? "YES" : "NO";
                }
                case "3":
                {
                    deck.PushBack(Convert.ToInt32(command[1]));
                    return string.Empty;
                }
                case "4":
                {
                    var result = deck.PopBack();
                    return result == Convert.ToInt32(command[1]) ? "YES" : "NO";
                }
                default:
                    return string.Empty;
            }
        }

        public class Deck
        {
            private int _first;
            private int _last;
            private int _size;
            private int[] _buffer;

            public Deck(int size)
            {
                _first = 0;
                _last = 0;
                _buffer = new int[size];
                _size = size;
            }

            public void PushFront(int value)
            {
                if (_last + 1 % _size == _first)
                    ReallocateFront();
                _buffer[_last] = value;
                _last++;
            }

            public int PopFront()
            {
                if (_last == _first)
                    return -1;
                var result = _buffer[_last - 1];
                _buffer[_last - 1] = 0;
                _last--;
                return result;
            }

            public void PushBack(int value)
            {
                if (_first == 0)
                    ReallocateBack();
                _buffer[_first - 1] = value;
                _first--;
            }

            public int PopBack()
            {
                if (_last == _first)
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
}