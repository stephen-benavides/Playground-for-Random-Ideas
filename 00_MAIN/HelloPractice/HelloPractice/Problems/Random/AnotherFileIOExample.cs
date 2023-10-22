using HelloPractice.Problems.Udemy.Intermediate;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Random
{
    public class AnotherFileIOExample
    {
        public AnotherFileIOExample(String filePath)
        {
            this.path = filePath;
        }
       private Person person = new Person
        {
            FirstName = "James",
            LastName = "Sunderberg"
        };

        private String path =
            @"D:\Users\stepb\Desktop\GitHub\Repositories\C# Practice\HelloPractice\HelloPractice\FileIO_Documents\WordBank.txt";

        public void CallObjectInitializerPerson()
        {
            person.CallPersonMethods();
        }


        public void ReadData()
        {
            StreamReader streamReader = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            String line;
            while ((line = streamReader.ReadLine()) != null)
            {
                Console.WriteLine(line);

            }
            streamReader.Close();

        }

    }
}
