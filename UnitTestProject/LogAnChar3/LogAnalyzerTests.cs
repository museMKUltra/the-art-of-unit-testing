using System;
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
        public void IsValidLogFileName_WhenCalled_ReturnExceptedValue(string fileName, bool isValid)
        {
            _manager.WillBeValid = isValid;

            var result = _logAnalyzer.IsValidLogFileName(fileName);

            Assert.That(result, Is.EqualTo(isValid));
        }

        [Test]
        [TestCase("filewithbadextension.slf", true)]
        [TestCase("filewithbadextension.foo", false)]
        public void IsValidLogFileName2_WhenCalled_ReturnExpectedValue(string fileName, bool isValid)
        {
            var manager = new FakeFileExtensionManager();
            var logAnalyzer = new LogAnalyzer();
            logAnalyzer.Manager = manager;
            manager.WillBeValid = isValid;

            var result = logAnalyzer.IsValidLogFileName2(fileName);

            Assert.That(result, Is.EqualTo(isValid));
        }

        [Test]
        [TestCase("filewithbadextension.slf", true)]
        [TestCase("filewithbadextension.foo", false)]
        public void IsValidLogFileName3_WhenCalled_ReturnExpectedValue(string fileName, bool isValid)
        {
            var manager = new FakeFileExtensionManager();
            var logAnalyzer = new LogAnalyzer();
            manager.WillBeValid = isValid;

            var result = logAnalyzer.IsValidLogFileName3(fileName, manager);

            Assert.That(result, Is.EqualTo(isValid));
        }
    }
}