using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JokeServiceTest
    {
        [TestMethod]
        public void JokeService_ReturnValidString()
        {
            JokeService joker = new JokeService();
            Assert.IsNotNull(joker.GetJoke());
            Assert.IsInstanceOfType(joker.GetJoke(), typeof(string));
        }
    }
}
