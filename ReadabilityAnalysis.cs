using System;

namespace MainProject
{
    /*
     * Coleman-Liau index:
     * index = 0.0588 * L - 0.296 * S - 15.8
     * Here, 'L' is the average number of letters per 100 words in the text, and 'S' is the average number of sentences per 100 words in the text.
     * L = (Number of letter x 100 words) / Number of words
     */
    internal static partial class Program
    {
        private static class ReadabilityAnalysis
        {
            // Method computes the average number of letters per 100 words
            public static float LettersAverageNumber(int numberOfLetters, int numberOfWords)
            {
                var lettersAverage = numberOfLetters / (float) numberOfWords * 100;
                return lettersAverage;
            }

            // Method computes the average number of sentences per 100 words
            public static float SentencesAverageNumber(int numberOfSentences, int numberOfWords)
            {
                var sentencesAverage = numberOfSentences / (float) numberOfWords * 100;
                return sentencesAverage;
            }
            
            // Method computes the readability index of text
            public static void Readability(int averageNumberOfLetters, int averageNumberOfSentences)
            {
                // Defining the COLEMAN-LIAU INDEX formula and storing the output in decimal form
                var actualIndex = 0.0588 * averageNumberOfLetters - 0.296 * averageNumberOfSentences - 15.8;

                // Rounding the index, Treating it as an integer and storing it in the actual index that we're going to use
                var clIndex = (int) Math.Round(actualIndex);
                
                // Checking if the index is less than 1
                if (clIndex < 1)
                {
                    Console.WriteLine("-> This Text Is Readable For Whoever Before Grade 1");
                }
                // Checking if the index is greater than 16
                else if (clIndex >= 16)
                {
                    Console.WriteLine("-> This Text Is Readable For Whoever After Grade 16");
                }
                // Display the readability of the text
                else
                {
                    Console.WriteLine("-> This Text Is Readable For Whoever In Grade " + clIndex);
                }
            }
        }
    }
}
