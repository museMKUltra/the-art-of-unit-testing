using System;

namespace UnitTestProject.LogAnChar4
{
    public class LogAnalyzer
    {
        public IEmailService Email { get; set; }
        public IWebService Service { get; set; }

        public LogAnalyzer( FakeWebService service, IEmailService email)
        {
            Email = email;
            Service = service;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                try
                {
                    Service.LogError("Filename too short:" + fileName);
                }
                catch (Exception e)
                {
                    Email.SendEmail("someone@somewhere.com", "can't log", e.Message);
                }
            }
        }
    }
}