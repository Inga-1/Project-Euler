using Microsoft.VisualBasic.CompilerServices;

namespace MathProblems;

public class HighlyDivisibleTriangularNumber
{
    private static List<int> GetTheFactors(long number)
    {
        var result = new List<int>();
        for (var i = 1; i <= number; i++)
        {
            if (number % i != 0) continue;
            if (result.Contains(i)) continue;
            result.Add(i);
            //number /= i;
        }
        return result;
    }


    public static void GenerateTheList()
    {
        var i = 1;
        while (true)
        {
            
            var sum = 0;
            for (var j = 1; j <= i; j++)
                sum += j;
            Console.WriteLine(sum);
            foreach (var item in GetTheFactors(sum))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("number of factors is {0}", GetTheFactors(sum).Count);

            if (GetTheFactors(sum).Count > 500)
            {
                Console.WriteLine(sum);
                break;
            }
            i++;

        }
    }
}