using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
<<<<<<< HEAD
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void CreateLogger_NullLogger()
        {
            var logger = new LogFactory();
            Assert.IsNull(logger.CreateLogger("Null"));
        }
        [TestMethod]
        public void CreateLogger_NotNullLogger()
        {
            var logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(Path.GetTempFileName());
            var logger = logFactory.CreateLogger("BaseLogger");
            Assert.IsNotNull(logger);
        }
    }
=======
    
>>>>>>> e40066f1c4e1fe778e4b84b608e48790f5ed12e6
}
