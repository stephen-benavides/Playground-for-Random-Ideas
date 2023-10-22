using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHP.src.util
{
    public interface IFileAccess
    {
        /*
         * Open the file 
         * Read the file 
         * Store string of lines 
         * process the lines 
         * store new lines in new file
         */

        //Open File 
        void OpenFile(String file);
        void ReadFile()
    }
}
