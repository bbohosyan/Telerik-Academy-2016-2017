using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    private static void AssertionArrayLengthLessThanZero<T>(T[] arr) where T : IComparable<T>
    {
        bool isLengthArrBiggerThanZero = false;
        if (arr.Length > 0)
        {
            isLengthArrBiggerThanZero = true;
        }
        Debug.Assert(isLengthArrBiggerThanZero, "SelectionSort. Given array's length is less than 0");
    }

    private static void AssertionArrayElementNull<T>(T[] arr) where T : IComparable<T>
    {
        bool isSomeArrElementNull = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == null)
            {
                isSomeArrElementNull = true;
                break;
            }
        }
        Debug.Assert(isSomeArrElementNull, "SelectionSort. Given array's element is null");
    }

    private static void AssertionArrayArrElementNotNumber<T>(T[] arr) where T : IComparable<T>
    {
        bool isSomeArrElementNotNumber = false;
        for (int i = 0; i < arr.Length; i++)
        {
            decimal n;
            bool isNumeric = decimal.TryParse(arr[i].ToString(), out n);
            if (isNumeric == false)
            {
                isSomeArrElementNotNumber = true;
                break;
            }
        }
        Debug.Assert(isSomeArrElementNotNumber, "SelectionSort. Given array's element is not number");
    }

    private static void AssertionNumberLessThanZero(int number)
    {
        Debug.Assert(number < 0, "FindMinElementIndex. Index is less than zero");
    }

    private static void AssertionCompareStartAndLastIndexes(int startindex, int lastindex)
    {
        Debug.Assert(startindex > lastindex, "FindMinElementIndex. Start index bigger than last index");
    }

    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        AssertionArrayArrElementNotNumber(arr);
        AssertionArrayElementNull(arr);
        AssertionArrayLengthLessThanZero(arr);
        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        AssertionArrayArrElementNotNumber(arr);
        AssertionArrayElementNull(arr);
        AssertionArrayLengthLessThanZero(arr);
        AssertionNumberLessThanZero(startIndex);
        AssertionNumberLessThanZero(endIndex);
        AssertionCompareStartAndLastIndexes(startIndex, endIndex);

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        AssertionArrayArrElementNotNumber(arr);
        AssertionArrayElementNull(arr);
        AssertionArrayLengthLessThanZero(arr);
        AssertionNumberLessThanZero(startIndex);
        AssertionNumberLessThanZero(endIndex);
        AssertionCompareStartAndLastIndexes(startIndex, endIndex);

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}