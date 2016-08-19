namespace Main.Exercises
{
    public class HashTableTaskMain
    {
        //public static void Main()
        //{
        //    var hashTable = new OAHashTable<string, string>(8);
        //    var sb = new StringBuilder();
        //    while (true)
        //    {
        //        var readLine = Console.ReadLine();
        //        if (readLine == null || readLine.Equals(string.Empty)) break;
        //        var input = readLine.Split(' ');
        //        switch (input[0])
        //        {
        //            case "+":
        //                {
        //                    sb.AppendLine(Output(hashTable.Put(input[1], input[1])));
        //                    break;
        //                }
        //            case "-":
        //                {
        //                    sb.AppendLine(Output(hashTable.Delete(input[1])));
        //                    break;
        //                }
        //            case "?":
        //                {
        //                    sb.AppendLine(Output(hashTable.ContainsKey(input[1])));
        //                    break;
        //                }
        //        }
        //    }
        //    Console.WriteLine(sb.ToString());
        //}

        //private static string Output(bool condition)
        //{
        //    return condition ? "OK" : "FAIL";
        //}

        //private class Entry<TKey, TValue>
        //{
        //    public TKey Key { get; }
        //    public TValue Value { get; }
        //    public bool Deleted { get; set; }

        //    public Entry(TKey key, TValue value)
        //    {
        //        Key = key;
        //        Value = value;
        //        Deleted = false;
        //    }
        //}

        //private class OAHashTable<TKey, TValue>
        //{
        //    private float _loadFactor;
        //    private int _capacity;
        //    private Entry<TKey, TValue>[] _bucket;
        //    private int _entriesCount;

        //    public OAHashTable(int capacity, float loadFactor = 0.75f)
        //    {
        //        _capacity = capacity;
        //        _loadFactor = loadFactor;
        //        _bucket = new Entry<TKey, TValue>[_capacity];
        //    }

        //    public bool Put(TKey key, TValue value)
        //    {
        //        if ((double)_entriesCount / _capacity >= _loadFactor)
        //            RebuildHash();
        //        var index = GetHash(key) % _capacity;
        //        var entry = _bucket[index];
        //        var tryNumber = 1;
        //        while (entry != null && !entry.Deleted)
        //        {
        //            if (entry.Key.Equals(key))
        //                return false;
        //            index += tryNumber % 2;
        //            if (index >= _capacity)
        //                RebuildHash();
        //            entry = _bucket[index];
        //            ++tryNumber;
        //        }
        //        _bucket[index] = new Entry<TKey, TValue>(key, value);
        //        _entriesCount++;
        //        return true;
        //    }

        //    public bool Delete(TKey key)
        //    {
        //        var index = GetBucketIndex(key);
        //        if (index == -1)
        //            return false;
        //        _bucket[index].Deleted = true;
        //        _entriesCount--;
        //        return true;
        //    }

        //    public bool TryGetValue(TKey key, out TValue value)
        //    {
        //        var index = GetBucketIndex(key);
        //        if (index == -1)
        //        {
        //            value = default(TValue);
        //            return false;
        //        }
        //        value = _bucket[index].Value;
        //        return true;
        //    }

        //    public bool ContainsKey(TKey key)
        //    {
        //        return GetBucketIndex(key) != -1;
        //    }

        //    private long GetBucketIndex(TKey key)
        //    {
        //        var index = GetHash(key) % _capacity;
        //        var entry = _bucket[index];
        //        if (entry == null)
        //            return -1;
        //        var tryNumber = 1;
        //        while (entry != null)
        //        {
        //            if (entry.Deleted)
        //                return -1;
        //            if (entry.Key.Equals(key))
        //                return index;
        //            index += tryNumber % 2;
        //            if (index >= _capacity)
        //                return -1;
        //            entry = _bucket[index];
        //            ++tryNumber;
        //        }
        //        return -1;
        //    }

        //    private uint GetHash(TKey key)
        //    {
        //        return (uint)key.GetHashCode() & 0x7FFFFFFF;
        //    }

        //    private void RebuildHash()
        //    {
        //        var tmpBucket = new Entry<TKey, TValue>[_capacity];
        //        Array.Copy(_bucket, tmpBucket, _capacity);
        //        _capacity = _capacity * 2;
        //        _entriesCount = 0;
        //        _bucket = new Entry<TKey, TValue>[_capacity];
        //        foreach (var entry in tmpBucket)
        //        {
        //            if (entry != null && !entry.Deleted)
        //                Put(entry.Key, entry.Value);
        //        }
        //    }
        //}
    }
}