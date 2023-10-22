using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanConsoleSelf.Util;

namespace HangmanConsoleSelf.Util
{
    public class FileAccessor
    {
        public string FilePath { set; get;  }
        private StreamReader streamReader;

        public FileAccessor(String filePath)
        {
            this.FilePath = filePath;
        }

        /// <summary>
        /// Finds the total number of lines in a text file.
        /// </summary>
        /// <returns>Integer that reflects the total number of lines</returns>
        public int GetUpperBounds()
        {
            int upperBounds = 0;
            using (streamReader = new StreamReader(new FileStream(FilePath,  FileMode.Open, FileAccess.Read)))
            {
                while (!streamReader.EndOfStream)
                {
                    streamReader.ReadLine();
                    upperBounds++;
                }
            }
            return upperBounds;
        }

        /// <summary>
        /// Receives an integer and returns the corresponding line of text.
        /// </summary>
        /// <param name="lineNum">Line number to Return</param>
        /// <returns>Text from line corresponding to lineNum</returns>
        public string GetLine(int lineNum)
        {
            using (streamReader = new StreamReader(new FileStream(FilePath, FileMode.Open, FileAccess.Read)))
            {
                for (int n = 1; n < lineNum; n++)
                {
                    streamReader.ReadLine();
                }
                return streamReader.ReadLine();
            }
        }

        /// <summary>
        /// Returns a random line from a text file
        /// </summary>
        /// <returns>Random line of text</returns>
        public virtual string GetRandomLine()
        {
            Random random = new Random();
            int wordBankSize = GetUpperBounds();

            return GetLine(random.Next(1, wordBankSize + 1));
        }
    }
}
