using System;

class Program
{
    // Problem 1: Count Words
    static int CountWords(string sentence)
    {
        return sentence.Split(' ').Length;
    }

    // Problem 2: Swap First and Last Characters
    static string FlipEndChars(string str)
    {
        if (str.Length < 2)
            return "Incompatible.";

        if (str[0] == str[^1])
            return "Two's a pair.";

        return str[^1] + str.Substring(1, str.Length - 2) + str[0];
    }

    // Problem 3: Check If String Is in Order
    static bool IsInOrder(string str)
    {
        return str == new string(str.OrderBy(c => c).ToArray());
    }

    // Problem 4: Extract First N Vowels
    static string FirstNVowels(string str, int n)
    {
        string vowels = "aeiou";
        string result = new string(str.Where(c => vowels.Contains(c)).Take(n).ToArray());

        return result.Length == n ? result : "invalid";
    }

    // Problem 5: Shift Letters
    static string Move(string str)
    {
        char[] shifted = str.Select(c => (char)(c + 1)).ToArray();
        return new string(shifted);
    }

