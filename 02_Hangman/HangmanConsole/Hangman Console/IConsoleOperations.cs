using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman_Console
{
    public interface IConsoleOperations
    {
        string ReadLine();
        void Write(string toPrint);
        void WriteLine(string toPrint);
        void Clear();
    }
}
