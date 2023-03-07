namespace MathProblems;

public class PrimeSum
{
    public static void PrimeSumUnder2Million()
    {
        long sum = 2;
        for (long i = 3; i <= 2000000; i++)
        {
            if (Prime10001.IsPrime(i))
                sum += i;
        }
        Console.WriteLine(sum);
    }
}