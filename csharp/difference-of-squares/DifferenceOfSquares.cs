using System;
using System.Collections.Generic;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max) =>
        Square(NatualNumbers(max).Sum());

    public static int CalculateSumOfSquares(int max) =>
        NatualNumbers(max).Sum(Square);

    public static int CalculateDifferenceOfSquares(int max) =>
        CalculateSquareOfSum(max) - CalculateSumOfSquares(max);

    private static int Square(int number) => number * number;
    private static IEnumerable<int> NatualNumbers (int max) => Enumerable.Range(1, max);
}
