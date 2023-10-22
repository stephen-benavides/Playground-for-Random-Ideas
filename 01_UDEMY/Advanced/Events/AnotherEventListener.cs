using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    class AnotherEventListener
    {
        public class Program
        {
            public static void MainProgram(string[] args)
            {
                try
                {
                    FacetsFrontPage frontPage = new FacetsFrontPage();
                    NextPage nextPage = new NextPage();
                    frontPage.mainPage += nextPage.NextPage_PCP;
                    frontPage.MainPageFacets();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }

        /*
            New Event for sending a video and handling the even in the main application 
         */

        //Stablish a listener 

        class FacetsFrontPage
        {
            /*public delegate void MainPage(Object source, EventArgs args);

            public event MainPage mainPage;*/

            public EventHandler<EventArgs> mainPage;
            public void MainPageFacets()
            {
                Console.WriteLine("In the main page waiting for user input");

                //Do something when the user access this method 
                onMainPage();
            }

            protected void onMainPage()
            {
                if (mainPage != null)
                    mainPage(this, EventArgs.Empty);
                else
                    throw new ArgumentNullException("No Event");

            }
        }

        //Setting up a publisher 
        class NextPage
        {
            public void NextPage_PCP(Object source, EventArgs args)
            {
                Console.WriteLine("In the PCP page");
            }
        }
    }
}
