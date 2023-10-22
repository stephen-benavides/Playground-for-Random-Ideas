using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            BrowserMethods browser = new BrowserMethods();

            /*
             * Synchronous Version of the method
             */ 
            //browser.DownloadHtml("https://stackoverflow.com/questions/18547862/print-textbox-contents-in-c-sharp");

            /*
             * Asynchronous version of the above method
             */ 
            //browser.DownloadHtmlAsync("https://stackoverflow.com/questions/18547862/print-textbox-contents-in-c-sharp");

           /*
            * Returning a string instead of void
            */ 
            //var html = browser.GetHtml("https://stackoverflow.com/questions/18547862/print-textbox-contents-in-c-sharp");

            //MessageBox.Show(html.Substring(0,50900));


            /*
             * Returning string - Asynchronous 
             */
            var getHtmlTask = browser.GetHtmlAsync("https://stackoverflow.com/questions/18547862/print-textbox-contents-in-c-sharp");

            //You can include multiple boxes while the tasks awaits execution 
            MessageBox.Show("Awaiting for the task to complete");

            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0,50000));
        }

       
    }
}
