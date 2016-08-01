using System;
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

        public static XYPoint[] XYPyramidSort(XYPoint[] array)
        {
            var xyPriorityQueue = new XYPriorityQueue(array);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = xyPriorityQueue.GetNext();
            }
            return array;
        }

        public static int[] MergeSort(int[] array, int length)
        {
            MergeSortReq(array, 0, length - 1);
            return array;
        }

        private static void MergeSortReq(int[] array, int headIndex, int tailIndex)
        {
            if (tailIndex <= headIndex)
                return;
            var middle = (tailIndex + headIndex) / 2;
            MergeSortReq(array, headIndex, middle);
            MergeSortReq(array, middle + 1, tailIndex);
            Merge(array, headIndex, middle, middle + 1, tailIndex);
        }

        private static void Merge(int[] array, int headLeft, int tailLeft, int headRight, int tailRight)
        {
            var leftLength = tailLeft - headLeft + 1;
            var rightLength = tailRight - headRight + 1;
            var length = leftLength + rightLength;
            var tmpArray = new int[length];
            int rightPtr = headRight, leftPtr = headLeft, ptr = 0;
            while (rightPtr <= tailRight && leftPtr <= tailLeft)
            {
                if (array[rightPtr] < array[leftPtr])
                {
                    tmpArray[ptr] = array[rightPtr];
                    ++rightPtr;
                }
                else 
                {
                    tmpArray[ptr] = array[leftPtr];
                    ++leftPtr;
                }
                ++ptr;
            }
            while (rightPtr <= tailRight)
            {
                tmpArray[ptr] = array[rightPtr];
                ++ptr;
                ++rightPtr;
            }
            while (leftPtr <= tailLeft)
            {
                tmpArray[ptr] = array[leftPtr];
                ++ptr;
                ++leftPtr;
            }
            Array.Copy(tmpArray, 0, array, headLeft, length);
        }
    }
}