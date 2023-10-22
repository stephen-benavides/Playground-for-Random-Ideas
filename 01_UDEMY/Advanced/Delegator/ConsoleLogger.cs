using System;
using System.Globalization;

namespace Advanced.Delegator
{
    public class ConsoleLogger //: ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine(DateTime.Now.ToString(CultureInfo.InvariantCulture) + ": " + message);
        }

        public void LogError(string message)
        {
            Console.WriteLine(DateTime.Now.ToString(CultureInfo.InvariantCulture) + ": " + message);
        }

    }
}