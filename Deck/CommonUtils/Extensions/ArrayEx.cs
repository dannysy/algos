using PriorityQ;

namespace CommonUtils.Extensions
{
    public static class ArrayEx
    {
        public static bool AreEqual(this int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length != secondArray.Length)
                return false;
            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] != secondArray[index])
                    return false;
            }
            return true;
        }

        public static bool AreEqual(this long[] firstArray, long[] secondArray)
        {
            if (firstArray.Length != secondArray.Length)
                return false;
            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] != secondArray[index])
                    return false;
            }
            return true;
        }

        public static bool AreEqual(this XYPoint[] firstArray, XYPoint[] secondArray)
        {
            if (firstArray.Length != secondArray.Length)
                return false;
            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index].CompareTo(secondArray[index]) != 0)
                    return false;
            }
            return true;
        }
    }
}