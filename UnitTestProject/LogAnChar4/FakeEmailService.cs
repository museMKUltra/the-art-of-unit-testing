using System;

namespace UnitTestProject.LogAnChar4
{
    public interface IEmailService
    {
        void SendEmail(EmailInfo email);
    }

    public class FakeEmailService : IEmailService
    {
        public EmailInfo Email = null;

        public void SendEmail(EmailInfo email)
        {
            Email = email;
        }
    }

    public class EmailInfo : IEquatable<EmailInfo>
    {
        public string To;
        public string Subject;
        public string Body;

        public bool Equals(EmailInfo otherEmail)
        {
            if (otherEmail is null) return false;
            return otherEmail.To == To && otherEmail.Subject == Subject && otherEmail.Body == Body;
        }
    }
}