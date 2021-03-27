using Moq;
using NUnit.Framework;

namespace UnitTestProject.LogAnChar7.DontRepeatYourself
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void Analyze_TooShortFileName_LogFileNameTooShort()
        {
            var mockLogger = new Mock<ILogger>();
            var logAnalyzer = new LogAnalyzer();
            LoggingFacility.Logger = mockLogger.Object;

            const string fileName = "abc.txt";
            logAnalyzer.Analyze(fileName);

            mockLogger.Verify(l =>
                l.Log(It.Is<string>(s =>
                    s.Contains("Filename too short:"))));
        }

        [TearDown]
        public void AfterEachTest()
        {
            LoggingFacility.Logger = null;
        }
    }
}