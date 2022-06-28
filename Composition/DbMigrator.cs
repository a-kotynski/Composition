//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2243556#content
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
}