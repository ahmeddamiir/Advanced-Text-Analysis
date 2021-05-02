using System.Collections.Generic;

namespace MainProject
{
    internal static partial class Program
    {
        private static class AdvancedAnalysis
        {
            // Method to get the most frequently used word
            public static string MostFrequentlyUsedWord(string text)
            {
                // Splitting text by a space and store each word in "words" array of strings
                var words = text.Split(' ');
                
                var wordsDatabase = new Dictionary<string, int>();
                
                // Filling the dictionary with words and the frequency of each
                foreach (var word in words)
                {
                    wordsDatabase.TryGetValue(word, out var value);
                    if (value == 0)
                    {
                        wordsDatabase.Add(word, 1);
                    }
                    else 
                    {
                        wordsDatabase[word] = value + 1;
                    }
                }
                
                var maximum = 0;
                var mostCommon = "";
                // Iterating over each word's frequency
                foreach (var word in wordsDatabase.Keys) 
                {
                    if (wordsDatabase[word] > maximum) 
                    {
                        maximum = wordsDatabase[word];
                        mostCommon = word;
                    }
                }
                // Returning the highest word's frequency among all words the dictionary
                return mostCommon;
            }
        }
    }
}