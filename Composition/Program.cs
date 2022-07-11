using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2243556#content

// Composition is a relationship between two classes that allows one to contain
// the other

//  Inheritance:            | Composition:
//* is-a relationship       | has-a relationship
//* square is a rectangle   | car has an engine 


// Benefits of Composition:
// * Code re-use
// * Flexibility
// * Means to loose-coupling

// Inheritance
// Pros: Code re-use, easier to understand
// Cons: Tightly coupled, fragile, can be abused

namespace Composition
{
    public class DbMigrator // requires logging
    {
    private readonly Logger logger; // declared logger field of the Logger class

    public DbMigrator(Logger logger) // Logger class method in parameter of the constructor
    {
        this.logger = logger;
    }
    public void Migrate()
    {
        logger.Log("We are migrating sdsdasd");
    }
}
public class Installer // requires logging
{
    private readonly Logger logger; // declared logger field of the Logger class

    public Installer(Logger logger) // Logger class method in parameter of the constructor
        {
            this.logger = logger;
        }
    public void Install()
        {
            logger.Log("We are installing the application.");
        }
}
public class Logger
{
    public void Log(string message)
        {
            Console.WriteLine(message);
        }
}


    class Program
    {
        static void Main(string[] args)
        {
            // creating objects for all classes:
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
        }
    }
}