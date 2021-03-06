namespace UnitTestProject.LogAnChar5
{
    public interface IWebService
    {
        void LogError(string message);
    }

    public class FakeWebService : IWebService
    {
        public string LastError;

        public void LogError(string message)
        {
            LastError = message;
        }
    }
}