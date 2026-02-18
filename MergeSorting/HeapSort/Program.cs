using static HeapSort.Heap;

int[] array = { 38, 27, 43, 3, 9, 82, 10 };

Console.WriteLine("Original Array:");
Console.WriteLine(string.Join(", ", array));

HeapSortt(array);

Console.WriteLine("Sorted Array:");
Console.WriteLine(string.Join(", ", array));