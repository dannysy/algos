namespace Main.Exercises
{
    public class QuickSortLargeArraysTaskMain
    {
        //public static void Main()
        //{
        //    Random rnd = new Random();
        //    var array1 = new int[10000000];
        //    for (int i = 0; i < 10000000; i++)
        //        array1[i] = rnd.Next(10000000);
        //    var s = string.Join(" ", array1);

        //    var array = s.Split(' ').Select(int.Parse).ToArray();
        //    QuickSort(ref array, array.Length);
        //    for (int i = 9; i < array.Length; i += 10)
        //    {
        //        Console.Write(array[i] + " ");
        //    }
        //    Console.ReadKey();
        //}

        //private static void PasteSort(ref int[] array, int length)
        //{
        //    var sortedArray = new int[length];
        //    var sortedLength = 0;
        //    foreach (var element in array)
        //    {
        //        if (sortedLength == 0)
        //        {
        //            sortedArray[0] = element;
        //            sortedLength++;
        //            continue;
        //        }
        //        for (int i = sortedLength - 1; i >= 0; i--)
        //        {
        //            if (sortedArray[i] > element)
        //            {
        //                sortedArray[i + 1] = sortedArray[i];
        //                sortedArray[i] = element;
        //            }
        //            else
        //            {
        //                sortedArray[i + 1] = element;
        //                break;
        //            }
        //        }
        //        sortedLength++;
        //    }
        //    array = sortedArray;
        //}

        //private static void QuickSort(ref int[] array, int length)
        //{
        //    QuickSortReq(ref array, 0, length - 1);
        //}

        //private static void QuickSortReq(ref int[] array, int headIndex, int tailIndex)
        //{
        //    //if (tailIndex - headIndex <= 40)
        //    //{
        //    //    PasteSort(ref array, array.Length);
        //    //    return;
        //    //}
        //    var partition = Partition(array, headIndex, tailIndex);
        //    if (partition > headIndex) QuickSortReq(ref array, headIndex, partition - 1);
        //    if (partition < tailIndex) QuickSortReq(ref array, partition + 1, tailIndex);
        //}

        //private static int Partition(int[] array, int headIndex, int tailIndex)
        //{
        //    if (tailIndex <= headIndex)
        //        return headIndex;
        //    int pivot = array[tailIndex];
        //    int left = headIndex, right = tailIndex - 1;
        //    while (left <= right)
        //    {
        //        while (array[left] < pivot) ++left;
        //        while (right >= 0 && array[right] >= pivot) --right;
        //        if (left < right)
        //            Swap(array, left++, right--);
        //    }
        //    Swap(array, left, tailIndex);
        //    return left;
        //}

        //private static void Swap(int[] array, int firstIndex, int secondIndex)
        //{
        //    var tmp = array[firstIndex];
        //    array[firstIndex] = array[secondIndex];
        //    array[secondIndex] = tmp;
        //}
    }
}