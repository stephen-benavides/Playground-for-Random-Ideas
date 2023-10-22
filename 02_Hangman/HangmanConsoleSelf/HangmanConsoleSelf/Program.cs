using HangmanConsoleSelf.Source;
using HangmanConsoleSelf.Util;
using System;

namespace HangmanConsoleSelf
{
    class Program
    {
        public static void Main(string[] args)
        {
            HangmanGame game = new HangmanGame(new FileAccessor(@"C:\Users\stepb\source\repos\HangmanConsoleSelf\HangmanConsoleSelf\Util\wordbank.txt"), new ConsoleOperationsImpl());
            game.Play();
        }
    }
}
