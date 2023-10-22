using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.RandomExercises
{
    public class GenericsIndexersTest
    {
        public static void MainCaller(string[] args)
        {
            IndexTest<int> index = new IndexTest<int>();
            index[0] = 1;
            index[1] = 2;
            index.Ints.ForEach(i => Console.Write(i));
        }
    }
}

    class IndexTest<T>
    {
        public List<T> Ints = new List<T>();

        public T this[T key]
        {
            set => Ints.Add(value);
            get => Ints.Find(i => i.Equals(key));
        }
    }

