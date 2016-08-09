namespace Sort.Models
{
    public class ValueInfo
    {
        public ValueInfo(int valueIndex, int arrayIndex, int value)
        {
            ValueIndex = valueIndex;
            ArrayIndex = arrayIndex;
            Value = value;
        }

        public int Value { get; }
        public int ArrayIndex { get; }
        public int ValueIndex { get; }
    }
}