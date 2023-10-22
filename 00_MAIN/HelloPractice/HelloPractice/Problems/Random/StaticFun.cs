using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Random
{
    public class StaticFun
    {
        private readonly string _fileName;
        private StreamWriter _streamWriter;
        private StreamReader _streamReader;

        public StaticFun(string fileName)
        {
            this._fileName = fileName;
        }

        // Read Static
        public void OpenFile()

        {
            try
            {
                if (File.Exists(_fileName))
                {
                    using (_streamReader = new StreamReader(new FileStream(_fileName, FileMode.Open, FileAccess.Read)))
                    {
                        string s = _streamReader.ReadLine();
                        if (s != null)
                        {
                            Console.WriteLine(s);
                            _streamReader.Close();
                        }

                        File.Delete(_fileName);
                        Console.WriteLine("Deleted");
                    }
                }
                else
                {
                    _streamWriter = new StreamWriter(new FileStream(_fileName, FileMode.CreateNew, FileAccess.Write));
                    _streamWriter.Write("Hello World");
                    _streamWriter.Close();
                    Console.WriteLine("Created");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}