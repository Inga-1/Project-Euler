namespace MathProblems;

public class Fibonacci
{

    public static long SumOfEvenFibonacciTo4Million()
    {
        var list = Generate();

        return list.Where(v => v % 2 == 0).Sum();
    }

    private static List<long> Generate()
    {
        var listOfNum = new List<long>();
        var first = 1;
        var second = 2;
        listOfNum.Add(first);
        listOfNum.Add(second);
        while (true)
        {
            var result = first + second;
            listOfNum.Add(result);
            first = second;
            second = result;

            if (first + second > 4000000)
            {
                break;
            }
        }

        return listOfNum;
    }
}
