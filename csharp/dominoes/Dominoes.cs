using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        if (!dominoes.Any())
            return true;
        if (dominoes.Count() == 1)
            return dominoes.First().Item1 == dominoes.First().Item2;

        
        Console.WriteLine(
            string.Join(
                ", ",
                ReorderDominoes(dominoes).Select(t => $"({t.Item1}, {t.Item2})")
            )
        );
        if (ReorderDominoes(dominoes).IsOrder())
            return true;

        return false;
    }

    private static IEnumerable<(int, int)> ReorderDominoes(IEnumerable<(int, int)> dominoes)
    {
        List<(int, int)> orderDominoes = new List<(int, int)>(dominoes);

        for (int i = 1; i < dominoes.Count(); i++)
        {
            if (!orderDominoes.IsOrder())
            {
                (int, int) temp = orderDominoes[i - 1];
                orderDominoes[i - 1] = orderDominoes[i];
                orderDominoes[i] = temp;
            }
        }


        // Console.WriteLine(orderDominoes);
        // foreach (var domino in orderDominoes)
        //     Console.WriteLine(domino);

        // foreach (var domino in dominoes)
        // {
        //     Console.WriteLine(domino);
        //     int last = -1;
        //     if (!orderDominoes.Any())
        //     {
        //         orderDominoes.Add(domino);
        //         last = domino.Item2;
        //         continue;
        //     }
        //     if (last == domino.Item1)
        //         orderDominoes.Add(domino);

        //     last = domino.Item2;
        // }
        return orderDominoes;
    }

    private static bool IsOrder (this IEnumerable<(int, int)> dominoes)
    {
        int last = new int();
        foreach (var domino in dominoes)
        {
            if (domino != dominoes.First() && last != domino.Item1)
                return false;
            last = domino.Item2;
        }
        return dominoes.First().Item1 == dominoes.Last().Item2;
    }
}
