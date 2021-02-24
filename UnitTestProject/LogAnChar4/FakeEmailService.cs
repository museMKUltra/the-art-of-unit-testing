namespace UnitTestProject.LogAnChar4
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }

    public class FakeEmailService : IEmailService
    {
        private IEmailService _emailServiceImplementation;
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public void SendEmail(string to, string subject, string body)
        {
            To = to;
            Subject = subject;
            Body = body;
        }
    }
}