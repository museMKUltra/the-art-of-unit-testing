using System;
using NUnit.Framework;

namespace UnitTestProject.LogAnChar7.CrossCuttingConcern
{
    [TestFixture]
    public class TimeLoggerTests
    {
        [Test]
        public void SettingSystemTime_Always_ChangesTime()
        {
            SystemTime.Set(new DateTime(2000, 1, 1));

            var message = TimeLogger.CreateMessage("a");

            Assert.That(message.Contains("1/1/2000"), Is.EqualTo(true));
        }
    }
}