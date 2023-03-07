using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace HangMan.Methods
{
    public class WordLoader
    {
        //Class used for open the file with all the words, loading the file and then randomized selecting a word from that list.
        public string RandomizedWord()
        {
            try
            {
                //Load the file and add it to a string array
                var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    @"InputFiles\Ord.txt");

                //Read all inputs
                var wordArray = File.ReadAllLines(path);

                //Get a random number for the selecteion of the word to be used.
                var randomNumber = new Random().Next(wordArray.Length - 1);

                //Return it...
                return wordArray[randomNumber];
            }
            catch (Exception)
            {
                //Ooops Something went wrong...
                return "UNKNOWN";
            }
        }

        public string SecretWordCreator(string inputWord)
        {
            //Return the number of questionmarks to the GUI so that the user could not see it....
            return new string('?', inputWord.Length);
        }

        public bool CheckGuessForMatch(string guessedLetter, string secretWord)
        {
            return secretWord.Contains(guessedLetter);
        }

        public string ReplaceSecretwordWithLetter(string guessedLetter, string secretWord, string userGuessedWord)
        {
            try
            {
                if (string.IsNullOrEmpty(guessedLetter) || guessedLetter.Length > 1)
                    return userGuessedWord;

                //userGuessedWord = the current word with all correct letters....
                var indexes = Regex.Matches(secretWord, guessedLetter).Cast<Match>().Select(m => m.Index).ToList();

                foreach (var index in indexes)
                {
                    userGuessedWord = userGuessedWord.Remove(index, 1).Insert(index, guessedLetter);
                }
            }
            catch
            { }

            return userGuessedWord;
        }
    }
}
