namespace MathProblems;

public class LargestProductInAGrid
{
    public static List<int[]> ReadTheGrid(string grid)
    {
        var result = new List<int[]>();
        var elems = grid.Split(" ").ToList();
        var endOfGrid = false;
        while (endOfGrid == false)
        {
            var line = new int[20];

            for (int i = 0; i < 20; i++)
            {
                if (elems[i] != " ")
                    line[i] = int.Parse(elems[i]);
            }
            result.Add(line);
            elems.RemoveRange(0,20);

            if (result.Count == 20)
            {
                endOfGrid = true;
            }
        }
        return result;
    }

    private static int LargestInRow(int[] input)
    {
        int max = 0;
        for (var i = 0; i < input.Length - 4; i++)
        {
            var sub = new List<int>();
            for (int j = i; j < i + 4; j++)
                sub.Add(input[j]);

            if (sub.Contains(0))
                continue;
            var result = sub.Aggregate(1, (current, elem) => current * elem);
            if (result > max)
                max = result;
        }

        return max;
    }

    public static int LargestInAllRows(List<int[]> input)
    {
        int max = 0;
        foreach (var elem in input)
        {
             var result = LargestInRow(elem);
             if (result > max)
             {
                 max = result;
             }
        }
        return max;
    }

    private static List<int[]> ReadingBycolumns(List<int[]> grid)
    {
        var result = new List<int[]>();
        for (int listNum = 0; listNum < 20; listNum++)
        {
            var column = new int[20];
            for (int columnMaker = 0; columnMaker < 20; columnMaker++)
            {
                column[columnMaker] = grid[columnMaker][listNum];
            }
            result.Add(column);
        }

        return result;
    }

    public static int LargestInAllColumns(List<int[]> grid)
    {
        var reverseGrid = ReadingBycolumns(grid);
        return LargestInAllRows(reverseGrid);
    }

    public static void ReadingByDiagonalsFromRight(List<int[]> grid)
    { 
        int row = 20;
        int column = 20;
        
        for (int line = 1;
             line <= (row + column - 1);
             line++)
        {

            int startColumn = Math.Max(0, line - row);

            int count = Math.Min(line, Math.Min((column - startColumn), row));

            // Print elements of this line
            for (int j = 0; j < count; j++)
                Console.Write(grid[Math.Min(row, line) - j - 1][startColumn + j] + " ");

            Console.WriteLine();
        }

    }
    public static void ReadingByDiagonalsFromLeft(List<int[]> grid)
    {
        int row = 20;
        int column = 20;

        for (int line = 1;
             line <= (row + column - 1);
             line++)
        {

            int startColumn = Math.Max(0, line - row);

            int count = Math.Min(line, Math.Min((column - startColumn), row));

            // Print elements of this line
            for (int j = 0; j < count; j++)
                Console.Write(grid[Math.Min(row, line) - j - 1][startColumn + j] + " ");

            Console.WriteLine();
        }
    }

    public static List<List<int>> Testing(List<int[]> grid)
    {
        List<List<int>> result = new();
        for (int i = 19; i >= 0; i--)
        {
            List<int> line = new List<int>();
            for (int j = 0; j < 20 - i; j++)
            {
                if (i + j != 19)
                {
                    int temp = i;
                    temp++;
                    line.Add(grid[temp][j]);
                }
                else
                {
                    line.Add(grid[i][j]);
                }
                //int temp = i;
                
                //temp++;
                //i++;
            }
            result.Add(line);
        }

        return result;
    }
}