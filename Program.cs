using System;

namespace MyTeamCityProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, TeamCity!");
            Console.WriteLine("Build triggered by a commit");
            Console.WriteLine(Greeter.Greet(args.Length > 0 ? args[0] : "student"));
        }
    }
}
