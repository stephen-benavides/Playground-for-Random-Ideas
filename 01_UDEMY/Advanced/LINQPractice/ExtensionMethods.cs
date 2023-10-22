using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Advanced.LINQPractice
{
    public class ExtensionMethods
    {

        public class Program
        {
            public static void MainCaller(string[] args)
            {
                LibraryDbSet library = new LibraryDbSet(new List<Courses>()
                {
                    new Courses() {Name = "Biology"},
                    new Courses() {Name = "Calculos 4", Size = 250, Type = "Math"}
                });


            }


            class LibraryDbSet
            {
                private readonly List<Courses> _coursesList;

                public LibraryDbSet(List<Courses> coursesList)
                {
                    _coursesList = coursesList;
                }

                public IEnumerable<Courses> GetCoursesList()
                {
                    return this._coursesList;
                }
            }

            class Courses
            {
                public string Name { get; set; }
                public string Type { get; set; }
                public int Size { get; set; }
            }
        }
    }
}

