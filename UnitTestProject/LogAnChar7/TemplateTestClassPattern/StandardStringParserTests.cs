using NUnit.Framework;

namespace UnitTestProject.LogAnChar7.TemplateTestClassPattern
{
    [TestFixture]
    public class StandardStringParserTests
    {
        private StandardStringParser GetParser(string input)
        {
            return new StandardStringParser(input);
        }

        [Test]
        public void GetStringVersionFromHeader_SingleDigit_Found()
        {
            const string input = "header;version=1;\n";
            StandardStringParser parser = GetParser(input);

            string versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.That(versionFromHeader, Is.EqualTo("1"));
        }


        [Test]
        public void GetStringVersionFromHeader_WithMinorVersion_Found()
        {
            const string input = "header;version=1.1;\n";
            StandardStringParser parser = GetParser(input);

            string versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.That(versionFromHeader, Is.EqualTo("1.1"));
        }

        [Test]
        public void GetStringVersionFromHeader_WithRevision_Found()
        {
            const string input = "header;version=1.1.1;\n";
            StandardStringParser parser = GetParser(input);

            string versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.That(versionFromHeader, Is.EqualTo("1.1.1"));
        }
    }
}