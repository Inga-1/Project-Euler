namespace MathProblems;

public class SumSquareDifference
{
    private static int SumOfSquares()
    {
        var sum = 0;
        for (var i = 1; i <= 100; i++)
        {
            sum += i * i;
        }

        return sum;
    }

    private static int SquareOfSums()
    {
        var sum = 0;
        for (var i = 1; i <= 100; i++)
        {
            sum += i;
        }

        return sum * sum;
    }

    public static int SumSquareDiff()
    {
        return SquareOfSums() - SumOfSquares();

    }
}