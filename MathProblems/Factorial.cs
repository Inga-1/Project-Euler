using System.Numerics;

namespace MathProblems;

public class Factorial
{
    private static List<BigInteger> Digitize(BigInteger number)
    {
        List<BigInteger> digits = new();

        while (number > 0)
        {
            var digit = number % 10;
            digits.Add(digit);
            number /= 10;
        }
        return digits;
    }
    private static BigInteger Factorize(BigInteger n)
    {
        BigInteger result = 1;
        for (var i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static BigInteger Suming(BigInteger number)
    {
        BigInteger sum = 0;
        BigInteger factored = Factorize(number);
        
        foreach(var item in Digitize(factored))
            sum += item;
        return sum;
    }
    private static bool SumOfFactors(BigInteger number)
    {
        BigInteger sum = 0;
        foreach (var item in Digitize(number))
        {
            sum += Factorize(item);
        }

        return sum == number;
    }

    public static void SpecialNumbers()
    {
        BigInteger number = 144;
        BigInteger sum = 0;
        while (number <= 99999)
        {
            if (SumOfFactors(number))
                sum += number;
            
            number++;
        }
        Console.WriteLine(sum);
    }
}

