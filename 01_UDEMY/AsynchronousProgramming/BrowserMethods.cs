using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    public class BrowserMethods
    {
         // Syncronous Programing - One line at a time 
        public void DownloadHtml(string url)
        {
            WebClient webClient = new WebClient();
            var html = webClient.DownloadString(url);

            string filePath = @"D:\Users\stepb\Desktop\VisualStudio Projects\00-UDEMY\AsynchronousProgramming\Readers\";
            string fileName = "result.html";

            using (StreamWriter sw = new StreamWriter(new FileStream(filePath+fileName,FileMode.CreateNew)))
            {
                sw.Write(html);
            }
        }

        /**
         * For Asynchronous programming you have to follow certain convention
         * 1. create a method with the async keyword,
         *    the method should have the name ending with "Async" suffix
         * 2. it should have he same parameters, just changing the declaration of the method 
         */
        // Method with "async" keyword + Task + "Async" sufix 
        public async Task DownloadHtmlAsync(string url)
        {
            WebClient webClient = new WebClient();
            //method that is being implemented to download the string with "await" keyword and Async version of the method 
            var html = await webClient.DownloadStringTaskAsync(url);

            string filePath = @"D:\Users\stepb\Desktop\VisualStudio Projects\00-UDEMY\AsynchronousProgramming\Readers\";
            string fileName = "resultAsync.html";

            using (StreamWriter sw = new StreamWriter(new FileStream(filePath + fileName, FileMode.CreateNew)))
            {
                // await + Async version of the Write method in the reader 
                await sw.WriteAsync(html);
            }
        }

        // Returning something, the previous one was void - Synchronous 
        public string GetHtml(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }

        //Returning something - Asynchronous 
        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
