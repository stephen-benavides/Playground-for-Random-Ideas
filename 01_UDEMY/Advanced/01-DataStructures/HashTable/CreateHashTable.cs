using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.RandomExercises
{
    class CreateHashTable
    {
        public static void MainCaller(string[] args)
        {
            HashTable hash = new HashTable(10);
            hash.set("grapes", 10);
            //hash.set("val", 40);
            //hash.get("vaasl");

            double a = 500 % 10;
            Console.WriteLine(a);
            int[] arr = new int[] {1, 2, 3, 4};
            Console.WriteLine(arr);
        }


        class HashTable
        {
            private readonly int _size;
            public readonly int[] memoryInput;
            private int hash;

            public HashTable(int size)
            {
                this._size = size;
                this.memoryInput = new int[_size];
            }

            public void set(string key, int value)
            {
                _hash(key);
                if (!memoryInput.Contains(hash)) // Avoid collisions elements 
                    memoryInput.SetValue(value, hash);
            }

            public void get(string key)
            {
                _hash(key);
                Console.WriteLine(memoryInput.GetValue(hash));
            }

            /// <summary>
            /// hashes the string key into a constant integer value
            /// </summary>
            /// <param name="key">key from the user</param>
            private void _hash(string key)
            {
                hash = 0;
                for (int i = 0; i < key.Length; i++)
                {
                    hash = (hash + (int) key[i] * i) % this.memoryInput.Length;
                }
            }
        }
    }
}