using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanConsoleSelf.Console
{
    interface IConsoleOperations
    {
        void Clear();
        String ReadLine();
        void Write(String toPrint);
        void WriteLine(String toPrint);
    }
}
