using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloPractice.Problems.Udemy.Intermediate
{
    class CompositionPractice
    {
        // Related class is a private field in the composite class 

        /*
         * UML
         *      - LOGGER (PARENT)
         *          - DbMigrator - Child
         *          - Installer - Child 
         */
    }

    /*
    class Installer // Child to inherit from Logger -- SEPARATE CLASS  
    {
        private Logger _logger;

        public Installer(Logger logger) // ALT+ENTER on _Logger to create the private field Logger on top 
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Info("We are installing the application bla bla bla");
        }
    }

    class DbMigrator // SEPARATE CLASS 
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Info("We are logging a message bla bla bla....");
        }
    }
    */


    class ProgramTEST

    {
        // static void MainTEST(string[] args)
        // {
        //     var logger = new Logger();
        //     var dbMigrator = new DbMigrator(logger); // new DbMigrator(new Logger());
        //
        //     var installer = new Installer(new Logger());
        //
        //
        //     dbMigrator.Migrate();
        //     installer.Install();
        //
        //     /*
        //      * OUTPUT:
        //      * We are logging a message bla bla bla....
        //      * We are installing the application bla bla bla"
        //      *
        //      */
        //
        //     // GET COMMON FUNCTIONALITY AND RE-USE IT ON OTHER COMPOSITIONS 
        // }
    }
}
