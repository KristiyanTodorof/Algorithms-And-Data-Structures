using static StepSearch.StepSearchExample;

int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
int target = 15;

int result = Search(sortedArray, target);

if (result != -1)
{
    Console.WriteLine($"Element {target} found at index {result}");
}
else
{
    Console.WriteLine($"Element {target} not found in the array");
}
