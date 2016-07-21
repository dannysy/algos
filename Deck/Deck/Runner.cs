using System;

namespace Deck
{
    public class Runner
    {
        public static void Run()
        {
            var length = Console.ReadLine();
            uint len;
            if (!uint.TryParse(length, out len) || len <= 0)
                return;
            //var deck = new Deck<int>();
            var deck = new IntArrayDeck(100000);
            string result = string.Empty;
            for (int i = 0; i < len; i++)
            {
                var firstString = Console.ReadLine();
                if (firstString == null)
                    return;
                var command = firstString.Split(' ');
                if(command.Length != 2)
                    return;
                result = GetResult(command, deck);
            }
            Console.WriteLine(result);
        }

        public static string GetResult(string[] command, Deck<int> deck)
        {
            switch (command[0])
            {
                case "1":
                    {
                        deck.PushFront(new DeckNode<int>() {Value = Convert.ToInt32(command[1]), IsEmpty = false});
                        return string.Empty;
                    }
                case "2":
                 {
                    var result = deck.PopFront();
                    if(result.IsEmpty)
                        return -1 == Convert.ToInt32(command[1]) ? "YES" : "NO";
                    return result.Value == Convert.ToInt32(command[1]) ? "YES" : "NO";
                }
                case "3":
                    {
                        deck.PushBack(new DeckNode<int>() { Value = Convert.ToInt32(command[1]), IsEmpty = false });
                        return string.Empty;
                    }
                case "4":
                {
                    var result = deck.PopBack();
                    if (result.IsEmpty)
                        return -1 == Convert.ToInt32(command[1]) ? "YES" : "NO";
                    return result.Value == Convert.ToInt32(command[1]) ? "YES" : "NO";
                }
                default:
                    return string.Empty;
            }
        }

        public static string GetResult(string[] command, IntArrayDeck deck)
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
    }
}