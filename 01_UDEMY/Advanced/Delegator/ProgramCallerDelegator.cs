using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Delegator
{
    class ProgramCallerDelegator
    {
        /*static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator();
            ConsoleLogger console = new ConsoleLogger();
            FileLogger file = new FileLogger();

            DbMigrator.ConsoleLogHandler hanldeConsoleLogHandler = console.LogInfo;
            hanldeConsoleLogHandler += file.LogInfo;

            dbMigrator.Connect(hanldeConsoleLogHandler);
        }*/
    }
}
