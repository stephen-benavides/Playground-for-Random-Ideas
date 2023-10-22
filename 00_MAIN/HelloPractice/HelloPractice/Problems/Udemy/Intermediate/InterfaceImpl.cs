/*using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using HelloPractice.Problems.Random;
using HelloPractice.Problems.Udemy;
using HelloPractice.Problems.Udemy.Intermediate;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

namespace HelloPractice
{
    class Program

    {
        public static void Main(string[] args)
        {
            DBMigrator dbMigrator = new DBMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
        }
    }

    /*
     *
     * Create tasks to process an immage
     * the tasks include resizing, change brightness and change format 
     #1#
    class DBMigrator
    {
        private readonly ILogger _logger;

        public DBMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo(DateTime.Now.ToString());
            _logger.LogError(DateTime.Now.ToString());
        }



        //Cant use the same twice 
    }

    class ConsoleLogger : ILogger
    {

        public void LogInfo(string message) // What if I want to log to a file? 
        {
            Console.WriteLine("Log message: {0}", message);
        }
        public void LogError(string message) // What if I want to log to a file? 
        {
            Console.WriteLine("Log error:  {0}", message);
        }
    }

    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }


}*/