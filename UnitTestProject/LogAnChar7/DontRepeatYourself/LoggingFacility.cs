namespace UnitTestProject.LogAnChar7.DontRepeatYourself
{
    public interface ILogger
    {
        void Log(string text);
    }

    public static class LoggingFacility
    {
        public static ILogger Logger { get; set; }

        public static void Log(string text)
        {
            Logger.Log(text);
        }
    }
}