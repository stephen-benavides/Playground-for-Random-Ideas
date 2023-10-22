using HangmanConsoleSelf.Console;
using HangmanConsoleSelf.Util;
using HangmanConsoleSelf.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanConsoleSelf.Source
{
    class HangmanGame
    {
        private string secretWord;
        public int WrongGuesses { get; set; } = 0;
        private FileAccessor fileAccessor;
        public List<string> SecretWordDisplay { get; set; }
        private IConsoleOperations consoleOperations;

        public HangmanGame(FileAccessor fileAccessor, IConsoleOperations consoleOperations)
        {
            this.fileAccessor = fileAccessor;
            this.consoleOperations = consoleOperations;
            secretWord = this.fileAccessor.GetRandomLine();
            InitializeSecretWord();
        }
        public void Play()
        {
            while (!IsWordGuessed() && WrongGuesses < 10)
            {
                consoleOperations.Clear();
                HangmanGallows.DrawGallow(WrongGuesses);
                DisplaySecretWord();
                consoleOperations.WriteLine("Guess A Letter: ");
                WrongGuesses += ProcessGuess(consoleOperations.ReadLine());
            }

            consoleOperations.Clear();
            HangmanGallows.DrawGallow(WrongGuesses);
            DisplaySecretWord();

        }

        public int ProcessGuess(string guess)
        {
            int wrongGuess = 1;
            for (int n = 0; n < secretWord.Length; n++)
            {
                if (secretWord[n].ToString() == guess)
                {
                    SecretWordDisplay[n] = guess;
                    wrongGuess = 0;
                }
            }
            return wrongGuess;
        }

        private void DisplaySecretWord()
        {
            SecretWordDisplay.ForEach(letter => consoleOperations.Write(letter));
            consoleOperations.WriteLine("");
        }

        private void InitializeSecretWord()
        {
            SecretWordDisplay = new List<string>();
            for (int n = 0; n < secretWord.Length; n++)
            {
                SecretWordDisplay.Add(" _ ");
            }
        }

        public bool IsWordGuessed()
        {
            return SecretWordDisplay.IndexOf(" _ ") >= 0 ? false : true;
        }
    }
}
