using System;
namespace FactoryPattern
{
	public class GameCube : ICallable
	{
        public void Build()
        {
            ConsoleLogging.ConsoleBuildDialogue();
            Console.WriteLine("Your Game Cube is ready");
        }
    }
}

