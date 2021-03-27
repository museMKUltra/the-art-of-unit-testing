namespace UnitTestProject.LogAnChar7.DontRepeatYourself
{
    public class LogAnalyzer
    {
        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                LoggingFacility.Log("Filename too short: " + fileName);
            }
        }
    }
}