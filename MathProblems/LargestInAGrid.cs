using System.ComponentModel.DataAnnotations;

namespace MathProblems;

public class LargestInAGrid
{
    public static void MaxProductByRow(string row)
    {
        var rowElems = row.Split(" ");
        var max = 0;
        var list = (from elem in rowElems where elem != " " select int.Parse(elem)).ToList();

        for (var i = 0; i < list.Count - 4; i++)
        {
            var sub = new List<int>();
            for (int j = i; j < i + 4; j++)
                sub.Add(list[j]);
            
            if (sub.Contains(0))
                continue;
            var result = sub.Aggregate(1, (current, elem) => current * elem);
            if (result > max)
                max = result;
        }
        Console.WriteLine(max);
    }

    public static int[,] ReadTheGrid(string grid)
    {
        var gridElems = grid.Split(" ");
        var gridByRow = new int[20, 20];
        var rowElemCount = 19;
        var rows = 0;
        var columns = 0;

        foreach (var elem in gridElems)
        {
            if (rows > rowElemCount)
            {
                rows = 0;
                columns += 1;
            }

            gridByRow[rows, columns] = int.Parse(elem);
            rows++;
        }

        return gridByRow;
    }
}