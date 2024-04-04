// Q4:You are given an array of integers. Write a C# program to find the frequency of each unique element in the array and store the results in a dictionary where the key is the element and the value is its frequency.Then, print the elements and their frequencies.

using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, int> FindElementFrequencies(int[] array)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int num in array)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }

        return frequencyMap;
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 1, 2, 3, 1, 2, 1 };
        Dictionary<int, int> frequencyMap = FindElementFrequencies(array);

        Console.WriteLine("Element Frequencies:");
        foreach (var pair in frequencyMap)
        {
            Console.WriteLine($"Element: {pair.Key}, Frequency: {pair.Value}");
        }
    }
}
