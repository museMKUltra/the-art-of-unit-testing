using NUnit.Framework;

namespace UnitTestProject.LogAnChar5.DynamicCreating
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void Analyze_TooShortFileName_CallLogger()
        {
            // arrange
            var mockService = new FakeWebService();
            var logAnalyzer = new LogAnalyzer(mockService);
            // ---
            // var mockService = Substitute.For<IWebService>();
            // var logAnalyzer = new LogAnalyzer(mockService);
            // ---
            // var mockService = new Mock<IWebService>();
            // var logAnalyzer = new LogAnalyzer(mockService.Object);

            // action
            const string tooShortFileName = "abc.txt";
            logAnalyzer.MinNameLength = 8;
            logAnalyzer.Analyze(tooShortFileName);

            // assert
            Assert.That(mockService.LastError, Is.EqualTo("Filename too short:abc.txt"));
            // ---
            // mockService.Received().LogError("Filename too short:abc.txt");
            // ---
            // mockService.Verify(s => s.LogError("Filename too short:abc.txt"));
        }
    }
}