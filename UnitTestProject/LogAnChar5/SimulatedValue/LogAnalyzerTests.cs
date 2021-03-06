using System;
using Moq;
using NSubstitute;
using NUnit.Framework;

namespace UnitTestProject.LogAnChar5.SimulatedValue
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void Analyze_LoggerThrows_CallWebService()
        {
            var mockWebService = new FakeWebService();
            var stubLogger = new FakeLogger();
            stubLogger.WillThrow = new Exception("fake exception");
            // ---
            // var mockWebService = Substitute.For<IWebService>();
            // var stubLogger = Substitute.For<ILogger>();
            // stubLogger
            //     .When(logger => logger.LogError(Arg.Any<string>()))
            //     .Do(info => throw new Exception("fake exception"));
            // ---
            // var mockWebService = new Mock<IWebService>();
            // var stubLogger = new Mock<ILogger>();
            // stubLogger.Setup(l => l.LogError(It.IsAny<string>())).Throws(new Exception("fake exception"));

            var analyzer = new LogAnalyzer(stubLogger, mockWebService) {MinNameLength = 8};
            const string tooShortFileName = "abc.txt";
            analyzer.Analyze(tooShortFileName);
            // ---
            // var analyzer = new LogAnalyzer(stubLogger.Object, mockWebService.Object) {MinNameLength = 8};
            // const string tooShortFileName = "abc.txt";
            // analyzer.Analyze(tooShortFileName);

            Assert.That(mockWebService.MessageToWebService, Is.StringContaining("fake exception"));
            // ---
            // mockWebService.Received().Write(Arg.Is<string>(s => s.Contains("fake exception")));
            // ---
            // mockWebService.Verify(ws => ws.Write(It.Is<string>(s => s.Contains("fake exception"))));
        }
    }
}