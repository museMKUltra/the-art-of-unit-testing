using NUnit.Framework;

namespace UnitTestProject.LogAnChar7.TemplateTestClassPattern
{
    [TestFixture]
    public class XmlStringParserTests : TemplateStringParserTests
    {
        protected XmlStringParser GetParser(string input)
        {
            return new XmlStringParser(input);
        }

        [Test]
        public override void TestGetStringVersionFromHeader_SingleDigit_Found()
        {
            var parser = GetParser("<Header>1</Header>");

            var versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.That(versionFromHeader, Is.EqualTo("1"));
        }

        [Test]
        public override void TestGetStringVersionFromHeader_WithMinorVersion_Found()
        {
            var parser = GetParser("<Header>1.1</Header>");

            var versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.That(versionFromHeader, Is.EqualTo("1.1"));
        }

        [Test]
        public override void TestGetStringVersionFromHeader_WithRevision_Found()
        {
            var parser = GetParser("<Header>1.1.1</Header>");

            var versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.That(versionFromHeader, Is.EqualTo("1.1.1"));
        }
    }
}