using System;

namespace Sort.Tasks
{
    public static class OrderStatistics
    {
        public static int KstatDc(int[] array, int length, int k)
        {
            var headIndex = 0;
            var tailIndex = length - 1;
            var partition = -1;
            while (partition != k)
            {
                partition = SortUtils.Partition(array, headIndex, tailIndex);
                if (partition > k)
                {
                    tailIndex = partition - 1;
                }
                else
                {
                    headIndex = partition + 1;
                }
            }
            return array[partition];
        }
    }
}