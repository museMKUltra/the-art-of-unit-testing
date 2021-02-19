namespace UnitTestProject.LogAnChar3
{

    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            var manager = new FileExtensionManager();
            return manager.IsValid(fileName);
        }
    }
}