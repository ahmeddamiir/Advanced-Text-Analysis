namespace MainProject
{
    // Declaring global variables
    internal static class Globals
    {
        // Declaring number of english alphabets' constant
        public const int Alphabet = 26;
        
        // Declaring constant array of characters of English alphabets
        public static readonly char[] AlphabetArray = {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
        };
        
        // Declare array of frequencies & array of frequencies percentage
        public static readonly int[] AlphabetFrequencies = new int[Alphabet];
    }
}