namespace MathProblems;

public class DivBy3or5
{
    public static int DivisibleBy3Or5()
    {
        var result = 0;
        for (var i = 0; i < 1000; i++)
        {
            if (DivisibleBy3(i) || DivisibleBy5(i))
                result += i;
            
        }
        return result;
    }

    private static bool DivisibleBy3(int num)
    {
        return num % 3 == 0;
    }

    private static bool DivisibleBy5(int num)
    {
        return (num % 5 == 0);
    }
}
