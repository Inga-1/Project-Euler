namespace MathProblems;

public class Palindrome
{
    public static int IsPalindrome()
    {
        List<int> list = new();
        for (var i = 999; i > 100; i--)
        {
            for (var j = 999; j > 100; j--)
            {
                var result = i * j;
                var resAsString = result.ToString();
                if (resAsString == IsReverse(resAsString))
                {
                    list.Add(result);
                }
            }
        }

        var biggest = list.Max();
        return biggest;
    }

    public static string IsReverse(string word)
    {
        var wordReverse = new char[word.Length];
        for (int i = 0, j = word.Length - 1; i <= j; i++, j--)
        {
            wordReverse[i] = word[j];
            wordReverse[j] = word[i];
        }
        return new string(wordReverse);

    }

    public static void PalindromeWithFactors()
    {
        Dictionary<int, (int, int)> dict = new(); 
        List<int> ListOfResults = new();
        List<(int, int)> factors = new();
        for (var i = 999; i > 100; i--)
        {
            for (var j = 999; j > 100; j--)
            {
                var result = i * j;
                var resAsString = result.ToString();
                if (resAsString == IsReverse(resAsString))
                {
                    ListOfResults.Add(result);
                    factors.Add((i, j));
                }
            }
        }

        for (var i = 0; i < ListOfResults.Count; i++)
        {
            if (!dict.ContainsKey(ListOfResults[i]))
                dict.Add(ListOfResults[i], factors[i]);
        }
        var biggest = ListOfResults.Max();
        var factoring = dict[biggest];

        Console.WriteLine("Biggest palindrome with 3 digit numbers is {0}, while the factors are {1}", biggest, factoring);

    }
}

