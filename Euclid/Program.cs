static int GCD(int a, int b)
{
    while (b != 0)
    {
        int remainder = a % b;
        a = b;
        b = remainder;
    }
    return a;
}

static int SecondGCD(int a, int b)
{
    if (b == 0)
        return a;
    return SecondGCD(b, a % b);
}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int gcd = SecondGCD(num1, num2);

Console.WriteLine($"The GCD of {num1} and {num2} is: {gcd}");