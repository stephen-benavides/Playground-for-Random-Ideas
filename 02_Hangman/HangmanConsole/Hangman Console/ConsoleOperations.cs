using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman_Console
{
    public class ConsoleOperations : IConsoleOperations
    {
        public void Clear()
        {
            Console.Clear();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string toPrint)
        {
            Console.Write(toPrint);
        }

        public void WriteLine(string toPrint)
        {
            Console.WriteLine(toPrint);
        }
    }
}
