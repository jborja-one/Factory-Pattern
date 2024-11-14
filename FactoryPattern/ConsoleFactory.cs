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
				case "game cube":
				case "gamecube":
					return new GameCube();
				case "nintendo switch":
					return new NintendoSwitch();
				case "ps":
				case "play station":
				case "slasstation":
					return new PlayStation();
				default:
					return new PlayStation();
			}
		}
	}
}

