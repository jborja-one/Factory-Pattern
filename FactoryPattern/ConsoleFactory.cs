using System;
namespace FactoryPattern
{
	static class ConsoleFactory
	{
		public static ICallable GetConsole(string console)
		{
			switch (console.ToLower())
			{
				case "xbox":
					return new XBox();
				case "Game Cube":
				case "GameCube":
					return new GameCube();
				case "Nintendo Switch":
					return new NintendoSwitch();
				case "PS":
				case "Play Station":
				case "PlasStation":
					return new PlayStation();
				default:
					return new PlayStation();
			}
		}
	}
}

