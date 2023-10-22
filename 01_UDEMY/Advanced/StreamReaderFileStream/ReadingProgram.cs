using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Advanced.StreamReaderFileStream
{
    class ReadingProgram
    {
        public static void MainProgram(string[] args)
        {
            string filePath = @"D:\Users\stepb\Desktop\ToDelete\ReadMe.txt";

            List<string?> myList = new List<string?>();
            IEnumerable<string?> myList2 = myList;

            using (StreamReader reader = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)))
            {
                string? line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    myList.Add(line);
                }
            }



            var resultQuery = myList2.Where(i => int.Parse(i) > 2);

            foreach (var i in resultQuery)
            {
                Console.WriteLine(i);
            }
        }
    }
}
