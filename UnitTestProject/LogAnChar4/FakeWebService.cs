using System;

namespace UnitTestProject.LogAnChar4
{
    public interface IWebService
    {
        void LogError(string message);
    }

    public class FakeWebService : IWebService
    {
        public Exception ToThrow;

        public void LogError(string message)
        {
            if (ToThrow != null)
            {
                throw ToThrow;
            }
        }
    }
}