using HangmanConsoleSelf.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanConsoleSelf.Util
{
    public class ConsoleOperationsImpl : IConsoleOperations
    {
        public void Clear()
        {
            System.Console.Clear();
        }

        public string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public void Write(string toPrint)
        {
            System.Console.Write(toPrint);
        }

        public void WriteLine(string toPrint)
        {
            System.Console.WriteLine();
        }
    }
}
