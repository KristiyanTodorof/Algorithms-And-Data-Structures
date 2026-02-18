using static FindMinimum.FindMinimumExample;

    int[] array = { 38, 27, 43, 3, 9, 82, 10 };

    Console.WriteLine("Array:");
    Console.WriteLine(string.Join(", ", array));

    int minElement = FindMinimumNumber(array);

    Console.WriteLine($"The minimum element in the array is: {minElement}");