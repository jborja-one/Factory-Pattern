using System;
namespace FactoryPattern
{
	public class PlayStation : ICallable
	{
        public void Build()
        {
            ConsoleLogging.ConsoleBuildDialogue();
            Console.WriteLine("Your PlayStation is ready");
        }
    }
}

