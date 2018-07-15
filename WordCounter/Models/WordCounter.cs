using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _wordToCount;
        private string _paragraphToScan;
        private string[] _arrayFromParagraph;
        private int _counter;

        /**
         * Class constructors
         */
        public RepeatCounter()
        {

        }

        public RepeatCounter(string searchFor, string searchIn)
        {
            _wordToCount = searchFor;
            _paragraphToScan = searchIn;
        }

        public string GetWordToCount()
        {
            return _wordToCount;
        }
        public void SetWordToCount(string newWord)
        {
            _wordToCount = newWord;
        }
        public void SetParagraph(string stringIn)
        {
            _paragraphToScan = stringIn;
        }
        public string GetParaGraph()
        {
            return _paragraphToScan;
        }

        public string RemovePunctuation(string stringIn)
        {
          // string s = "sxrdct?fvzguh,bij.";
          var sb = new StringBuilder();

          foreach (char c in stringIn)
          {
             if (!char.IsPunctuation(c))
                sb.Append(c);
          }

          string stringOut = sb.ToString();

          return stringOut;
        }


        /**
         * This method takes in a string sentence/paragraph and splits it into a string array.
         */
        public string[] StringToArray()
        {
            this._arrayFromParagraph = this._paragraphToScan.Split(' ');
            return this._arrayFromParagraph;
        }

        /**
         * This method searches through a given string array and counts occurences of a specified string
         */
        public int GetResults()
        {
            int count = 0;

            string[] scanThisArray = this._paragraphToScan.Split(' ');
            //string[] scanThisArray = StringToArray();

            for(int i=0; i < scanThisArray.Length; i++)
            {
                if(scanThisArray[i] == this._wordToCount)
                {
                    count += 1;
                }
                else
                {
                    count += 0;
                }
            }
            this._counter = count;
            return this._counter;
        }
    }

    /**
     * Main method
     * Searches for the number of times a word appears in a sentence or paragraph
     */
    // public class Program
    // {
    //     public static void Main()
    //     {
    //         /*** TESTING TESTING 123 ***/
    //         //int count;
    //
    //         // //Arrange
    //         // RepeatCounter stringCheckObject = new RepeatCounter("cat", "cat cat cat");
    //         // //Act
    //         // stringCheckObject.StringToArray();
    //         // count = stringCheckObject.GetResults();
    //         // //Assert
    //         // Console.WriteLine(count); //output: 3
    //         //
    //         // //Arrange
    //         // RepeatCounter stringCheckObject2 = new RepeatCounter("cat", "cat dog cat");
    //         // //Act
    //         // stringCheckObject2.StringToArray();
    //         // count = stringCheckObject2.GetResults();
    //         // //Assert
    //         // Console.WriteLine(count); //output: 2
    //         //
    //         // //Arrange
    //         // RepeatCounter stringCheckObject3 = new RepeatCounter();
    //         // string wordy = "cow";
    //         // string sentence = "The cow is big, the cow taste great";
    //         // //Act
    //         // stringCheckObject3.SetWordToCount(wordy);
    //         // stringCheckObject3.SetParagraph(sentence);
    //         // stringCheckObject3.StringToArray();
    //         // count = stringCheckObject3.GetResults();
    //         // //Assert
    //         // Console.WriteLine(count); //output: 2


    //         //Arrange
    //         RepeatCounter userWordRepeatCounter = new RepeatCounter();
    //         Console.WriteLine("Enter a sentence or paragraph to scan.");
    //         string userStringToScan = Console.ReadLine();
    //         Console.WriteLine("Enter a word to count the occurrence of.");
    //         string userWordIn = Console.ReadLine();
    //         //Act
    //         userWordRepeatCounter.SetParagraph(userStringToScan);
    //         userWordRepeatCounter.SetWordToCount(userWordIn);
    //         int numberOfOccurences = userWordRepeatCounter.GetResults();
    //         //Assert
    //         Console.WriteLine("There are " + numberOfOccurences + " occurences of " + userWordIn + ".");
    //     }
    // }
}
