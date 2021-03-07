namespace UnitTestProject.LogAnChar5.SimulatedValue
{
    public interface IWebService
    {
        void Write(string message);
        void WriteErrorInfo(ErrorInfo errorInfo);
    }

    public class FakeWebService : IWebService
    {
        public string MessageToWebService;
        public ErrorInfo ErrorInfoToWebService;

        public void Write(string message)
        {
            MessageToWebService = message;
        }

        public void WriteErrorInfo(ErrorInfo errorInfo)
        {
            ErrorInfoToWebService = errorInfo;
        }
    }
}