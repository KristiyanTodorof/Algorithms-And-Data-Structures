using System;

class SelectionSort
{
    static void Main(string[] args)
    {
        int[] arr = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        SelectionSortAlgorithm(arr);

        Console.WriteLine("\nSorted array:");
        PrintArray(arr);
    }

    static void SelectionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}