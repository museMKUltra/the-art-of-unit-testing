using NUnit.Framework;

namespace UnitTestProject.LogAnChar7.TemplateTestClassPattern
{
    [TestFixture]
    public class XmlStringParserFillTests : FillInTheBlanksStringParserTests
    {
        protected override IStringParser GetParser(string input)
        {
            return new XmlStringParser(input);
        }

        protected override string HeaderVersionSingleDigit => $"<Header>{ExpectedSingleDigit}</Header>";
        protected override string HeaderVersionWithRevision => $"<Header>{ExpectedWithRevision}</Header>";
        protected override string HeaderVersionWithMinorVersion => $"<Header>{ExpectedWithMinorVersion}</Header>";
    }
}