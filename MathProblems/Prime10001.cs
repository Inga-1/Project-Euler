namespace MathProblems;

public class Prime10001
{
    public static int PrimeFinder()
    {
        var primes = new List<int>
        {
            2,
            3
        };
        var numToCheck = 4;
        while (primes.Count <= 10000)
        {
            if (IsPrime(numToCheck))
                primes.Add(numToCheck);
            
            numToCheck++;
        }
        return primes[10000];
    }

    public static bool IsPrime(long number)
    {
        if (number > 2 && number % 2 == 0 || number <= 0)
            return false;
        for (var i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}