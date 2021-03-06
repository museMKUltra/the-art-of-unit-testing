using System;

namespace UnitTestProject.LogAnChar5.SimulatedValue
{
    public interface ILogger
    {
        void LogError(string message);
    }

    public class FakeLogger : ILogger
    {
        public Exception WillThrow = null;
        public string LoggerGoMessage = null;

        public void LogError(string message)
        {
            LoggerGoMessage = message;
            if (WillThrow != null)
            {
                throw WillThrow;
            }
        }
    }
}