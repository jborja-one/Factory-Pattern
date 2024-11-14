using System;
namespace FactoryPattern
{
	public class NintendoSwitch : ICallable
	{
        public void Build()
        {
            ConsoleLogging.ConsoleBuildDialogue();
            Console.WriteLine("Your Nintento Switch is ready");
        }
    }
}

