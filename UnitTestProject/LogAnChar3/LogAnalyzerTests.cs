using NUnit.Framework;

namespace UnitTestProject.LogAnChar3
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [SetUp]
        public void SetUp()
        {
            _analyzer = new LogAnChar3.LogAnalyzer();
        }

        private LogAnChar3.LogAnalyzer _analyzer;

        [Test]
        public void IsValidLogFileName_GoodExtension_ReturnTrue()
        {
            var analyzer = new LogAnChar3.LogAnalyzer();

            var result = analyzer.IsValidLogFileName("filewithbadextension.slf");

            Assert.That(result, Is.EqualTo(true));
        }
    }
}