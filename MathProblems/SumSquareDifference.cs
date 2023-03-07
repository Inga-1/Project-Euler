namespace MathProblems;

public class SumSquareDifference
{
    private static int SumOfSquares()
    {
        return SumOfSquaresGeneric(100);
    }

    private static int SquareOfSums()
    {
        return SquareOfSumsGeneric(100);
    }

    public static int SumSquareDiff()
    {
        return SumSquareDiffGeneric(100);
    }
    

    //a generic function to calculate sum of squares and square of sums up to given number 

    public static int SumOfSquaresGeneric(int number)
    {
        var sum = 0;
        for (var i = 1; i <= number; i++)
            sum += i * i;
        
        return sum;
    }

    public static int SquareOfSumsGeneric(int number)
    {
        var sum = 0;
        for (var i = 1; i <= number; i++)
            sum += i;

        return sum * sum;
    }
    public static int SumSquareDiffGeneric(int number)
    {
        return SquareOfSumsGeneric(number) - SumOfSquaresGeneric(number);

    }
}