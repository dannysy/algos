using System;
using System.Collections.Generic;
using PriorityQ;
using Sort.Models;
using Sort.Tasks;

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

        public static XYPoint[] XyPyramidSort(XYPoint[] array)
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

        public static PointWithType[] MergeSort(PointWithType[] array, int length)
        {
            MergeSortReq(array, 0, length - 1);
            return array;
        }

        private static void MergeSortReq(PointWithType[] array, int headIndex, int tailIndex)
        {
            if (tailIndex <= headIndex)
                return;
            var middle = (tailIndex + headIndex) / 2;
            MergeSortReq(array, headIndex, middle);
            MergeSortReq(array, middle + 1, tailIndex);
            Merge(array, headIndex, middle, middle + 1, tailIndex);
        }

        private static void Merge(PointWithType[] array, int headLeft, int tailLeft, int headRight, int tailRight)
        {
            var leftLength = tailLeft - headLeft + 1;
            var rightLength = tailRight - headRight + 1;
            var length = leftLength + rightLength;
            var tmpArray = new PointWithType[length];
            int rightPtr = headRight, leftPtr = headLeft, ptr = 0;
            while (rightPtr <= tailRight && leftPtr <= tailLeft)
            {
                if (array[rightPtr].CompareTo(array[leftPtr]) == -1)
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

        public static int[] DeepMerge(List<int[]> sortedArrays, int count, int length)
        {
            var minHeap = new MinHeap<ValueInfo>(count);
            var sorted = new int[length * count];
            var ind = 0;
            for (int i = 0; i < count; i++)
            {
                var value = sortedArrays[i][0];
                minHeap.InsertWithPriority(value, new ValueInfo(0, i, value));
            }
            while (minHeap.Length > 0)
            {
                var min = minHeap.GetNext();
                sorted[ind++] = min.Value;
                if(min.ValueIndex >= sortedArrays[min.ArrayIndex].Length - 1) continue;
                var nextValue = new ValueInfo(min.ValueIndex + 1, min.ArrayIndex, sortedArrays[min.ArrayIndex][min.ValueIndex + 1]);
                minHeap.InsertWithPriority(nextValue.Value, nextValue);
            }
            return sorted;
        }

        public static int[] QuickSort(int[] array, int length)
        {
            QuickSortReq(array, 0, length - 1);
            return array;
        }

        private static void QuickSortReq(int[] array, int headIndex, int tailIndex)
        {
            var partition = Partition(array, headIndex, tailIndex);
            if(partition > headIndex) QuickSortReq(array, headIndex, partition - 1);
            if(partition < tailIndex) QuickSortReq(array, partition + 1, tailIndex);
        }

        public static int Partition(int[] array, int headIndex, int tailIndex)
        {
            if (tailIndex <= headIndex)
                return headIndex;
            int pivot = array[tailIndex];
            int left = headIndex, right = tailIndex - 1;
            while (left <= right)
            {
                while (array[left] < pivot) ++left;
                while (right >= 0 && array[right] >= pivot) --right;
                if (left < right)
                    Swap(array, left++, right--);
            }
            Swap(array, left, tailIndex);
            return left;
        }

        public static void Swap(int[] array, int firstIndex, int secondIndex)
        {
            var tmp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = tmp;
        }
    }
}