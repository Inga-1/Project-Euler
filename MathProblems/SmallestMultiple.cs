namespace MathProblems;

public class SmallestMultiple
{
    public static int Smallest()
    {
        var number = 1;
        while (true)
        {
            for (var i = 1; i <= 20; i++)
            {
                if (number % i == 0)
                {
                }
                else
                {
                    number ++;
                    i = 1;
                }
            }
            break;
        }
        return number;
    }
}