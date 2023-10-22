using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Udemy.Advanced
{
    class Program
    {
        // public static void Main(string[] args)
        // {
        //     //Process process = new Process();
        //     Photo photo = new Photo();
        //     FileTransfer ft = new FileTransfer();
        //     Process p = new Process();
        //
        //     Process.PhotoFilterHandler handler = ft.ChangeResolution;
        //     handler += ft.LoadPhoto;
        //     handler += PrintFeature;
        //     //handler += ft.PrintPhoto() --ERROR
        //     p.Run(handler);
        //
        // }

        static void PrintFeature(Photo photo)
        {
            Console.WriteLine("Print this too2222");
        }
    }

    class AnotherFeature
    {
        public static void PrintFeature(Photo photo)
        {
            Console.WriteLine("Print this too");
        }
    }
    //Write any class outside of program and use ALT+ENTER to move it to another .cs file

    // Practice Delegate
    class Photo
    {
        private string _path;
        public string Name { get; set; }
        public int Resolution { get; set; }
        public string Type { get; set; }

        public void Load(string path)
        {
            this._path = path;
        }

        public void getPath()
        {
            Console.WriteLine(_path);
        }
    }

    class FileTransfer
    {
        public void LoadPhoto(Photo photo)
        {
            Console.WriteLine("Load Photo");
        }

        // Change resolution
        public void ChangeResolution(Photo photo)
        {
            Console.WriteLine("Change Resolution");
        }

        //print the photo
        public int PrintPhoto(Photo photo)
        {
            return 5;
        }
    }

    class Process
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Run(Process.PhotoFilterHandler filterHandler)
        {
            //Pass a delegate

            //FileTransfer ft = new FileTransfer();
            Photo photo = new Photo();

            //ft.ChangeResolution(photo);
            filterHandler(photo);
        }
    }
}