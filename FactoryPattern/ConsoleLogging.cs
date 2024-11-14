using System;
namespace FactoryPattern
{
	public class ConsoleLogging
	{
		public static void ConsoleBuildDialogue()
		{
			Console.WriteLine("Gathering all information");
			Thread.Sleep(1000);
			Console.WriteLine("Building your console");
			Thread.Sleep(1000);
		}
	}
}

