namespace MathProblems;

public class SmallestMultiple
{
    public static void Smallest()
    {
        var number = 1;
        while (true)
        {
            for (int i = 1; i <= 20; i++)
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
        Console.WriteLine(number);
    }
}