using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        var pythagoreanTriples = new List<(int, int, int)>();

        for (int i = 1; i < sum / 3; i++)
            for (int j = i + 1; j < sum / 2; j++)
            {
                int k = sum - i - j;
                if (IsPitagorean(i, j, k))
                    pythagoreanTriples.Add((i, j, k));
            }
        return pythagoreanTriples;
    }

    private static bool IsPitagorean(int a, int b, int c) => PowerOfTwo(a) + PowerOfTwo(b) == PowerOfTwo(c);

    private static int PowerOfTwo(int num) => num * num;
}
