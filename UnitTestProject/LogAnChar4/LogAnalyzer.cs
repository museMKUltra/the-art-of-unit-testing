using System;

namespace UnitTestProject.LogAnChar4
{
    public class LogAnalyzer
    {
        public IEmailService Email { get; set; }
        public IWebService Service { get; set; }

        public LogAnalyzer(IWebService service, IEmailService email)
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
                    var emailInfo = new EmailInfo
                    {
                        To = "someone@somewhere.com",
                        Subject = "can't log",
                        Body = e.Message
                    };
                    Email.SendEmail(emailInfo);
                }
            }
        }
    }
}