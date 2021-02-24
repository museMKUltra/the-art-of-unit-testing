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

            Assert.That(mockEmail.To, Is.EqualTo("someone@somewhere.com"));
            Assert.That(mockEmail.Subject, Is.EqualTo("can't log"));
            Assert.That(mockEmail.Body, Is.EqualTo("fake exception"));
        }
    }
}