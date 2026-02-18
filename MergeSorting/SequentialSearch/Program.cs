using static SequentialSearch.SequentialSearchExample;

int[] numbers = { 5, 2, 8, 12, 3, 7, 9 };
int targetValue = 8;

int result = Search(numbers, targetValue);

if (result != -1)
{
    Console.WriteLine($"Element {targetValue} found at index {result}");
}
else
{
    Console.WriteLine($"Element {targetValue} not found in the array");
}
