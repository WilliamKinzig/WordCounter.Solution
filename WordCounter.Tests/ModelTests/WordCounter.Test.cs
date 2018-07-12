using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class CounterTest
    {
        [TestMethod]
        public void GetStringToCount_ReturnStringsWorkingWith_String()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("the","the yellow bus");

            //Act
            string toCount = newRepeatCounter.GetWordToCount();
            string toScan = newRepeatCounter.GetParaGraph();

            //Assert
            Assert.AreEqual(toScan, "the yellow bus");
        }

        [TestMethod]
        public void GetIndexFromArray_ReturnIndex_String()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("dog", "cat and dog");

            //Act
            string paragraph = newRepeatCounter.GetParaGraph();
            string[] result = newRepeatCounter.StringToArray();
            string[] blah = paragraph.Split(' ');

            //Assert
            CollectionAssert.AreEqual(blah, result);
        }

        [TestMethod]
        public void RunNoArgConstructor_ReturnTheWordCount_Int()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter();

            //Act
            newRepeatCounter.SetWordToCount("blue,");
            newRepeatCounter.SetParagraph("the sky is blue, the oceans is blue, the dog is not blue");
            string paragraph = newRepeatCounter.GetParaGraph();
            string word = newRepeatCounter.GetWordToCount();
            string[] test = newRepeatCounter.StringToArray();
            int result = newRepeatCounter.GetResults();

            //Assert
            Assert.AreEqual(result,2);
        }

        [TestMethod]
        public void GetTheWordCount_ReturnTheWordCount_Int()
        {

            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("cat", "cat and cat");
            string paragraph = newRepeatCounter.GetParaGraph();
            string word = newRepeatCounter.GetWordToCount();
            string[] test = newRepeatCounter.StringToArray();

            //Act
            int result = newRepeatCounter.GetResults();

            //Assert
            Assert.AreEqual(result,2);
        }
    }
}
