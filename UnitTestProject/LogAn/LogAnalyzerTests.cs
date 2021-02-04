using NUnit.Framework;

namespace UnitTestProject.LogAn
{
    [TestFixture]
    public class LogAnalyzerTests
    {
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
            var analyzer = new LogAnalyzer();

            var result = analyzer.IsValidLogFileName(file);

            Assert.AreEqual(expected, result);
        }
    }
}