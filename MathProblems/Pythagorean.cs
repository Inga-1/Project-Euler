namespace MathProblems;

public class Pythagorean
{
    public static void Triplet()
    {

        var multiple = 1;
        const int sum = 1000;
        for (var a = 1; a <= sum; a++)
        {
            for (var b = 1; b <= sum; b++)
            {
                var c = sum - a - b;
                if (c > 0 && a + b + c == sum && a * a + b * b == c * c)
                    multiple = (int)(a * b * c);
            }
        }
        Console.WriteLine(multiple);
    }
}