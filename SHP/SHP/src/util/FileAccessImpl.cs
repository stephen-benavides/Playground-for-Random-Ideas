using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHP.src.util
{
    public class FileAccess
    {
        public string FilePath { set; get; }
        public StreamReader streamReader;

        public FileAccess(string filePath)
        {
            this.FilePath = filePath;
        }

        public void ReadFile()
        {
           

            using (streamReader = new StreamReader(new FileStream(FilePath, FileMode.Open, FileAccess.Read)))
            {

            }
        }
    }
}
