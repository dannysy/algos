using System;

namespace Sort.Models
{
    public struct Entry<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
}