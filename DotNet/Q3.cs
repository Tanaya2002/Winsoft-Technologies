// Q3:Find non-repeating characters in a string 

using System;
using System.Collections.Generic;

class Program
{
    static List<char> FindNonRepeatingCharacters(string s)
    {
        Dictionary<char, int> charFrequency = new Dictionary<char, int>();

        // Count frequency of characters
        foreach (char c in s)
        {
            if (charFrequency.ContainsKey(c))
            {
                charFrequency[c]++;
            }
            else
            {
                charFrequency[c] = 1;
            }
        }

        // Find non-repeating characters
        List<char> nonRepeatingChars = new List<char>();
        foreach (char c in s)
        {
            if (charFrequency[c] == 1)
            {
                nonRepeatingChars.Add(c);
            }
        }

        return nonRepeatingChars;
    }

    static void Main()
    {
        string[] testCases = { "hello", "goodbye", "programming", "openai" };
        foreach (string testCase in testCases)
        {
            Console.WriteLine($"Input: {testCase}");
            List<char> nonRepeatingChars = FindNonRepeatingCharacters(testCase);
            Console.WriteLine($"Non-repeating characters: {string.Join(", ", nonRepeatingChars)}");
            Console.WriteLine();
        }
    }
}
