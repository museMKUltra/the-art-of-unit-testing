using System;
using NUnit.Framework;

namespace UnitTestProject.LogAnChar4
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void Analyze_WebServiceThrows_SendsEmail()
        {
            var stubService = new FakeWebService {ToThrow = new Exception("fake exception")};
            var mockEmail = new FakeEmailService();
            var logAnalyzer = new LogAnalyzer(stubService, mockEmail);

            const string tooShortFileName = "abc.ext";
            logAnalyzer.Analyze(tooShortFileName);

            var expectedEmail = new EmailInfo
            {
                To = "someone@somewhere.com",
                Subject = "can't log",
                Body = "fake exception",
            };
            Assert.That(mockEmail.Email, Is.EqualTo(expectedEmail));
            // Assert.AreEqual(expectedEmail, mockEmail.Email);
        }
    }
}