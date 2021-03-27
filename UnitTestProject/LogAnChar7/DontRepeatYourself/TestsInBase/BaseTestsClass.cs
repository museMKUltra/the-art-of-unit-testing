using Moq;
using NUnit.Framework;

namespace UnitTestProject.LogAnChar7.DontRepeatYourself.TestsInBase
{
    [TestFixture]
    public class BaseTestsClass
    {
        public Mock<ILogger> FakeTheLogger()
        {
            var logger = new Mock<ILogger>();
            LoggingFacility.Logger = logger.Object;
            return logger;
        }
                    
        [TearDown]
        public void AfterEachTest()
        {
            LoggingFacility.Logger = null;
        }
    }
}