// Basic Analysis class is Responsible for computer how many words, letters and sentences in texts

namespace MainProject
{
    internal static partial class Program
    {
        private static class BasicAnalysis
        {
            // Static variables to store the number of chars, words and sentences
            private static int _characterCounter, _wordCounter, _sentenceCounter;
            
            
            // Method returns integer number of characters in text
            public static int CharacterCounter(string text)
            {
                // Iterate over the text's characters
                foreach (var c in text)
                {
                    // Check if the current character is a letter
                    if (char.IsLetter(c))
                        // Increment character counter by 1
                        _characterCounter++;
                }

                // return the number of characters in text
                return _characterCounter;
            }

            // Method returns integer number of words in text
            public static int WordCounter(string text)
            {
                // Iterate over the text's characters
                for (var i = 0; i < text.Length; i++)
                {
                    // Check if the current character is a space and the next one is non-space
                    if (char.IsWhiteSpace(text[i]) && (char.IsLetterOrDigit(text[i+1]) || char.IsPunctuation(text[i+1])))
                    {
                        // Increment word counter by 1
                        _wordCounter++;
                    }
                }
                
                // Return the number of words + 1 (as 1 is the last word)
                return ++_wordCounter;
            }

            // Method returns integer number of sentences in text
            public static int SentenceCounter(string text)
            {
                // Iterate over the text's characters
                foreach (var c in text)
                {
                    // Check if the current character is a punctation
                    if (char.IsPunctuation(c))
                    {
                        // Increment the sentence counter by 1
                        _sentenceCounter++;
                    }
                }
                
                // return the number of sentence in text
                return _sentenceCounter;
            }
        }
    }
}