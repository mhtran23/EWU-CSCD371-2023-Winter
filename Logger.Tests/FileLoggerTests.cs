using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
<<<<<<< HEAD
    [TestClass]
    public class FileLoggerTests
    {

        [TestMethod]
        public void FileLogger_LoggingLines()
        {
            // Arrange
            string filePath = "C:\\Users\\Public\\Documents\\message.txt";
            var logger = new FileLogger(filePath) {ClassName = nameof(FileLoggerTests)};

            // Act
            logger.Log(LogLevel.Error, "Error");
            logger.Log(LogLevel.Warning, "Warning");
            logger.Log(LogLevel.Information, "Logging Info");
            logger.Log(LogLevel.Debug, "Debugging!");

            // Assert
            string[] content = File.ReadAllLines(filePath);
            Assert.AreEqual(4, content.Length);
            File.Delete(filePath);
        }
    }
=======
    
>>>>>>> e40066f1c4e1fe778e4b84b608e48790f5ed12e6
}
