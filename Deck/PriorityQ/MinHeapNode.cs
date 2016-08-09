namespace PriorityQ
{
    public class MinHeapNode<T>
    {
        public MinHeapNode(int priority, T value)
        {
            Priority = priority;
            Value = value;
        }

        public T Value { get; set; }
        public int Priority { get;}
    }
}