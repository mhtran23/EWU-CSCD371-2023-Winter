using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JesterConstructor_GivenNullIJokeDisplay_ThrowNullException()
        {
            IJokeDisplay? jokeDisplay = null;
            new Jester(jokeDisplay, new JokeService());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JesterConstructor_GivenNullIJokeService_ThrowsNullException()
        {
            IJokeService? jokeService= null;
            new Jester(new DisplayOutput(), jokeService);
        }

        [TestMethod]
        public void TellJoke_ReturnValidJoke()
        {
            string temp = "Jokey Joke Jokes";
            Mock<IJokeService> mock = new Mock<IJokeService>();
            mock.Setup(jokeService => jokeService.GetJoke()).Returns("Jokey Joke Jokes");

            Assert.AreEqual<string>(temp, mock.Object.GetJoke());

        }

        [TestMethod]
        public void TellJoke_ReturnsString_WithChuckNorris_IsFalse()
        {
            Jester jester = new(new DisplayOutput(), new JokeService());

            StringWriter output = new();
            Console.SetOut(output);

            jester.TellJoke();

            Assert.IsFalse(output.ToString().ToLower().Contains("chuck norris"));
           
        }
    }
}
