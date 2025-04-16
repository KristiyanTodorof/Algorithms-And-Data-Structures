static int Fibonacci(int number)
{
    if (number <= 1)
    {
        return number;
    }
    return Fibonacci(number - 1) + Fibonacci(number - 2);
}

int n = int.Parse(Console.ReadLine());

int result = Fibonacci(n);
Console.WriteLine($"The {n}th Fibonacci number is: {result}");