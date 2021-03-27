using Moq;
using NUnit.Framework;

namespace UnitTestProject.LogAnChar7.DontRepeatYourself.TestsInBase
{
    [TestFixture]
    public class ConfigurationManagerTests : BaseTestsClass
    {
        [Test]
        public void IsConfigured_WhenCalled_LogCheckingMessage()
        {
            var mockLogger = FakeTheLogger();
            var configurationManager = new ConfigurationManager();

            var isConfigured = configurationManager.IsConfigured("");

            mockLogger.Verify(l =>
                l.Log(It.Is<string>(s =>
                    s.Contains("Checking"))));
        }
    }
}