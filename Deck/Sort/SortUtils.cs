using PriorityQ;

namespace Sort
{
    public static class SortUtils
    {
        public static int[] PasteSort(int[] array, int length)
        {
            var sortedArray = new int[length];
            var sortedLength = 0;
            foreach (var element in array)
            {
                if (sortedLength == 0)
                {
                    sortedArray[0] = element;
                    sortedLength++;
                    continue;
                }
                for (int i = sortedLength - 1; i >= 0; i--)
                {
                    if (sortedArray[i] > element)
                    {
                        sortedArray[i + 1] = sortedArray[i];
                        sortedArray[i] = element;
                    }
                    else
                    {
                        sortedArray[i + 1] = element;
                        break;
                    }
                }
                sortedLength++;
            }
            return sortedArray;
        }

        public static int[] PyramidSort(int[] array, int length)
        {
            var priorityQueue = new PriorityQueue(array, length);
            for (int i = length - 1; i >= 0; i--)
            {
                array[i] = priorityQueue.GetNext();
            }
            return array;
        }
    }
}