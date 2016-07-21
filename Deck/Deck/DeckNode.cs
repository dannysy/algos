namespace Deck
{
    public struct DeckNode<T>
    {
        public T Value { get; set; }
        public bool IsEmpty { get; set; }
    }
}