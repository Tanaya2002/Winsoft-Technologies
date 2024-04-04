// Q2: Given a string s, find the length of the longest substring without repeating characters.

using System;
using System.Collections.Generic;

class Program
{
    static int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

        for (int i = 0, j = 0; j < n; j++)
        {
            if (charIndexMap.ContainsKey(s[j]))
            {
                i = Math.Max(charIndexMap[s[j]], i);
            }

            maxLength = Math.Max(maxLength, j - i + 1);
            charIndexMap[s[j]] = j + 1;
        }

        return maxLength;
    }

    static void Main()
    {
        string[] testCases = { "abcabcbb", "bbbbb", "pwwkew" };
        foreach (string testCase in testCases)
        {
            Console.WriteLine($"Input: {testCase}");
            Console.WriteLine($"Output: {LengthOfLongestSubstring(testCase)}");
            Console.WriteLine();
        }
    }
}
