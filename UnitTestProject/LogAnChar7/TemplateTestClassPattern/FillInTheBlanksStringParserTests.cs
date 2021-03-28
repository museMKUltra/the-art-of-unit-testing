using NUnit.Framework;

namespace UnitTestProject.LogAnChar7.TemplateTestClassPattern
{
    [TestFixture]
    public abstract class FillInTheBlanksStringParserTests
    {
        protected abstract IStringParser GetParser(string input);
        protected abstract string HeaderVersionSingleDigit { get; }
        protected abstract string HeaderVersionWithMinorVersion { get; }
        protected abstract string HeaderVersionWithRevision { get; }
        public const string ExpectedSingleDigit = "1";
        public const string ExpectedWithRevision = "1.1";
        public const string ExpectedWithMinorVersion = "1.1.1";

        [Test]
        public void TestGetStringVersionFromHeader_SingleDigit_Found()
        {
            var input = HeaderVersionSingleDigit;
            var parser = GetParser(input);

            var versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.That(versionFromHeader, Is.EqualTo(ExpectedSingleDigit));
        }

        [Test]
        public void TestGetStringVersionFromHeader_WithMinorVersion_Found()
        {
            var input = HeaderVersionWithRevision;
            var parser = GetParser(input);

            var versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.That(versionFromHeader, Is.EqualTo(ExpectedWithRevision));
        }

        [Test]
        public void TestGetStringVersionFromHeader_WithRevision_Found()
        {
            var input = HeaderVersionWithMinorVersion;
            var parser = GetParser(input);

            var versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.That(versionFromHeader, Is.EqualTo(ExpectedWithMinorVersion));
        }
    }
}