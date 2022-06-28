//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2243556#content
namespace Composition
{
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
}