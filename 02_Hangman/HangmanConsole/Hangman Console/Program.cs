using System;
using System.IO;

namespace Hangman_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            HangmanGame game = new HangmanGame(new FileAccessor("wordbank.txt"), new ConsoleOperations());
            game.Play();
        }

    }
}