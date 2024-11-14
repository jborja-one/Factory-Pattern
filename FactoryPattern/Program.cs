namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of game console would you like to create?");
            string userConsole = Console.ReadLine();

            ICallable console = ConsoleFactory.GetConsole(userConsole);
            console.Build();
            Console.ReadLine();
        }
    }
}
