using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace UnitTestProject.LogAn
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [SetUp]
        public void SetUp()
        {
            _analyzer = new LogAnalyzer();
        }

        [TearDown]
        public void TearDown()
        {
            _analyzer = null;
        }

        private LogAnalyzer _analyzer;

        [Test]
        public void IsValidLogFileName_BadExtension_ReturnFalse()
        {
            // arrange
            var analyzer = new LogAnalyzer();

            // act
            var result = analyzer.IsValidLogFileName("filewithbadextension.foo");

            // assert
            Assert.False(result);
        }

        [Test]
        public void IsValidLogFileName_GoodExtensionLowercase_ReturnTrue()
        {
            var analyzer = new LogAnalyzer();

            var result = analyzer.IsValidLogFileName("filewithbadextension.slf");

            Assert.True(result);
        }

        [Test]
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnTrue()
        {
            var analyzer = new LogAnalyzer();

            var result = analyzer.IsValidLogFileName("filewithbadextension.SLF");

            Assert.True(result);
        }

        // parameterized tests
        [TestCase("filewithbadextension.SLF", true)]
        [TestCase("filewithbadextension.slf", true)]
        [TestCase("filewithbadextension.foo", false)]
        public void IsValidLogFileName_VariousExtension_ReturnTrue(string file, bool expected)
        {
            var result = _analyzer.IsValidLogFileName(file);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsValidLogFileName_EmptyFileName_ThrowException()
        {
            var fileName = string.Empty;

            ActualValueDelegate<bool> @delegate = () => _analyzer.IsValidLogFileName(fileName);

            Assert.That(@delegate, Throws.TypeOf<ArgumentException>());
            Assert.That(@delegate,
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("filename has to be provided"));
            Assert.That(@delegate, Throws.ArgumentException);
            Assert.That(@delegate, Throws.ArgumentException.With.Message.EqualTo("filename has to be provided"));
        }
    }
}