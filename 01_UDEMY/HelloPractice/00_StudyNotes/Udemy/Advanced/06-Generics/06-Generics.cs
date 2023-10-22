/*using System.Collections.Generic;

namespace HelloPractice.Problems.Udemy.Intermediate
{
    public class IndexersPractice
    {
        private readonly Dictionary<string, string> _dictionary;

        public IndexersPractice()
        {
            _dictionary = new Dictionary<string, string>();
        }

        //declare indexer for the dictionary 
        public string this[string key] // Indexers always use [] instead of () and are called using the class name 
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;

        }
    }

    class ProgramPractice

    {
        static void MainPractice(string[] args)
        {
            var cookie = new IndexersPractice();
            //Setter 
            cookie["name"] = "Mosh";
            //Getter
            //Console.WriteLine(cookie["name"]);
        }
    }
}*/