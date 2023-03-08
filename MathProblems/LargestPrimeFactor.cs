namespace MathProblems;

public class LargestPrimeFactor
{

    public static List<long> PrimeFactorization(long number)
    {
        var result = new List<long>();
        int factor = 2;
        while (number > 1)
        {
            if (number % factor == 0)
            {
                result.Add(factor);
                number /= factor;
            }
            else
                factor++;
        }       
        return result;
    }

    public static long LargestPrime()
    {
        var factors = PrimeFactorization(600851475143);
        long max = 0;
        foreach (var factor in factors)
        {
            if (factor > max)
                max = factor;
        }
        return max;
    }
}