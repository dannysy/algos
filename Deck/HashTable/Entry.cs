namespace HashTable
{
    public class Entry<TKey, TValue>
    {
        public TKey Key { get; }
        public TValue Value { get; }
        public bool Deleted { get; set; }

        public Entry(TKey key, TValue value)
        {
            Key = key;
            Value = value;
            Deleted = false;
        }
    }
}