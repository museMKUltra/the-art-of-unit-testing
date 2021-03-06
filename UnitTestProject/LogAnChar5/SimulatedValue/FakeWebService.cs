namespace UnitTestProject.LogAnChar5.SimulatedValue
{
    public interface IWebService
    {
        void Write(string message);
    }

    public class FakeWebService : IWebService
    {
        public string MessageToWebService;

        public void Write(string message)
        {
            MessageToWebService = message;
        }
    }
}