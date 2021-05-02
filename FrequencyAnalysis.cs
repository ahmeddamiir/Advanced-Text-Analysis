using System;

namespace MainProject
{
    internal static partial class Program
    {
        private static class FrequencyAnalysis
        {
            // A method gets a specific character's frequency in text
            public static int Frequency(string text, char character)
            {
                // Set the characters' counter to zero 
                var specificCharacterCounter = 0;
                
                // Iterate over each element of the text
                foreach (var c in text)
                {
                    // Whenever the indexed char. matches the char argument 
                    if (c == char.ToLower(character) || c == char.ToUpper(character))
                    {
                        // Increment the counter by 1
                        specificCharacterCounter++;
                    }
                }

                // Return the number of the character
                return specificCharacterCounter;
            }
            
            // A method gets each character's frequency percentage in text
            public static float FrequencyPercentage(string text, char character)
            {
                 // Set the frequency's percentage to zero 
                 float frequencyPercentage = 0;
                 
                 // Iterate over the array of alphabets' frequencies
                 foreach (var letterFrequency in Globals.AlphabetFrequencies)
                 {
                     // Check if the letter appeared at least once in text
                     if (letterFrequency > 0)
                     {
                         // Compute it's frequency's percentage where:-
                         /*
                          * frequencyPercentage =
                          
                          *      number of times the character has shown in text
                          * -----------------------------------------------------------   X  100
                          * number of times that all the characters have shown in text
                          
                          */
                         frequencyPercentage = 
                             Frequency(text, character) / (float) text.Length * 100;
                     }
                 }
                 // Return the frequency's percentage of that letter
                 return frequencyPercentage;
            }
            
            // A method draws histogram
            public static void HistogramDrawer(string text, char character)
            {
                // Store the character's frequency
                var characterFrequencyPercentage = FrequencyPercentage(text, character);

                // Iterate up to character's frequency
                for (var i = 0; i < (int) Math.Round(characterFrequencyPercentage); i++)
                {
                    // Print one hash
                    Console.Write("#");
                }
            }
        }
    }
}