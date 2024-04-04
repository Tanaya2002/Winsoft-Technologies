// Q1: Replace each array element by its corresponding rank. Given an array of distinct integers, replace each array element by its corresponding rank in the array.The minimum array element has the rank 1; the second minimum element has a rank of 2, and so on… 

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 10, 8, 15, 12, 6, 20, 1 };
        int[] sortedArray = array.ToArray();

        Array.Sort(sortedArray);

        var ranks = sortedArray.Select((value, index) => new { value, index })
                                .ToDictionary(pair => pair.value, pair => pair.index + 1);

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = ranks[array[i]];
        }

        Console.WriteLine("Output: {" + string.Join(", ", array) + "}");
    }
}
