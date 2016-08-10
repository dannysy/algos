namespace Main.Exercises
{
    public class KorderStatTaskMain
    {
        //public static void Main()
        //{
        //    var lengthAndK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //    var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //    Console.WriteLine(KstatDc(array, lengthAndK[0], lengthAndK[1]));
        //    Console.ReadKey();
        //}

        //private static int KstatDc(int[] array, int length, int k)
        //{
        //    var headIndex = 0;
        //    var tailIndex = length - 1;
        //    var partition = -1;
        //    while (partition != k)
        //    {
        //        partition = Partition(array, headIndex, tailIndex);
        //        if (partition > k)
        //        {
        //            tailIndex = partition - 1;
        //        }
        //        else
        //        {
        //            headIndex = partition + 1;
        //        }
        //    }
        //    return array[partition];
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