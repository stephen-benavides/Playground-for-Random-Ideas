using System;

namespace Advanced.Delegator
{
    public class DbMigrator
    {
        public delegate void ConsoleLogHandler(string message);
        //private readonly ILogger _logger;

        public DbMigrator()
        {
                
        }

        public void Connect(ConsoleLogHandler _logger)
        {
            Console.WriteLine("Connecting");
            _logger("Connecting to DB");
        }
    }
}