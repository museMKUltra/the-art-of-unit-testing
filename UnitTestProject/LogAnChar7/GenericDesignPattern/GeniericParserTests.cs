using System;
using NUnit.Framework;

namespace UnitTestProject.LogAnChar7.GenericDesignPattern
{
    public abstract class GenericParserTests<T> where T : IStringParser
    {
        protected abstract string GetInputHeaderSingleDigit();
        public const string ExpectedSingleDigit = "1";

        protected T GetParser(string input)
        {
            return (T) Activator.CreateInstance(typeof(T), input);
        }

        [Test]
        public void GetStringVersionFroHeader_SingleDigit_Found()
        {
            var input = GetInputHeaderSingleDigit();
            var parser = GetParser(input);
            
            var result = parser.GetStringVersionFromHeader();

            Assert.That(result, Is.EqualTo(ExpectedSingleDigit));
        }
    }

    [TestFixture]
    public class StandarParserGenericTests : GenericParserTests<StandardStringParser>
    {
        protected override string GetInputHeaderSingleDigit()
        {
            return "header;version=1;\n";
        }
    }
}