using System;
namespace FactoryPattern
{
	public class XBox : ICallable
	{
		public void Build()
		{
			ConsoleLogging.ConsoleBuildDialogue();
			Console.WriteLine("Your XBox is ready");
		}
	}
}

