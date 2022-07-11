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
namespace Composition
{
    public class DbMigrator
    {
    private readonly Logger logger;

    public DbMigrator(Logger logger)
    {
        this.logger = logger;
    }
    public void Migrate()
    {
        logger.Log("We are migrating sdsdasd");
    }
}
public class Installer
{
    private readonly Logger logger;

    public Installer(Logger logger)
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
            var dbMigrator = new DbMigrator(new Logger());
            
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
        }
    }
}