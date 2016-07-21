using System;
using System.Text;

namespace BinarySearch
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var firstLen = Console.ReadLine();
            uint firstLength;
            if (!uint.TryParse(firstLen, out firstLength) || firstLength <= 0)
                return;
            var firstString = Console.ReadLine();
            if (firstString == null)
                return;
            var firstArray = firstString.Split(' ');
            if (firstArray.Length != firstLength)
                return;
            var secondLen = Console.ReadLine();
            uint secondLength;
            if (!uint.TryParse(secondLen, out secondLength) || secondLength <= 0)
                return;
            var secondString = Console.ReadLine();
            if (secondString == null)
                return;
            var secondArray = secondString.Split(' ');
            if (secondArray.Length != secondLength)
                return;
            var result = new StringBuilder();
            foreach (var secondValue in secondArray)
            {
                var index = BinarySearchNearestElement(firstArray, secondValue);
                result.Append(index + " ");
            }
            var format = result.ToString();
            Console.WriteLine(format.Remove(format.Length - 1));
            Console.ReadKey();
        }

        public static int BinarySearchNearestElement(string[] array, string value)
        {
            var first = 0;
            var last = array.Length - 1;
            var section = new int[2];
            while (first < last)
            {
                section[0] = first;
                section[1] = last;
                var mid = (first + last) / 2;
                if (Convert.ToInt32(value) <= Convert.ToInt32(array[mid]))
                    last = mid;
                else if (Convert.ToInt32(value) < Convert.ToInt32(array[mid + 1]))
                {
                    section[0] = mid;
                    section[1] = mid + 1;
                    break;
                }
                else first = mid + 1;
            }
            var resultIndex = Math.Abs(Convert.ToInt32(value) - Convert.ToInt32(array[section[0]])) > Math.Abs(Convert.ToInt32(value) - Convert.ToInt32(array[section[1]])) ? section[1] : section[0];
            while (resultIndex != 0 && Convert.ToInt32(array[resultIndex]) == Convert.ToInt32(array[resultIndex - 1]))
            {
                resultIndex--;
            }
            return resultIndex;
        }
    }
}
