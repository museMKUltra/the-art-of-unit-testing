using System;

namespace UnitTestProject.LogAnChar5.SimulatedValue
{
    public class ErrorInfo : IEquatable<ErrorInfo>
    {
        public int Severity;
        public string Message;

        public ErrorInfo(int severity, string message)
        {
            Severity = severity;
            Message = message;
        }

        public bool Equals(ErrorInfo otherInfo)
        {
            if (otherInfo is null) return false;
            return otherInfo.Severity == Severity && otherInfo.Message.Contains("fake exception");
        }
    }
}