using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangMan.Methods;

namespace HangMan_Test
{
    [TestClass]
    public class UnitTestWordLoaderClass
    {
        private readonly WordLoader _word = new WordLoader();

        [TestMethod]
        public void RandomizedWord_NotNull()
        {
            //Test so that the returned word is not Null
            Assert.IsNotNull(_word.RandomizedWord());
        }

        [TestMethod]
        public void RandomizedWord_isRandomized()
        {
            //Test so that the returned word is randomly choosen.
            //Might fail since it is randomly done from the same list over and over...
            //Therefor a for loop is implemented before the test... done 3 times.
            var numberOfLoops = 3;
            var wordOne = "";
            var wordTwo = "";

            for (var i = 0; i < numberOfLoops; i++)
            {
                wordOne = _word.RandomizedWord();
                Thread.Sleep(123);
                wordTwo = _word.RandomizedWord();

                //If the words are not equal, break the loop.
                //Otherwise run it again.
                if (wordOne != wordTwo)
                {
                    break;
                }
            }

            Assert.AreNotEqual<string>(wordOne, wordTwo); 
        }

        [TestMethod]
        public void QuestionMark_Check()
        {
            //Test so that the returned number of questionmarks are equal to the number of characters in the string
            //Variables
            var secretWord = "TESTING123";
            var questionsMarks = "";

            //Will convert the input word to an equal length string of question marks
            questionsMarks = _word.SecretWordCreator(secretWord);

            //The number of question marks should be equal
            Assert.AreEqual(questionsMarks, "??????????");
        }

        [TestMethod]
        public void CheckForLetterInWord_Match()
        {
            //Test if the letter exists in the secretWord
            //Variables
            var secretWord = "TESTING123";

            //Will convert the input word to an equal length string of question marks
            var exists = _word.CheckGuessForMatch("E", secretWord);

            //The number of question marks should be equal
            Assert.AreEqual(exists, true);
        }

        [TestMethod]
        public void CheckForLetterInWord_NoMatch()
        {
            //Test if the letter exists in the secretWord
            //Variables
            var secretWord = "TESTING123";

            //Will convert the input word to an equal length string of question marks
            var exists = _word.CheckGuessForMatch("F", secretWord);

            //The number of question marks should be equal
            Assert.AreEqual(exists, false);
        }

    }
}
