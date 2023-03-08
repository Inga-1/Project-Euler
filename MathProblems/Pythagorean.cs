namespace MathProblems;

public class Pythagorean
{
    public static int Triplet()
    {
        var sum = 1000;
        var multiple = 1;
        for (var a = 1; a <= sum; a++)
        {
            for (var b = 1; b <= sum; b++)
            {
                var c = FindCWithSum(a, b, sum);
                if(IsPythagorean(a, b, c))
                    multiple = a*b*c;
            }
        }
        return multiple;
    }

    public static bool IsPythagorean(int a, int b, int c)
    {
        if(a <= 0 || b <= 0)
            return false;
        if (a >= b || b >= c) return false;

        return a * a + b * b == c * c;
    }

    public static int FindC(int a, int b)
    {
        if (a <= 0 || b <= 0) return -1;
        var c = Math.Sqrt(a * a + b * b);
        return (int)c;
    }

    public static int FindCWithSum(int a, int b, int sum)
    {
        return sum - a - b;
    }
}