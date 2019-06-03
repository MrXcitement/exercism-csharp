using System;
using System.Collections.Generic;

// Determine if a sentence is a pangram.
// A pangram (Greek: παν γράμμα, pan gramma, "every letter") is a sentence using
// every letter of the alphabet at least once.

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        HashSet<char> letterFound = new HashSet<char>();
        foreach (var letter in input ) {
            if (char.IsLetter(letter)) {
                letterFound.Add(letter);
            }
        }
        return letterFound.Count == 26;
    }
}
