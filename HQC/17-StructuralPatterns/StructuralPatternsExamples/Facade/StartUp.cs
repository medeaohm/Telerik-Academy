using System;

namespace Facade
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            MyJoggingFacade facade = new MyJoggingFacade();

            facade.StartJogging();
            Console.WriteLine();
            facade.StopJogging();
        }
    }
}
