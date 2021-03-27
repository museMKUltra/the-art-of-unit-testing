using Moq;
using NUnit.Framework;

namespace UnitTestProject.LogAnChar7.DontRepeatYourself.TestsInBase
{
    [TestFixture]
    public class LogAnalyzerTests : BaseTestsClass
    {
        [Test]
        public void Analyze_TooShortFileName_LogFileNameTooShort()
        {
            var mockLogger = FakeTheLogger();
            var logAnalyzer = new LogAnalyzer();

            const string fileName = "abc.txt";
            logAnalyzer.Analyze(fileName);

            mockLogger.Verify(l =>
                l.Log(It.Is<string>(s =>
                    s.Contains("Filename too short:"))));
        }
    }
}