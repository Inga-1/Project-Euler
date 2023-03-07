using System.Numerics;

namespace MathProblems;

public class Power
{
    public static void PowerSum()
    {
        BigInteger sum = 0;
        BigInteger result = BigInteger.Pow(2, 1000);
        while (result > 0)
        {
            var digit = result % 10;
            sum += digit;
            result /= 10;
        }

        Console.WriteLine(result);
        Console.WriteLine(sum);
    }
}