namespace MyTeamCityProject
{
    public static class Greeter
    {
        public static string Greet(string? name) =>
            string.IsNullOrWhiteSpace(name) ? "Hello, anonymous!" : $"Hello, {name.Trim()}!";
    }
}
