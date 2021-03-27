using Castle.Core.Internal;

namespace UnitTestProject.LogAnChar7.DontRepeatYourself
{
    public class ConfigurationManager
    {
        public bool IsConfigured(string message)
        {
            LoggingFacility.Log("Checking " + message);
            return !message.IsNullOrEmpty();
        }
    }
}