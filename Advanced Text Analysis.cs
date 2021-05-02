// .. BONUS:
// Display the longest word
// Display the longest sentence

using System;
using System.IO;

namespace MainProject
{
    internal static partial class Program
    {
        public static void Main()
        { 
            // 2 variables to store path of file and txt in that file
            string path, text;
            
            // Keep prompting the user for the path if he/she doesn't co-operate
            do
            {
                Console.Write("The file's path: ");
                path = Console.ReadLine();
            
            }
            while (string.IsNullOrEmpty(path?.Trim()));
            
            // Check if the path is valid or invalid
            try
            {
                // Store the text in the file if the path is VALID
                text = File.ReadAllText(path);
            }
            catch (Exception)
            {
                // Display useful messages and exit if the path is INVALID
                Console.WriteLine("FILE DOES NOT EXIST !");
                Console.WriteLine("-> please enter the file's full path");
                return;
            }
            
            // Store the number of letters/words/sentences in text in their variables
            var numberOfLetters = BasicAnalysis.CharacterCounter(text.Trim());
            var numberOfWords = BasicAnalysis.WordCounter(text.Trim());
            var numberOfSentences = BasicAnalysis.SentenceCounter(text.Trim());
            
            // Store the average number of letters\sentences per 100 words
            var averageNumberOfLetters = (int) Math.Round(ReadabilityAnalysis.LettersAverageNumber(numberOfLetters, numberOfWords));
            var averageNumberOfSentences = (int) Math.Round(ReadabilityAnalysis.SentencesAverageNumber(numberOfSentences, numberOfWords));
            
            // Populate the array with the number of times the alphabets have shown in text 
            for (var i = 0; i < Globals.AlphabetArray.Length; i++)
            {
                Globals.AlphabetFrequencies[i] = FrequencyAnalysis.Frequency(text, Globals.AlphabetArray[i]);
            }
            
            // Store the frequency of the letter that has appeared in text only
            /* It's max size is 26 because it won't store more than the alphabets */
            var frequencies = new int[Globals.Alphabet];
            // Store frequency's percentage of letter that has appeared in text
            /* It's with max size 26 because it won't store more than the alphabets */
            var frequenciesPercentage = new float[Globals.Alphabet];
            
            // Iterate over the array stored the frequencies of all alphabets
            for (var i = 0; i < Globals.AlphabetFrequencies.Length; i++)
            {
                // Check if the letter has appeared at least one in text
                if (Globals.AlphabetFrequencies[i] > 0)
                {
                    // Populate "frequencies" array with that letter's frequency
                    frequencies[i] = Globals.AlphabetFrequencies[i];
                    // Populate "frequenciesPercentage" array with that letter's frequency percentage 
                    frequenciesPercentage[i] = FrequencyAnalysis.FrequencyPercentage(text, Globals.AlphabetArray[i]);
                    
                    // Print the frequency, frequency percentage and histogram to console
                    Console.Write("Frequency of {0}: {1:F}%\t", Globals.AlphabetArray[i], frequenciesPercentage[i]);
                    FrequencyAnalysis.HistogramDrawer(text, Globals.AlphabetArray[i]);
                    Console.WriteLine();
                }
            }
            // Display the readability of the text
            ReadabilityAnalysis.Readability(averageNumberOfLetters, averageNumberOfSentences);
            // Display the Most frequently used word
            Console.WriteLine("The most frequently used word is: " + AdvancedAnalysis.MostFrequentlyUsedWord(text));
        }
    }
}