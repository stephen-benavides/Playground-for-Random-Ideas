using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.RandomExercises
{
    public class LoggerEvents
    {
        public static void MainProgram(string[] args)
        {
            DBConnection db = new DBConnection();
            Loggers loggers = new Loggers();
            LogDocument log = new LogDocument();
            db.loggerEvent += loggers.DocumentLog;
            db.loggerEvent += log.LogToDocument;

            db.Connect(new Document() { Name = "Document in the Main Body" });
        }
    }


    public class Loggers
    {
        public void ConsoleLog(Object source, EventArgs args)
        {
            Console.WriteLine("Log in the console");
        }

        public void DocumentLog(Object source, EventArgs args)
        {
            Console.WriteLine("Log in a document");
        }
    }

    public class DBConnection
    {
        public delegate void LoggerEvent(Object source, LoggerEventArgs args);

        public event LoggerEvent loggerEvent;

        //public EventHandler<LoggerEventArgs> loggerEvent;
        public void Connect(Document document)
        {
            Console.WriteLine("Connect to a console");
            //Log the connection 
            duringLoggerEvent(document);
        }

        protected void duringLoggerEvent(Document document)
        {
            if (loggerEvent != null)
                loggerEvent(this, new LoggerEventArgs(document));
            else
            {
                throw new ArgumentNullException();
            }
        }
    }

    public class LoggerEventArgs : EventArgs
    {
        private readonly Document _document;

        public Document Document
        {
            get
            {
                return _document;
            }
        }

        public LoggerEventArgs(Document document)
        {
            _document = document;
        }
    }

    public class Document
    {
        public string Name { get; set; }
        public string Size { get; set; }
    }

    public class LogDocument
    {
        public void LogToDocument(Object source, LoggerEventArgs args)
        {
            Console.WriteLine($"Logging to document: {args.Document.Name}");
        }
    }
}
