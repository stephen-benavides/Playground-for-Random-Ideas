using Hangman_Console;
using NUnit.Framework;

namespace HangmanTests
{
    public class FileAccessorTests
    {
        private FileAccessor fileAccessor;

        [SetUp]
        public void Setup()
        {
            fileAccessor = new FileAccessor("testWordBank.txt");
        }

        [Test]
        public void GetUpperBounds_returnsUpperBounds()
        {
            //SEAT - Setup Exercise Assert Teardown
            //AAA - Arrange Act Assert
            int expectedUpperBounds = 3;
            int actualUpperBounds = fileAccessor.GetUpperBounds();
            Assert.AreEqual(expectedUpperBounds, actualUpperBounds);
        }

        [Test]
        public void GetLine_ReturnsExpectedLine()
        {
            string expected = "two";
            string actual = fileAccessor.GetLine(2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetRandomLine_GetsARandomLine()
        {
            string secretWord = fileAccessor.GetRandomLine();
            Assert.IsTrue(secretWord == "one" || secretWord == "two" || secretWord == "three");
        }
    }
}