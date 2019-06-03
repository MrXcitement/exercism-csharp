using System;
using System.Collections.Generic;

// Determine if a sentence is a pangram.
// A pangram (Greek: παν γράμμα, pan gramma, "every letter") is a sentence using
// every letter of the alphabet at least once.

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var hashSet = new HashSet<char>(input.ToLower());
        return hashSet.IsSupersetOf("abcdefghijklmnopqrstuvwxyz");
    }
}
