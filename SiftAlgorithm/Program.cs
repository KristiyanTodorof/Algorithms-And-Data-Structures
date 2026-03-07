using static SiftAlgorithm.SiftAl;

int[] searchArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
int target = 13;
int searchResult = SiftSearch(searchArray, target);
Console.WriteLine($"Search result for {target}: {searchResult}");

// Heap example
int[] heapArray = { 12, 11, 13, 5, 6, 7 };
Console.WriteLine("Original Array: " + string.Join(", ", heapArray));

Heapify(heapArray);
Console.WriteLine("Heapified Array: " + string.Join(", ", heapArray));