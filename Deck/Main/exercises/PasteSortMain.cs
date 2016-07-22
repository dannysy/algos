namespace Main.exercises
{
    public class PasteSortMain
    {
        //public static void Main()
        //{
        //    var array = Console.ReadLine().Split(' ');
        //    var intArray = new List<int>(array.Length);
        //    Array.ForEach(array, s => intArray.Add(int.Parse(s)));
        //    Console.WriteLine(string.Join(" ", PasteSort(intArray.ToArray(), array.Length)));
        //}

        //private static int[] PasteSort(int[] array, int length)
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
        //    return sortedArray;
        //}
    }
}