using HangmanConsoleSelf.Util;
using NUnit.Framework;

namespace HangmanConsoleSelf_TEST
{
    public class FileAccessorTest
    {
        private FileAccessor fileAccessor;

        [SetUp]
        public void Setup()
        {
            fileAccessor = new FileAccessor(@"C:\Users\stepb\source\repos\HangmanConsoleSelf\HangmanConsoleSelf_TEST\testWordBank.txt");
        }

        [Test]
        public void GetUpperBounds_returnsUpperBounds()
        {
            int expectedUpperBounds = 3;
            int actualUppeBounds = fileAccessor.GetUpperBounds();

            Assert.AreEqual(expectedUpperBounds, actualUppeBounds);
        }
    }
}