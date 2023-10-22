using Hangman_Console;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanTests
{
    public class HangmanGameTests
    {
        private HangmanGame hangmanGame;
        private Mock<FileAccessor> mockFileAccessor;
        private Mock<IConsoleOperations> mockConsole;

        [SetUp]
        public void Setup()
        {
            mockFileAccessor = new Mock<FileAccessor>("");
            mockFileAccessor.Setup(mFA => mFA.GetRandomLine()).Returns("sasquach");
            mockConsole = new Mock<IConsoleOperations>();
            hangmanGame = new HangmanGame(mockFileAccessor.Object,mockConsole.Object);
        }

        [Test]
        public void InitializeWordDisplay_CreatesSecretWordAsBlanks()
        {
            List<string> expectedWordDisplay = new List<string> { " _ ", " _ ", " _ ", " _ ", " _ ", " _ ", " _ ", " _ " };

            Assert.AreEqual(expectedWordDisplay, hangmanGame.SecretWordDisplay);
        }

        [TestCase(new[] { "a" }, " _ a _  _  _ a _  _ ", 0)]//correct
        [TestCase(new[] { "x", "t" }, " _  _  _  _  _  _  _  _ ", 2)]//incorrect
        [Test]
        public void ProcessGuess_processesGuessCorrectly(string[] guess, string expectedDisplay, int expectedWrongGuesses)
        {
            Assert.AreEqual(0, hangmanGame.WrongGuesses);

            int actualWrongGuesses = 0;
              
            foreach(string letter in guess)
            {
                actualWrongGuesses += hangmanGame.ProcessGuess(letter);
            }
               
            Assert.AreEqual(expectedWrongGuesses, actualWrongGuesses);
            Assert.AreEqual(expectedDisplay,String.Join("",hangmanGame.SecretWordDisplay));

        }

        [TestCase(new[] { "s", "a", "u", "q", "c", "h"}, true)]
        [TestCase(new[] { "s", "a", "x", "t", "w", "z", "v", "b", "m", "o", "l", "y" }, false)]
        [Test]
        public void Play_PlaysGameTillWinOrLoss(string[] guesses, bool isWin)
        {
            int index = 0;
            mockConsole.Setup(c => c.ReadLine())
                .Returns(()=>guesses[index++]);

            hangmanGame.Play();

            Assert.AreEqual(isWin, hangmanGame.IsWordGuessed());
        }


    }
}
