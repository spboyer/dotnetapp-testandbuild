using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = "Dotnet-bot: Welcome to using .NET Core!";

            if (args.Length > 0)
            {
                message = String.Join(" ", args);
            }

            var robot  = new dotnetbot.maker();

            Console.WriteLine(robot.GetBot(message));
            Console.WriteLine();
            Console.WriteLine($"Time: {DateTime.Now.ToString()}");
            Console.WriteLine();
            Console.WriteLine($"OS: {RuntimeInformation.OSDescription}");
            Console.WriteLine();
        }
    }
}
