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
            var middle = (tailIndex + headIndex)/2;
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
            var middle = (tailIndex + headIndex)/2;
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
            var sorted = new int[length*count];
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
                if (min.ValueIndex >= sortedArrays[min.ArrayIndex].Length - 1) continue;
                var nextValue = new ValueInfo(min.ValueIndex + 1, min.ArrayIndex,
                    sortedArrays[min.ArrayIndex][min.ValueIndex + 1]);
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
            if (partition > headIndex) QuickSortReq(array, headIndex, partition - 1);
            if (partition < tailIndex) QuickSortReq(array, partition + 1, tailIndex);
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

        private static void Swap(int[] array, int firstIndex, int secondIndex)
        {
            var tmp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = tmp;
        }

        public static void LsdRadixBitSort(int[] array, int length)
        {
            int i, j;
            var tmp = new int[length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < array.Length; ++i)
                {
                    bool move = (array[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        array[i - j] = array[i];
                    else
                        tmp[j++] = array[i];
                }
                Array.Copy(tmp, 0, array, length - j, j);
            }
        }

        public static int[] LsdRadixSort(int[] array, int length)
        {
            return LsdRadixSortReq(array, length, 1);
        }

        private static int[] LsdRadixSortReq(int[] array, int length, int digit)
        {
            var empty = true;
            var digits = new Entry<int, int>[length];
            var sorted = new int[length];
            for (int i = 0; i < length; i++)
            {
                digits[i] = new Entry<int, int>
                {
                    Key = i,
                    Value = (array[i]/digit)%10
                };
                if (array[i] / digit != 0)
                    empty = false;
            }

            if (empty)
                return array;

            var sortedDigits = CountingSort(digits);
            for (int i = 0; i < sorted.Length; i++)
                sorted[i] = array[sortedDigits[i].Key];
            return LsdRadixSortReq(sorted, length, digit * 10);
        }

        private static Entry<int, int>[] CountingSort(Entry<int, int>[] arrayA)
        {
            var arrayB = new int[MaxValue(arrayA) + 1];
            var arrayC = new Entry<int, int>[arrayA.Length];

            for (int i = 0; i < arrayB.Length; i++)
                arrayB[i] = 0;

            for (int i = 0; i < arrayA.Length; i++)
                arrayB[arrayA[i].Value]++;

            for (int i = 1; i < arrayB.Length; i++)
                arrayB[i] += arrayB[i - 1];

            for (int i = arrayA.Length - 1; i >= 0; i--)
            {
                var value = arrayA[i].Value;
                var index = arrayB[value];
                arrayB[value]--;
                arrayC[index - 1] = new Entry<int, int>
                {
                    Key = i,
                    Value = value
                };
            }
            return arrayC;
        }

        private static int MaxValue(Entry<int, int>[] arr)
        {
            var max = arr[0].Value;
            for (int i = 1; i < arr.Length; i++)
                if (arr[i].Value > max)
                    max = arr[i].Value;
            return max;
        }
    }
}