using System;
using Moq;
using NUnit.Framework;

namespace UnitTestProject.LogAnChar7.DontRepeatYourself
{
    [TestFixture]
    public class ConfigurationManagerTests
    {
        [Test]
        public void IsConfigured_WhenCalled_LogCheckingMessage()
        {
            var mockLogger = new Mock<ILogger>();
            var configurationManager = new ConfigurationManager();
            LoggingFacility.Logger = mockLogger.Object;

            var isConfigured = configurationManager.IsConfigured("");

            mockLogger.Verify(l =>
                l.Log(It.Is<string>(s =>
                    s.Contains("Checking"))));
        }
        
        [TearDown]
        public void AfterEachTest()
        {
            LoggingFacility.Logger = null;
        }
    }
}