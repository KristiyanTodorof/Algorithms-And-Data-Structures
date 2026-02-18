static double Power(double x, int n)
{
    if (n == 0)
    {
        return 1;
    }
    double halfPower = Power(x, n / 2);

    if(n % 2 == 0)
    {
        return halfPower * halfPower;
    }
    return x * halfPower * halfPower;   
}

double x = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

double result = Power(x, n);

Console.WriteLine($"{result}");
