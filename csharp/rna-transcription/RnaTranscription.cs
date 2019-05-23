using System;
// Given a DNA strand, return its RNA complement (per RNA transcription).
//
// Both DNA and RNA strands are a sequence of nucleotides.
//
// The four nucleotides found in DNA are adenine (A), cytosine (C), guanine (G) and thymine (T).
//
// The four nucleotides found in RNA are adenine (A), cytosine (C), guanine (G) and uracil (U).
//
// Given a DNA strand, its transcribed RNA strand is formed by replacing each nucleotide with its complement:
//
//     G -> C
//     C -> G
//     T -> A
//     A -> U

public static class RnaTranscription
{
    private static char? RnaComplement( char nucleotide)
    {
        switch ( nucleotide ) {
            case 'C': return 'G';
            case 'G': return 'C';
            case 'T': return 'A';
            case 'A': return 'U';
        }
        return null;
    }
    public static string ToRna(string dnaStrand)
    {
        string rnaStrand = "";
        foreach ( char nucleotide in dnaStrand )
        {
            rnaStrand += RnaComplement(nucleotide);
        }
        return rnaStrand;
    }
}
