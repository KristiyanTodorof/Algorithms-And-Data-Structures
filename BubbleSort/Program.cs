using static BubbleSort.BubbleSortExample;

int[] array = { 64, 34, 25, 12, 22, 11, 90 };

Console.WriteLine("Original Array:");
Console.WriteLine(string.Join(", ", array));

Bubble(array);

Console.WriteLine("Sorted Array:");
Console.WriteLine(string.Join(", ", array));

