using MyTeamCityProject;
using Xunit;

namespace MyTeamCityProject.Tests
{
    public class GreeterTests
    {
        [Fact]
        public void Greet_PutsNameIntoMessage()
        {
            Assert.Equal("Hello, Olena!", Greeter.Greet("Olena"));
        }

        [Fact]
        public void Greet_TrimsSpaces()
        {
            Assert.Equal("Hello, Ivan!", Greeter.Greet("  Ivan "));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Greet_EmptyName_ReturnsAnonymous(string? name)
        {
            Assert.Equal("Hello, anonymous!", Greeter.Greet(name));
        }
    }
}
