using static InsertionSort.InsertionSortExample;
int[] array = { 12, 11, 13, 5, 6 };

Console.WriteLine("Original Array:");
Console.WriteLine(string.Join(", ", array));

Insertion(array);

Console.WriteLine("Sorted Array:");
Console.WriteLine(string.Join(", ", array));
