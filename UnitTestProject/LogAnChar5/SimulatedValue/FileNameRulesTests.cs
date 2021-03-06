using System;
using Moq;
using NSubstitute;
using NUnit.Framework;

namespace UnitTestProject.LogAnChar5.SimulatedValue
{
    [TestFixture]
    public class FileNameRulesTests
    {
        [Test]
        public void IsValidLogFileName_ByDefault_WorksForHardCodeArgument()
        {
            // var fakeRules = Substitute.For<IFileNameRules>();
            // fakeRules.IsValidLogFileName("strict.txt").Returns(true);
            // fakeRules.IsValidLogFileName(Arg.Any<string>()).Returns(true);
            // ---
            var fakeRules = new Mock<IFileNameRules>();
            fakeRules.Setup(r => r.IsValidLogFileName(It.IsAny<string>())).Returns(true);

            // var result = fakeRules.IsValidLogFileName("strict.txt");
            // ---
            var result = fakeRules.Object.IsValidLogFileName("strict.txt");

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void IsValidLogFileName_ArgAny_Throws()
        {
            var fakeRules = Substitute.For<IFileNameRules>();
            fakeRules
                .When(r => r.IsValidLogFileName(Arg.Any<string>()))
                .Do(context => throw new Exception("fake exception"));
            // ---
            // var fakeRules = new Mock<IFileNameRules>();
            // fakeRules.Setup(r => r.IsValidLogFileName(It.IsAny<string>())).Throws<Exception>();

            Assert.Throws<Exception>(() => fakeRules.IsValidLogFileName("anything"));
            // Assert.That(() => fakeRules.Object.IsValidLogFileName("anything"), Throws.Exception);
        }
    }
}