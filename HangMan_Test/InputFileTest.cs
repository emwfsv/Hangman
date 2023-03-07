using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HangMan_Test
{
    [TestClass]
    public class UnitTestInputFile
    {
        [TestMethod]
        public void InputFile_NoDuplicates()
        {
            //Test so that the input file "Ord.txt" does not contain any duplicates.
            bool haveDuplicates;
            try
            {
                //Load the file and add it to a string array
                var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"InputFiles\Ord.txt");
                var words = File.ReadAllLines(path);

                //Check the array for duplicates
                haveDuplicates = words.Distinct().Count() != words.Count();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            //Check the outcome
            Assert.AreEqual(false, haveDuplicates);
        }

        [TestMethod]
        public void InputFile_DuplicatesExists()
        {
            //Test so that the input file "Ord.txt" is readout and one extra word is inserted which IS a duplicate.
            //This we would find!!
            bool haveDuplicates;
            try
            {
                //Load the file and add it to a string array
                var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"InputFiles\Ord.txt");
                var words = File.ReadAllLines(path);
                var corruptWords = new string[0];

                //Lets include a duplicate in the file!!!
                corruptWords = words;
                corruptWords[1] = words[0];

                //Check the array for duplicates
                haveDuplicates = corruptWords.Distinct().Count() != corruptWords.Count();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            //Check the outcome. Should have duplicates now!!!
            Assert.AreEqual(true, haveDuplicates);
        }
    }
}
