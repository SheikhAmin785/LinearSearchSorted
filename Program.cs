using System;

namespace LinearSearchSorted
{
    class Program
    {
        static int LinearSearch(int[] arr, int n, int value)
        {
            for (int i = 0; i < n; i++)
            {
                if (value == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = 4;
            int result = LinearSearch(arr, arr.Length, n);
            Console.WriteLine("The item position: "+result);

        }
    }
}
