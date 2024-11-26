using System;

class Program
{
    static long Factorial(int n)
    {
        if (n == 0 || n == 1) 
            return 1;

        long result = 1;
        for (int i = 2; i <= n; i++) 
        {
            result *= i;
        }

        return result;
    }

    static void Main()
    {
        long factorial5 = Factorial(5);
        long factorial6 = Factorial(6);
        long factorial8 = Factorial(8);
        long factorial4 = Factorial(4);

        long result = 2 * factorial5 + 3 * (factorial8 / factorial6) + factorial4;

        Console.WriteLine("Андрей Валентинович вот стока кароче: " + result);
    }
}