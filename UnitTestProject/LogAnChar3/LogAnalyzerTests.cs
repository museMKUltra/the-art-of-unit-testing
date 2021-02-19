using NUnit.Framework;

namespace UnitTestProject.LogAnChar3
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [SetUp]
        public void SetUp()
        {
            _manager = new FakeFileExtensionManager();
            _logAnalyzer = new LogAnalyzer(_manager);
        }

        private FakeFileExtensionManager _manager;
        private LogAnalyzer _logAnalyzer;

        [Test]
        [TestCase("filewithbadextension.slf", true)]
        [TestCase("filewithbadextension.foo", false)]
        public void IsValidLogFileName_GoodExtension_ReturnTrue(string fileName, bool expectedResult)
        {
            _manager.WillBeValid = expectedResult;

            var result = _logAnalyzer.IsValidLogFileName(fileName);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}